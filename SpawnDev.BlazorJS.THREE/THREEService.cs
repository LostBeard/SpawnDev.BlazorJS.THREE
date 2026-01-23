using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// Loads the THREE js library at app startup so it is ready for use for all components immediately
    /// </summary>
    /// <param name="JS"></param>
    public class THREEService(BlazorJSRuntime JS) : IAsyncBackgroundService
    {
        /// <inheritdoc/>
        public Task Ready => _Ready ??= LoadReady();
        Task? _Ready;
        async Task LoadReady()
        {
            await JS.Import("THREE", $"three");
            
            // Load OrbitControls
            using var orbitControlsModule = await JS.Import("OrbitControls");
            JS.Set("OrbitControls", orbitControlsModule!.GetExportClass("OrbitControls"));
            
            // Load GLTFLoader
            using var gltfLoaderModule = await JS.Import("GLTFLoader");
            JS.Set("GLTFLoader", gltfLoaderModule!.GetExportClass("GLTFLoader"));
            
            // Load DragControls
            using var dragControlsModule = await JS.Import("DragControls");
            JS.Set("DragControls", dragControlsModule!.GetExportClass("DragControls"));
            
            // Load FlyControls
            using var flyControlsModule = await JS.Import("FlyControls");
            JS.Set("FlyControls", flyControlsModule!.GetExportClass("FlyControls"));
            
            // Load Stats (uses default export)
            using var statsModule = await JS.Import("Stats");
            JS.Set("Stats", statsModule!.JSRef!.Get<Function>("default"));
        }
    }
}
