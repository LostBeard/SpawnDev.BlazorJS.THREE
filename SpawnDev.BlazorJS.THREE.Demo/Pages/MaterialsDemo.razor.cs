using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class MaterialsDemo : IDisposable
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
        List<Mesh> meshes = new List<Mesh>();
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
                camera.Position.Z = 10;

                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true
                });
                renderer.SetSize(width, height, false);

                var geometry = new THREE.SphereGeometry(1, 32, 32, 0, (float)Math.PI * 2, 0, (float)Math.PI);

                // Basic
                var materialBasic = new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters { Color = 0xff0000 });
                var meshBasic = new THREE.Mesh<SphereGeometry, MeshBasicMaterial>(geometry, materialBasic);
                meshBasic.Position.X = -6;
                scene.Add(meshBasic);
                meshes.Add(meshBasic);

                // Lambert
                var materialLambert = new THREE.MeshLambertMaterial(new MeshLambertMaterialParameters { Color = 0x00ff00 });
                var meshLambert = new THREE.Mesh<SphereGeometry, MeshLambertMaterial>(geometry, materialLambert);
                meshLambert.Position.X = -3;
                scene.Add(meshLambert);
                meshes.Add(meshLambert);

                // Phong
                var materialPhong = new THREE.MeshPhongMaterial(new MeshPhongMaterialParameters { Color = 0x0000ff, Shininess = 100 });
                var meshPhong = new THREE.Mesh<SphereGeometry, MeshPhongMaterial>(geometry, materialPhong);
                meshPhong.Position.X = 0;
                scene.Add(meshPhong);
                meshes.Add(meshPhong);

                // Standard
                var materialStandard = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters { Color = 0xffff00, Roughness = 0.5f, Metalness = 0.5f });
                var meshStandard = new THREE.Mesh<SphereGeometry, MeshStandardMaterial>(geometry, materialStandard);
                meshStandard.Position.X = 3;
                scene.Add(meshStandard);
                meshes.Add(meshStandard);

                // Physical
                var materialPhysical = new THREE.MeshPhysicalMaterial(new MeshPhysicalMaterialParameters { Color = 0xff00ff, Roughness = 0.1f, Metalness = 0.8f, Transmission = 0.5f, Thickness = 1 });
                var meshPhysical = new THREE.Mesh<SphereGeometry, MeshPhysicalMaterial>(geometry, materialPhysical);
                meshPhysical.Position.X = 6;
                scene.Add(meshPhysical);
                meshes.Add(meshPhysical);

                var light = new THREE.DirectionalLight(0xffffff, 1);
                light.Position.Set(5, 5, 5);
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
            foreach (var mesh in meshes)
            {
                mesh.Rotation.Y += 0.01f;
            }

            controls?.Update();
            renderer?.Render(scene!, camera!);
        }

        public void Dispose()
        {
            renderer?.SetAnimationLoop(null);
            animateCallback?.Dispose();
            controls?.DisposeJS();
            foreach (var mesh in meshes) mesh.Dispose();
            meshes.Clear();
            scene?.Dispose();
            camera?.Dispose();
            renderer?.Dispose();
        }
    }
}
