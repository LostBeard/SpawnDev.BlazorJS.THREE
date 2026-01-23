using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class SkyboxDemo : IDisposable
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
        FlyControls? controls;
        ActionCallback<float>? animateCallback;
        List<Mesh> reflectiveObjects = new List<Mesh>();
        CubeTexture? envTexture;
        float lastTime = 0;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await THREE.Ready;
                
                canvas = new HTMLCanvasElement(canvasRef);
                var width = canvas.ClientWidth;
                var height = canvas.ClientHeight;

                scene = new THREE.Scene();
                
                camera = new THREE.PerspectiveCamera(60, (float)width / height, 0.1f, 1000f);
                camera.Position.Set(0, 2, 10);

                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true
                });
                renderer.SetSize(width, height, false);
                renderer.ToneMapping = (int)Constants.ACESFilmicToneMapping;
                renderer.ToneMappingExposure = 1.0f;

                // Create procedural skybox (gradient sphere)
                CreateProceduralSkybox();

                // Create reflective objects
                CreateReflectiveObjects();

                // Add subtle ambient light
                var ambientLight = new THREE.AmbientLight(0xffffff, 0.3f);
                scene.Add(ambientLight);

                // Add point lights for reflections
                var pointLight1 = new THREE.PointLight(0xff6b6b, 1.0f, 50, 2);
                pointLight1.Position.Set(10, 10, 10);
                scene.Add(pointLight1);

                var pointLight2 = new THREE.PointLight(0x6b6bff, 1.0f, 50, 2);
                pointLight2.Position.Set(-10, 10, -10);
                scene.Add(pointLight2);

                controls = new THREE.FlyControls(camera, canvas);
                controls.MovementSpeed = 25.0f;
                controls.RollSpeed = (float)Math.PI / 24;
                controls.AutoForward = false;
                controls.DragToLook = true;

                animateCallback = new ActionCallback<float>(Animate);
                renderer.SetAnimationLoop(animateCallback);
                StateHasChanged();
            }
        }

        void CreateProceduralSkybox()
        {
            // Create a large sphere with gradient shader for procedural sky effect
            var skyGeometry = new THREE.SphereGeometry(500, 32, 32, 0, (float)Math.PI * 2, 0, (float)Math.PI);
            
            // Use a vertex color approach for gradient
            var skyMaterial = new THREE.MeshBasicMaterial(new MeshBasicMaterialParameters
            {
                Side = (int)Constants.DoubleSide,
                DepthWrite = false
            });
            
            // Set scene background as fallback
            scene!.Background = new THREE.Color(0x1a1a3e);
            
            // Create gradient colors manually by setting a color
            skyMaterial.Color = new THREE.Color(0x1a1a3e);

            var sky = new THREE.Mesh<SphereGeometry, MeshBasicMaterial>(skyGeometry, skyMaterial);
            scene!.Add(sky);

            // Add stars as points
            var starsGeometry = new THREE.BufferGeometry();
            var starPositions = new float[6000]; // 2000 stars * 3 coords
            var random = new Random(42);
            
            for (int i = 0; i < starPositions.Length; i += 3)
            {
                // Random position on sphere
                var theta = random.NextDouble() * Math.PI * 2;
                var phi = Math.Acos(2 * random.NextDouble() - 1);
                var radius = 400 + random.NextDouble() * 50;
                
                starPositions[i] = (float)(radius * Math.Sin(phi) * Math.Cos(theta));
                starPositions[i + 1] = (float)(radius * Math.Sin(phi) * Math.Sin(theta));
                starPositions[i + 2] = (float)(radius * Math.Cos(phi));
            }

            var posAttribute = new THREE.Float32BufferAttribute(starPositions, 3);
            starsGeometry.SetAttribute("position", posAttribute);

            var starsMaterial = new THREE.PointsMaterial(new PointsMaterialParameters
            {
                Color = 0xffffff,
                Size = 2
            });

            var stars = new THREE.Points(starsGeometry, starsMaterial);
            scene.Add(stars);

            // Add a grid for reference
            var gridHelper = new THREE.GridHelper(50, 50, 0x444488, 0x222244);
            scene.Add(gridHelper);
        }

        void CreateReflectiveObjects()
        {
            // Chrome sphere (highly reflective)
            var sphereGeometry = new THREE.SphereGeometry(1.5f, 64, 64, 0, (float)Math.PI * 2, 0, (float)Math.PI);
            var chromeMaterial = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters
            {
                Color = 0xffffff,
                Metalness = 1.0f,
                Roughness = 0.0f
            });
            var chromeSphere = new THREE.Mesh<SphereGeometry, MeshStandardMaterial>(sphereGeometry, chromeMaterial);
            chromeSphere.Position.Set(-4, 2, 0);
            scene!.Add(chromeSphere);
            reflectiveObjects.Add(chromeSphere);

            // Glass sphere (transparent)
            var glassMaterial = new THREE.MeshPhysicalMaterial(new MeshPhysicalMaterialParameters
            {
                Color = 0xffffff,
                Metalness = 0.0f,
                Roughness = 0.0f,
                Transmission = 0.9f,
                Thickness = 1.5f,
                IOR = 1.5f
            });
            var glassSphere = new THREE.Mesh<SphereGeometry, MeshPhysicalMaterial>(sphereGeometry, glassMaterial);
            glassSphere.Position.Set(0, 2, 0);
            scene.Add(glassSphere);
            reflectiveObjects.Add(glassSphere);

            // Gold torus
            var torusGeometry = new THREE.TorusKnotGeometry(1f, 0.3f, 128, 32);
            var goldMaterial = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters
            {
                Color = 0xffd700,
                Metalness = 1.0f,
                Roughness = 0.2f
            });
            var goldTorus = new THREE.Mesh<TorusKnotGeometry, MeshStandardMaterial>(torusGeometry, goldMaterial);
            goldTorus.Position.Set(4, 2, 0);
            scene.Add(goldTorus);
            reflectiveObjects.Add(goldTorus);

            // Copper box
            var boxGeometry = new THREE.BoxGeometry(2, 2, 2);
            var copperMaterial = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters
            {
                Color = 0xb87333,
                Metalness = 1.0f,
                Roughness = 0.3f
            });
            var copperBox = new THREE.Mesh<BoxGeometry, MeshStandardMaterial>(boxGeometry, copperMaterial);
            copperBox.Position.Set(-4, 1.5f, -5);
            scene.Add(copperBox);
            reflectiveObjects.Add(copperBox);

            // Silver icosahedron
            var icoGeometry = new THREE.IcosahedronGeometry(1.5f, 0);
            var silverMaterial = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters
            {
                Color = 0xc0c0c0,
                Metalness = 1.0f,
                Roughness = 0.1f
            });
            var silverIco = new THREE.Mesh<IcosahedronGeometry, MeshStandardMaterial>(icoGeometry, silverMaterial);
            silverIco.Position.Set(4, 2, -5);
            scene.Add(silverIco);
            reflectiveObjects.Add(silverIco);
        }

        void Animate(float time)
        {
            float deltaTime = (time - lastTime) / 1000f;
            lastTime = time;

            // Rotate objects for visual interest
            foreach (var obj in reflectiveObjects)
            {
                obj.Rotation.Y += 0.005f;
                obj.Rotation.X += 0.002f;
            }

            controls?.Update(deltaTime);
            renderer?.Render(scene!, camera!);
        }

        public void Dispose()
        {
            renderer?.SetAnimationLoop(null);
            animateCallback?.Dispose();
            envTexture?.Dispose();
            foreach (var obj in reflectiveObjects) obj.Dispose();
            reflectiveObjects.Clear();
            controls?.DisposeJS();
            scene?.Dispose();
            camera?.Dispose();
            renderer?.Dispose();
        }
    }
}
