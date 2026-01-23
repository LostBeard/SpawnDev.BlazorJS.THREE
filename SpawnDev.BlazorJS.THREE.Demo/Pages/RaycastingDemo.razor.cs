using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE.Demo.Pages
{
    public partial class RaycastingDemo : IDisposable
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
        Raycaster? raycaster;
        Vector2? mouse;
        ActionCallback<float>? animateCallback;
        ActionCallback<MouseEvent>? mouseMoveCallback;
        ActionCallback<MouseEvent>? clickCallback;
        List<Mesh> interactiveObjects = new List<Mesh>();
        Mesh? hoveredObject;
        Mesh? selectedObject;
        string selectedInfo = "";
        Dictionary<Mesh, int> originalColors = new Dictionary<Mesh, int>();

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await THREE.Ready;
                
                canvas = new HTMLCanvasElement(canvasRef);
                var width = canvas.ClientWidth;
                var height = canvas.ClientHeight;

                scene = new THREE.Scene();
                scene.Background = new THREE.Color(0x16213e);
                
                camera = new THREE.PerspectiveCamera(60, (float)width / height, 0.1f, 1000f);
                camera.Position.Set(0, 5, 10);

                renderer = new THREE.WebGLRenderer(new WebGLRendererParameters
                {
                    Canvas = canvas,
                    Antialias = true
                });
                renderer.SetSize(width, height, false);

                raycaster = new THREE.Raycaster();
                mouse = new THREE.Vector2();

                // Create interactive objects
                CreateObjects();

                // Add lights
                var ambientLight = new THREE.AmbientLight(0xffffff, 0.5f);
                scene.Add(ambientLight);

                var directionalLight = new THREE.DirectionalLight(0xffffff, 0.8f);
                directionalLight.Position.Set(10, 10, 5);
                scene.Add(directionalLight);

                // Add floor
                var floorGeometry = new THREE.PlaneGeometry(20, 20, 1, 1);
                var floorMaterial = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters 
                { 
                    Color = 0x333333,
                    Roughness = 0.8f
                });
                var floor = new THREE.Mesh<PlaneGeometry, MeshStandardMaterial>(floorGeometry, floorMaterial);
                floor.Rotation.X = -(float)Math.PI / 2;
                scene.Add(floor);

                controls = new THREE.OrbitControls(camera, canvas);
                controls.EnableDamping = true;

                // Setup mouse events
                mouseMoveCallback = new ActionCallback<MouseEvent>(OnMouseMove);
                canvas.AddEventListener("mousemove", mouseMoveCallback);

                clickCallback = new ActionCallback<MouseEvent>(OnClick);
                canvas.AddEventListener("click", clickCallback);

                animateCallback = new ActionCallback<float>(Animate);
                renderer.SetAnimationLoop(animateCallback);
                StateHasChanged();
            }
        }

        void CreateObjects()
        {
            // Create various geometric objects
            var geometries = new BufferGeometry[]
            {
                new THREE.BoxGeometry(1, 1, 1),
                new THREE.SphereGeometry(0.6f, 32, 32, 0, (float)Math.PI * 2, 0, (float)Math.PI),
                new THREE.ConeGeometry(0.5f, 1, 32, 1, false, 0, (float)Math.PI * 2),
                new THREE.TorusGeometry(0.5f, 0.2f, 16, 100, (float)Math.PI * 2),
                new THREE.CylinderGeometry(0.4f, 0.4f, 1, 32, 1, false, 0, (float)Math.PI * 2),
                new THREE.OctahedronGeometry(0.6f, 0),
                new THREE.IcosahedronGeometry(0.5f, 0),
                new THREE.TorusKnotGeometry(0.4f, 0.15f, 64, 8)
            };

            var colors = new int[] { 0xe94560, 0x0f3460, 0x533483, 0x00b4d8, 0x90e0ef, 0xffd166, 0x06d6a0, 0xef476f };
            var names = new string[] { "Cube", "Sphere", "Cone", "Torus", "Cylinder", "Octahedron", "Icosahedron", "TorusKnot" };

            float spacing = 2.5f;
            int cols = 4;

            for (int i = 0; i < geometries.Length; i++)
            {
                var material = new THREE.MeshStandardMaterial(new MeshStandardMaterialParameters 
                { 
                    Color = colors[i],
                    Metalness = 0.3f,
                    Roughness = 0.4f
                });
                
                var mesh = new THREE.Mesh(geometries[i], material);
                
                int row = i / cols;
                int col = i % cols;
                mesh.Position.Set(
                    (col - (cols - 1) / 2.0f) * spacing,
                    0.7f,
                    (row - 0.5f) * spacing
                );
                mesh.Name = names[i];
                
                scene!.Add(mesh);
                interactiveObjects.Add(mesh);
                originalColors[mesh] = colors[i];
            }
        }

        void OnMouseMove(MouseEvent evt)
        {
            if (canvas == null || mouse == null) return;

            var rect = canvas.GetBoundingClientRect();
            mouse.X = (float)((evt.ClientX - rect.Left) / rect.Width) * 2 - 1;
            mouse.Y = -((float)((evt.ClientY - rect.Top) / rect.Height) * 2 - 1);
        }

        void OnClick(MouseEvent evt)
        {
            if (hoveredObject != null)
            {
                // Reset previous selection
                if (selectedObject != null && selectedObject != hoveredObject)
                {
                    var prevMaterial = selectedObject.Material as MeshStandardMaterial;
                    if (prevMaterial != null && originalColors.ContainsKey(selectedObject))
                    {
                        prevMaterial.Color = new THREE.Color(originalColors[selectedObject]);
                    }
                }

                selectedObject = hoveredObject;
                selectedInfo = $"Selected: {selectedObject.Name}";
                StateHasChanged();
            }
        }

        void Animate(float time)
        {
            // Rotate objects
            foreach (var obj in interactiveObjects)
            {
                obj.Rotation.Y += 0.005f;
            }

            // Perform raycasting
            if (raycaster != null && mouse != null && camera != null)
            {
                raycaster.SetFromCamera(mouse, camera);
                
                // Convert List to array for IntersectObjects
                var objectsArray = interactiveObjects.ToArray();
                var intersects = raycaster.IntersectObjects(objectsArray, false);

                // Reset hovered object color if it's not selected
                if (hoveredObject != null && hoveredObject != selectedObject)
                {
                    var material = hoveredObject.Material as MeshStandardMaterial;
                    if (material != null && originalColors.ContainsKey(hoveredObject))
                    {
                        material.Color = new THREE.Color(originalColors[hoveredObject]);
                    }
                    hoveredObject = null;
                }

                // Set new hovered object
                if (intersects != null && intersects.Length > 0)
                {
                    var obj = intersects[0].Object as Mesh;
                    if (obj != null && obj != selectedObject)
                    {
                        hoveredObject = obj;
                        var material = obj.Material as MeshStandardMaterial;
                        if (material != null)
                        {
                            material.Color = new THREE.Color(0xffffff); // Highlight color
                        }
                    }
                }

                // Keep selected object highlighted in gold
                if (selectedObject != null)
                {
                    var selectedMaterial = selectedObject.Material as MeshStandardMaterial;
                    if (selectedMaterial != null)
                    {
                        selectedMaterial.Color = new THREE.Color(0xffd700); // Gold for selected
                    }
                }
            }

            controls?.Update();
            renderer?.Render(scene!, camera!);
        }

        public void Dispose()
        {
            renderer?.SetAnimationLoop(null);
            animateCallback?.Dispose();
            mouseMoveCallback?.Dispose();
            clickCallback?.Dispose();
            raycaster?.Dispose();
            mouse?.Dispose();
            foreach (var mesh in interactiveObjects) mesh.Dispose();
            interactiveObjects.Clear();
            controls?.DisposeJS();
            scene?.Dispose();
            camera?.Dispose();
            renderer?.Dispose();
        }
    }
}
