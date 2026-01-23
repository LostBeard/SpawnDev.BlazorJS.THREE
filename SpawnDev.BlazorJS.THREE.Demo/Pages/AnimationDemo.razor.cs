using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class AnimationDemo : IDisposable
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
        Group? group;
        List<Mesh> cubes = new List<Mesh>();
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
                camera.Position.Set(0, 5, 10);
                camera.LookAt(0, 0, 0);

                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true
                });
                renderer.SetSize(width, height, false);

                group = new THREE.Group();
                scene.Add(group);

                var geometry = new THREE.BoxGeometry(0.5f, 0.5f, 0.5f);
                
                for (int x = -5; x <= 5; x++)
                {
                    for (int z = -5; z <= 5; z++)
                    {
                        var material = new THREE.MeshPhongMaterial(new MeshPhongMaterialParameters 
                        { 
                            Color = 0xffffff 
                        });
                        var cube = new THREE.Mesh<BoxGeometry, MeshPhongMaterial>(geometry, material);
                        cube.Position.Set(x, 0, z);
                        group.Add(cube);
                        cubes.Add(cube);
                    }
                }

                var light = new THREE.DirectionalLight(0xffffff, 1);
                light.Position.Set(5, 10, 5);
                scene.Add(light);

                var ambientLight = new THREE.AmbientLight(0xffffff, 0.3f);
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
            float t = time / 1000f;
            for (int i = 0; i < cubes.Count; i++)
            {
                var cube = cubes[i];
                float x = cube.Position.X;
                float z = cube.Position.Z;
                float y = (float)Math.Sin(x * 0.5f + t) + (float)Math.Cos(z * 0.5f + t);
                cube.Position.Y = y;
                
                // Color change based on height
                using var color = new THREE.Color(0xffffff);
                color.SetHSL((y + 2) / 4f, 1, 0.5f);
                ((MeshPhongMaterial)((Mesh<BoxGeometry, MeshPhongMaterial>)cube).Material).Color.Copy(color);
            }

            controls?.Update();
            renderer?.Render(scene!, camera!);
        }

        public void Dispose()
        {
            renderer?.SetAnimationLoop(null);
            animateCallback?.Dispose();
            controls?.DisposeJS();
            group?.Dispose();
            foreach (var cube in cubes) cube.Dispose();
            scene?.Dispose();
            camera?.Dispose();
            renderer?.Dispose();
        }
    }
}
