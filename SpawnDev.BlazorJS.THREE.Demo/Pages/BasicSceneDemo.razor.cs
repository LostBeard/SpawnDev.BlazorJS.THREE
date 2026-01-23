using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class BasicSceneDemo : IDisposable
    {
        [Inject]
        BlazorJSRuntime JS { get; set; } = default!;

        [Inject]
        THREEService THREE { get; set; } = default!;

        ElementReference canvasRef;
        HTMLCanvasElement? canvas;
        Scene? scene;
        PerspectiveCamera? camera;
        WebGLRenderer? renderer;
        Mesh? cube;
        OrbitControls? controls;
        ActionCallback<float>? animateCallback;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await THREE.Ready;
                
                canvas = new HTMLCanvasElement(canvasRef);
                var width = canvas.ClientWidth;
                var height = canvas.ClientHeight;

                scene = new THREE.Scene();
                
                camera = new THREE.PerspectiveCamera(75, (float)width / height, 0.1f, 1000f);
                camera.Position.Z = 5;

                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true
                });
                renderer.SetSize(width, height, false);

                var geometry = new THREE.BoxGeometry(1, 1, 1);
                var material = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters { Color = 0x00ff00 });
                cube = new THREE.Mesh<BoxGeometry, MeshStandardMaterial>(geometry, material);
                scene.Add(cube);

                var light = new THREE.DirectionalLight(0xffffff, 1);
                light.Position.Set(1, 1, 1);
                scene.Add(light);

                var ambientLight = new THREE.AmbientLight(0xffffff, 0.5f);
                scene.Add(ambientLight);

                controls = new THREE.OrbitControls(camera, canvas);
                controls.EnableDamping = true;

                animateCallback = new ActionCallback<float>(Animate);
                renderer.SetAnimationLoop(animateCallback);
                StateHasChanged();
            }
        }

        void Animate(float time)
        {
            if (cube != null)
            {
                cube.Rotation.X += 0.01f;
                cube.Rotation.Y += 0.01f;
            }

            controls?.Update();
            renderer?.Render(scene!, camera!);
        }

        public void Dispose()
        {
            renderer?.SetAnimationLoop(null);
            animateCallback?.Dispose();
            controls?.DisposeJS();
            cube?.Dispose();
            scene?.Dispose();
            camera?.Dispose();
            renderer?.Dispose();
        }
    }
}
