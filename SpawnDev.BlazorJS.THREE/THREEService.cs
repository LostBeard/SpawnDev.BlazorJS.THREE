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
            using var orbitControlsModule = await JS.Import("OrbitControls");
            JS.Set("OrbitControls", orbitControlsModule!.GetExportClass("OrbitControls"));
        }
    }
}
