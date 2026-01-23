using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class LightingDemo : IDisposable
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
        OrbitControls? controls;
        ActionCallback<float>? animateCallback;

        // Lights
        DirectionalLight? directionalLight;
        PointLight? pointLight;
        SpotLight? spotLight;
        HemisphereLight? hemisphereLight;

        // Light helpers
        DirectionalLightHelper? directionalHelper;
        PointLightHelper? pointHelper;
        SpotLightHelper? spotHelper;
        HemisphereLightHelper? hemisphereHelper;

        // Toggle states
        bool directionalEnabled = true;
        bool pointEnabled = true;
        bool spotEnabled = true;
        bool hemisphereEnabled = true;

        float animationTime = 0;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await THREE.Ready;
                
                canvas = new HTMLCanvasElement(canvasRef);
                var width = canvas.ClientWidth;
                var height = canvas.ClientHeight;

                scene = new THREE.Scene();
                scene.Background = new THREE.Color(0x111122);
                
                camera = new THREE.PerspectiveCamera(60, (float)width / height, 0.1f, 1000f);
                camera.Position.Set(8, 8, 12);

                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true
                });
                renderer.SetSize(width, height, false);
                renderer.ShadowMap.Enabled = true;

                // Create scene objects
                CreateSceneObjects();
                
                // Create lights
                CreateLights();

                controls = new THREE.OrbitControls(camera, canvas);
                controls.EnableDamping = true;

                animateCallback = new ActionCallback<float>(Animate);
                renderer.SetAnimationLoop(animateCallback);
                StateHasChanged();
            }
        }

        void CreateSceneObjects()
        {
            // Floor
            var floorGeometry = new THREE.PlaneGeometry(20, 20, 1, 1);
            var floorMaterial = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters 
            { 
                Color = 0x404040,
                Roughness = 0.9f,
                Metalness = 0.1f
            });
            var floor = new THREE.Mesh<PlaneGeometry, MeshStandardMaterial>(floorGeometry, floorMaterial);
            floor.Rotation.X = -(float)Math.PI / 2;
            floor.ReceiveShadow = true;
            scene!.Add(floor);

            // Central sphere
            var sphereGeometry = new THREE.SphereGeometry(1.5f, 32, 32, 0, (float)Math.PI * 2, 0, (float)Math.PI);
            var sphereMaterial = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters 
            { 
                Color = 0xffffff,
                Roughness = 0.3f,
                Metalness = 0.0f
            });
            var sphere = new THREE.Mesh<SphereGeometry, MeshStandardMaterial>(sphereGeometry, sphereMaterial);
            sphere.Position.Set(0, 2, 0);
            sphere.CastShadow = true;
            scene.Add(sphere);

            // Surrounding cubes
            for (int i = 0; i < 6; i++)
            {
                var angle = (float)i / 6 * (float)Math.PI * 2;
                var cubeGeometry = new THREE.BoxGeometry(0.8f, 0.8f, 0.8f);
                var cubeMaterial = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters 
                { 
                    Color = GetColorFromAngle(angle),
                    Roughness = 0.5f,
                    Metalness = 0.3f
                });
                var cube = new THREE.Mesh<BoxGeometry, MeshStandardMaterial>(cubeGeometry, cubeMaterial);
                cube.Position.Set(
                    (float)Math.Sin(angle) * 4,
                    0.6f,
                    (float)Math.Cos(angle) * 4
                );
                cube.CastShadow = true;
                cube.ReceiveShadow = true;
                scene.Add(cube);
            }
        }

        int GetColorFromAngle(float angle)
        {
            int r = (int)(Math.Sin(angle) * 127 + 128);
            int g = (int)(Math.Sin(angle + 2) * 127 + 128);
            int b = (int)(Math.Sin(angle + 4) * 127 + 128);
            return (r << 16) | (g << 8) | b;
        }

        void CreateLights()
        {
            // Ambient light (always on, low intensity)
            var ambientLight = new THREE.AmbientLight(0xffffff, 0.1f);
            scene!.Add(ambientLight);

            // Directional Light (sun-like)
            directionalLight = new THREE.DirectionalLight(0xfff4e5, 0.8f);
            directionalLight.Position.Set(10, 15, 10);
            directionalLight.CastShadow = true;
            scene.Add(directionalLight);

            directionalHelper = new THREE.DirectionalLightHelper(directionalLight, 2);
            scene.Add(directionalHelper);

            // Point Light (bulb-like)
            pointLight = new THREE.PointLight(0xff6b6b, 1.0f, 20, 2);
            pointLight.Position.Set(-5, 4, 0);
            pointLight.CastShadow = true;
            scene.Add(pointLight);

            pointHelper = new THREE.PointLightHelper(pointLight, 0.5f);
            scene.Add(pointHelper);

            // Spot Light (flashlight-like)
            spotLight = new THREE.SpotLight(0x6bff6b, 2.0f, 20, (float)Math.PI / 6, 0.5f, 2);
            spotLight.Position.Set(5, 6, 5);
            spotLight.CastShadow = true;
            scene.Add(spotLight);

            var spotTarget = new THREE.Object3D();
            spotTarget.Position.Set(0, 0, 0);
            scene.Add(spotTarget);
            spotLight.Target = spotTarget;

            spotHelper = new THREE.SpotLightHelper(spotLight);
            scene.Add(spotHelper);

            // Hemisphere Light (sky/ground)
            hemisphereLight = new THREE.HemisphereLight(0x87ceeb, 0x8b4513, 0.5f);
            scene.Add(hemisphereLight);

            hemisphereHelper = new THREE.HemisphereLightHelper(hemisphereLight, 2);
            scene.Add(hemisphereHelper);
        }

        void ToggleDirectional(ChangeEventArgs e)
        {
            directionalEnabled = (bool)(e.Value ?? false);
            if (directionalLight != null) directionalLight.Visible = directionalEnabled;
            if (directionalHelper != null) directionalHelper.Visible = directionalEnabled;
        }

        void TogglePoint(ChangeEventArgs e)
        {
            pointEnabled = (bool)(e.Value ?? false);
            if (pointLight != null) pointLight.Visible = pointEnabled;
            if (pointHelper != null) pointHelper.Visible = pointEnabled;
        }

        void ToggleSpot(ChangeEventArgs e)
        {
            spotEnabled = (bool)(e.Value ?? false);
            if (spotLight != null) spotLight.Visible = spotEnabled;
            if (spotHelper != null) spotHelper.Visible = spotEnabled;
        }

        void ToggleHemisphere(ChangeEventArgs e)
        {
            hemisphereEnabled = (bool)(e.Value ?? false);
            if (hemisphereLight != null) hemisphereLight.Visible = hemisphereEnabled;
            if (hemisphereHelper != null) hemisphereHelper.Visible = hemisphereEnabled;
        }

        void Animate(float time)
        {
            animationTime = time * 0.001f;

            // Animate point light position
            if (pointLight != null && pointEnabled)
            {
                pointLight.Position.X = (float)Math.Sin(animationTime) * 5;
                pointLight.Position.Z = (float)Math.Cos(animationTime) * 5;
            }

            // Animate spot light position
            if (spotLight != null && spotEnabled)
            {
                spotLight.Position.X = (float)Math.Sin(animationTime * 0.5f + Math.PI) * 6;
                spotLight.Position.Z = (float)Math.Cos(animationTime * 0.5f + Math.PI) * 6;
            }

            // Update helpers
            pointHelper?.Update();
            spotHelper?.Update();

            controls?.Update();
            renderer?.Render(scene!, camera!);
        }

        public void Dispose()
        {
            renderer?.SetAnimationLoop(null);
            animateCallback?.Dispose();
            directionalHelper?.Dispose();
            pointHelper?.Dispose();
            spotHelper?.Dispose();
            hemisphereHelper?.Dispose();
            directionalLight?.Dispose();
            pointLight?.Dispose();
            spotLight?.Dispose();
            hemisphereLight?.Dispose();
            controls?.DisposeJS();
            scene?.Dispose();
            camera?.Dispose();
            renderer?.Dispose();
        }
    }
}
