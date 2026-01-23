using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class GeometriesDemo : IDisposable
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
                camera.Position.Z = 12;

                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true
                });
                renderer.SetSize(width, height, false);

                var material = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters { Color = 0x0088ff, Roughness = 0.5f });

                // Box
                var geoBox = new THREE.BoxGeometry(1.5f, 1.5f, 1.5f);
                var meshBox = new THREE.Mesh<BoxGeometry, MeshStandardMaterial>(geoBox, material);
                meshBox.Position.X = -6;
                scene.Add(meshBox);
                meshes.Add(meshBox);

                // Sphere
                var geoSphere = new THREE.SphereGeometry(1, 32, 16, 0, (float)Math.PI * 2, 0, (float)Math.PI);
                var meshSphere = new THREE.Mesh<SphereGeometry, MeshStandardMaterial>(geoSphere, material);
                meshSphere.Position.X = -3;
                scene.Add(meshSphere);
                meshes.Add(meshSphere);

                // Cylinder
                var geoCylinder = new THREE.CylinderGeometry(0.7f, 0.7f, 2, 32, 1, false, 0, (float)Math.PI * 2);
                var meshCylinder = new THREE.Mesh<CylinderGeometry, MeshStandardMaterial>(geoCylinder, material);
                meshCylinder.Position.X = 0;
                scene.Add(meshCylinder);
                meshes.Add(meshCylinder);

                // Torus
                var geoTorus = new THREE.TorusGeometry(1, 0.4f, 16, 100, (float)Math.PI * 2);
                var meshTorus = new THREE.Mesh<TorusGeometry, MeshStandardMaterial>(geoTorus, material);
                meshTorus.Position.X = 3;
                scene.Add(meshTorus);
                meshes.Add(meshTorus);

                // TorusKnot
                var geoTorusKnot = new THREE.TorusKnotGeometry(0.8f, 0.3f, 100, 16, 2, 3);
                var meshTorusKnot = new THREE.Mesh<TorusKnotGeometry, MeshStandardMaterial>(geoTorusKnot, material);
                meshTorusKnot.Position.X = 6;
                scene.Add(meshTorusKnot);
                meshes.Add(meshTorusKnot);

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
                mesh.Rotation.X += 0.01f;
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
            scene?.Dispose();
            camera?.Dispose();
            renderer?.Dispose();
        }
    }
}
