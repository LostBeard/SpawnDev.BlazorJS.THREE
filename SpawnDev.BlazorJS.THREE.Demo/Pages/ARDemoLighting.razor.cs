using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;
using System.Web;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class ARDemoLighting : IDisposable
    {
        [Inject]
        BlazorJSRuntime JS { get; set; } = default!;

        [Inject]
        NavigationManager NavigationManager { get; set; } = default!;

        string OculusOpenUrl => $"https://www.oculus.com/open_url/?url={HttpUtility.UrlEncode(NavigationManager.Uri)}";

        ElementReference canvasRef;
        HTMLCanvasElement? canvas;
        Window? window;
        Document? document;
        Scene? scene;
        Camera? camera;
        WebGLRenderer? renderer;
        Mesh? mesh;
        FuncCallback<double, XRFrame?, Task>? AnimateCallback;
        XRSession? xrSession;
        XRReferenceSpace? referenceSpace;
        Mesh? triangleMesh;
        XRHitTestSource? hitTestSource;
        protected override void OnAfterRender(bool firstRender)
        {
            if (canvas == null)
            {
                // Get HTMLCanvasElement from ElementReference
                // https://github.com/mrdoob/three.js/blob/master/examples/webxr_ar_lighting.html
                canvas = new HTMLCanvasElement(canvasRef);
                window = JS.Get<Window>("window");
                document = JS.Get<Document>("document");
                var width = canvas.Width;
                var height = canvas.Height;
                scene = new THREE.Scene();

                camera = new THREE.PerspectiveCamera(70, width / height, 0.01f, 20);

                var defaultLight = new THREE.HemisphereLight(0xffffff, 0xbbbbff, 1);
                defaultLight.Position.Set(0.5f, 1f, 0.25f);
                scene.Add(defaultLight);

                //camera.Position.Z = 1;
                //using var geometry = new THREE.BoxGeometry(0.2f, 0.2f, 0.2f);
                //using var material = new THREE.MeshNormalMaterial();
                //mesh = new THREE.Mesh<BoxGeometry, MeshNormalMaterial>(geometry, material);
                //scene.Add(mesh);
                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true,
                    Alpha = true,
                });
                renderer.SetPixelRatio((float)window.DevicePixelRatio);
                renderer.SetSize(width, height);
                renderer.Xr.Enabled = true;
                AnimateCallback = new FuncCallback<double, XRFrame?, Task>(Animate);
                renderer.SetAnimationLoop(AnimateCallback);

                //var xrLight = new XREstimatedLight(renderer);
            }
        }
        void SendToHeadset()
        {
            window?.Open(OculusOpenUrl, "_blank")?.Focus();
        }
        async Task ToggleAR()
        {
            using var navigator = JS.Get<Navigator>("navigator");
            using var xr = navigator.XR;
            if (xr == null) return;
            if (xrSession == null)
            {
                try
                {
                    var session = await xr.RequestSession("immersive-ar", new XRSessionInit
                    {
                        RequiredFeatures = ["local-floor", "hit-test"]
                    });
                    await onSessionStarted(session);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                xrSession.End();
            }
        }
        async Task Animate(double time, XRFrame? frame)
        {
            try
            {
                await _Animate(time, frame);
            }
            catch (Exception ex)
            {
                var nmt = true;
            }
        }
        async Task _Animate(double time, XRFrame? frame)
        {
            JS.Set("_frame", frame);
            JS.Log("_frame", frame);
            if (mesh == null || renderer == null || scene == null || camera == null) return;
            if (xrSession != null && frame != null)
            {
                var referenceSpace = renderer.Xr.GetReferenceSpace();
                var session = renderer.Xr.GetSession();

                if (session != null && referenceSpace != null)
                {
                    if (hitTestSource == null)
                    {
                        // Request hit test source once
                        hitTestSource = await session.RequestHitTestSource(new { Space = referenceSpace });
                    }

                    if (hitTestSource != null)
                    {
                        var hitTestResults = frame.GetHitTestResults(hitTestSource);
                        if (hitTestResults.Length > 0)
                        {
                            var hit = hitTestResults[0];
                            using var pose = hit.GetPose(referenceSpace);

                            if (pose != null)
                            {
                                // Update camera position and orientation based on device pose
                                camera.Matrix.FromArray(pose.Transform.Matrix);
                                camera.Matrix.Decompose(camera.Position, camera.Quaternion, camera.Scale);
                            }

                            if (triangleMesh == null)
                            {
                                // Create and add triangle only once
                                using var geometry = new THREE.BufferGeometry();
                                using var vertices = new Float32Array([
                                    -0.5f, -0.5f, 0.0f,
                                    0.5f, -0.5f, 0.0f,
                                    0.0f, 0.5f, 0.0f
                                ]);
                                geometry.SetAttribute("position", new THREE.BufferAttribute(vertices, 3));
                                using var material = new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters { Color = 0x00ff00 });
                                triangleMesh = new THREE.Mesh<BufferGeometry, MeshBasicMaterial>(geometry, material);
                                scene.Add(triangleMesh);
                            }

                            // Update triangle position based on hit test
                            triangleMesh.Position.Copy(pose!.Transform.Position);
                            triangleMesh.Quaternion.Copy(pose!.Transform.Orientation);
                            hitTestResults.DisposeAll();
                        }
                    }
                }
            }
            renderer.Render(scene, camera);
        }
        void Dispose<T>(ref T? disposable) where T : class, IDisposable
        {
            disposable?.Dispose();
            disposable = null;
        }
        public void Dispose()
        {
            renderer?.DisposeJS();
            Dispose(ref triangleMesh);
            Dispose(ref renderer);
            Dispose(ref mesh);
            Dispose(ref scene);
            Dispose(ref camera);
            Dispose(ref document);
            Dispose(ref window);
            Dispose(ref AnimateCallback);
        }

        async Task onSessionStarted(XRSession session)
        {
            session.AddEventListener("end", onSessionEnded);
            renderer?.Xr.SetSession(session);
            xrSession = session;
            referenceSpace = await xrSession.RequestReferenceSpace(XRReferenceSpaceType.LocalFloor);
        }

        void onSessionEnded()
        {
            xrSession = null;
        }
    }
}
