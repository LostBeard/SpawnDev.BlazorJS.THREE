using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;
using System.Drawing;
using System.Web;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class VRDemo2 : IDisposable
    {
        [Inject]
        BlazorJSRuntime JS { get; set; } = default!;

        [Inject]
        NavigationManager NavigationManager { get; set; } = default!;

        string OculusOpenUrl => $"https://www.oculus.com/open_url/?url={HttpUtility.UrlEncode(NavigationManager.Uri)}";

        ElementReference canvasRef;
        HTMLCanvasElement? canvas;
        Window? window;
        Navigator? navigator;
        Document? document;

        WebGLRenderingContext? gl;

        Scene? scene;
        Camera? camera;
        WebGLRenderer? renderer;
        Mesh? cube;
        FuncCallback<float, XRFrame?, Task>? AnimateCallback;
        XRSession? session;
        XRReferenceSpace? referenceSpace;

        Mesh? triangleMesh;
        XRHitTestSource? hitTestSource;
        protected override void OnAfterRender(bool firstRender)
        {
            if (canvas == null)
            {
                canvas = new HTMLCanvasElement(canvasRef);
                window = JS.Get<Window>("window");
                document = JS.Get<Document>("document");
                navigator = JS.Get<Navigator>("navigator");
            }
        }
        void SendToHeadset()
        {
            window?.Open(OculusOpenUrl, "_blank")?.Focus();
        }
        async Task ActivateXR()
        {
            gl = canvas!.GetWebGL2Context(new WebGLContextAttributes { XrCompatible = true });
            scene = new THREE.Scene();
            MeshBasicMaterial[] materials = [
                new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters{Color = 0xff0000}),
                new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters{Color = 0x0000ff}),
                new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters{Color = 0x00ff00}),
                new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters{Color = 0xff00ff}),
                new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters{Color = 0x00ffff}),
                new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters{Color = 0xffff00})
            ];

            // Create the cube and add it to the demo scene.
            cube = new THREE.Mesh<BoxGeometry, MeshBasicMaterial[]>(new BoxGeometry(1, 1, 1), materials);
            cube.Position.Set(1, 1, 1);
            scene.Add(cube);

            // Set up the WebGLRenderer, which handles rendering to the session's base layer.
            renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
            {
                Alpha = true,
                PreserveDrawingBuffer = true,
                Canvas = canvas,
                Context = gl
            });
            renderer.AutoClear = false;

            // The API directly updates the camera matrices.
            // Disable matrix auto updates so three.js doesn't attempt
            // to handle the matrices independently.
            camera = new THREE.PerspectiveCamera(70f,
    canvas.Width / canvas.Height,
    0.02f,
    20);
            camera.MatrixAutoUpdate = false;

            // Initialize a WebXR session using "immersive-ar".
            session = await navigator!.XR!.RequestSession("immersive-ar");
            session.UpdateRenderState(new XRRenderStateInit
            {
                BaseLayer = new XRWebGLLayer(session, gl)
            });

            // A 'local' reference space has a native origin that is located
            // near the viewer's position at the time the session was created.
            referenceSpace = await session.RequestReferenceSpace("local");

            session.RequestAnimationFrame((time, frame) => _ = Animate(time, frame));
        }
        async Task Animate(double time, XRFrame? frame)
        {
            if (cube == null || renderer == null || scene == null || camera == null)
            {
                return;
            }
            try
            {
                await _Animate(time, frame);
            }
            catch (Exception ex)
            {
                var nmt = true;
            }
            session?.RequestAnimationFrame((time, frame) => _ = Animate(time, frame));
        }
        async Task _Animate(double time, XRFrame? frame)
        {
            if (session != null && frame != null)
            {
                cube.Rotation.Y += 0.01f;
                cube.Rotation.X += 0.01f;


                // Bind the graphics framebuffer to the baseLayer's framebuffer
                gl.BindFramebuffer(gl.FRAMEBUFFER, session.RenderState.BaseLayer.Framebuffer);

                // Retrieve the pose of the device.
                // XRFrame.getViewerPose can return null while the session attempts to establish tracking.
                var pose = frame.GetViewerPose(referenceSpace);
                if (pose != null)
                {
                    // In mobile AR, we only have one view.
                    var view = pose.Views[0];

                    var viewport = session.RenderState.BaseLayer.GetViewport(view);
                    renderer.SetSize(viewport.Width, viewport.Height);

                    // Use the view's transform matrix and projection matrix to configure the THREE.camera.
                    camera.Matrix.FromArray(view.Transform.Matrix);
                    camera.ProjectionMatrix.FromArray(view.ProjectionMatrix);
                    camera.UpdateMatrixWorld(true);
                }
            }

            // Render the scene with THREE.WebGLRenderer.
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
            Dispose(ref cube);
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
            this.session = session;
            referenceSpace = await this.session.RequestReferenceSpace(XRReferenceSpaceType.LocalFloor);
        }

        void onSessionEnded()
        {
            session = null;
        }
    }
}
