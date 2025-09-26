namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// Loads the THREE js library at app startup so it is ready for use for all components immediately
    /// </summary>
    /// <param name="JS"></param>
    public class THREEService(BlazorJSRuntime JS) : IAsyncBackgroundService
    {
        /// <inheritdoc/>
        public Task Ready => _Ready ??= JS.Import("THREE", $"./_content/{typeof(THREEService).Namespace!}/three.module.js");
        Task? _Ready;
    }
}
