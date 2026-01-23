using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class GLTFModelDemo : IDisposable
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
        AnimationMixer? mixer;
        ActionCallback<float>? animateCallback;
        Group? model;
        bool isLoading = true;
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
                scene.Background = new THREE.Color(0x1a1a2e);
                
                camera = new THREE.PerspectiveCamera(45, (float)width / height, 0.1f, 1000f);
                camera.Position.Set(0, 2, 5);

                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true
                });
                renderer.SetSize(width, height, false);
                renderer.SetPixelRatio(JS.Get<float>("devicePixelRatio"));

                // Add lights
                var ambientLight = new THREE.AmbientLight(0xffffff, 0.4f);
                scene.Add(ambientLight);

                var directionalLight = new THREE.DirectionalLight(0xffffff, 1.0f);
                directionalLight.Position.Set(5, 10, 7.5f);
                scene.Add(directionalLight);

                // Add a grid helper for reference
                var gridHelper = new THREE.GridHelper(10, 10, 0x444444, 0x222222);
                scene.Add(gridHelper);

                controls = new THREE.OrbitControls(camera, canvas);
                controls.EnableDamping = true;
                controls.Target.Set(0, 1, 0);

                // Load GLTF model (using animated Khronos sample model)
                await LoadModel();

                animateCallback = new ActionCallback<float>(Animate);
                renderer.SetAnimationLoop(animateCallback);
                StateHasChanged();
            }
        }

        async Task LoadModel()
        {
            try
            {
                var loader = new THREE.GLTFLoader();
                
                // Load the animated Fox model from Khronos glTF samples
                var modelUrl = "https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Assets/main/Models/Fox/glTF/Fox.gltf";
                
                var gltf = await loader.LoadAsync(modelUrl);
                model = gltf.Scene;
                
                // Scale and position the model
                model.Scale.Set(0.02f, 0.02f, 0.02f);
                model.Position.Set(0, 0, 0);
                
                scene!.Add(model);

                // Setup animations if available
                var animations = gltf.Animations;
                if (animations != null && animations.Length > 0)
                {
                    mixer = new THREE.AnimationMixer(model);
                    // Play the first animation (usually "Survey" or "Walk" for the Fox)
                    var action = mixer.ClipAction(animations[0]);
                    action.Play();
                }

                isLoading = false;
                loader.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading model: {ex.Message}");
                isLoading = false;
            }
            StateHasChanged();
        }

        void Animate(float time)
        {
            float deltaTime = (time - lastTime) / 1000f;
            lastTime = time;

            // Update animation mixer
            if (mixer != null && deltaTime > 0 && deltaTime < 1)
            {
                mixer.Update(deltaTime);
            }

            controls?.Update();
            renderer?.Render(scene!, camera!);
        }

        public void Dispose()
        {
            renderer?.SetAnimationLoop(null);
            animateCallback?.Dispose();
            mixer?.Dispose();
            model?.Dispose();
            controls?.DisposeJS();
            scene?.Dispose();
            camera?.Dispose();
            renderer?.Dispose();
        }
    }
}
