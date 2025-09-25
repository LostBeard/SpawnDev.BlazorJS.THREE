using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;


namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class Home : IDisposable
    {
        [Inject]
        BlazorJSRuntime JS { get; set; } = default!;

        ElementReference canvasRef;
        HTMLCanvasElement? canvas;
        Window? window;
        Document? document;
        Scene? scene;
        Camera? camera;
        WebGLRenderer? renderer;
        Mesh? mesh;
        ActionCallback<float>? AnimateCallback;
        protected override void OnAfterRender(bool firstRender)
        {
            if (canvas == null)
            {
                // Get HTMLCanvasElement from ElementReference
                canvas = new HTMLCanvasElement(canvasRef);
                window = JS.Get<Window>("window");
                document = JS.Get<Document>("document");
                var width = canvas.Width;
                var height = canvas.Height;
                camera = new THREE.PerspectiveCamera(70, width / height, 0.01f, 10);
                camera.Position.Z = 1;
                scene = new THREE.Scene();
                using var geometry = new THREE.BoxGeometry(0.2f, 0.2f, 0.2f);
                using var material = new THREE.MeshNormalMaterial();
                mesh = new THREE.Mesh<BoxGeometry, MeshNormalMaterial>(geometry, material);
                JS.Set("_mesh",  mesh);
                scene.Add(mesh);
                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Antialias = true,
                    Canvas = canvas,
                });
                renderer.SetSize(width, height);
                AnimateCallback = new ActionCallback<float>(Animate);
                renderer.SetAnimationLoop(AnimateCallback);
            }
        }
        void Animate(float time)
        {
            if (mesh == null || renderer == null || scene == null || camera == null) return;
            mesh.Rotation.X = time / 2000f;
            mesh.Rotation.Y = time / 1000f;
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
            Dispose(ref renderer);
            Dispose(ref mesh);
            Dispose(ref scene);
            Dispose(ref camera);
            Dispose(ref document);
            Dispose(ref window);
            Dispose(ref AnimateCallback);
        }
    }
}
