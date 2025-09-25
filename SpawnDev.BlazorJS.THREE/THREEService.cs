using SpawnDev.BlazorJS;

namespace SpawnDev.BlazorJS.THREE
{
    public class THREEService : IAsyncBackgroundService
    {
        static string Namespace => typeof(THREEService).Namespace!;
        public static string LatestBundledVersionSrc { get; } = $"./_content/{Namespace}/three.module.js";
        public Task Ready => _Ready ??= InitAsync();
        Task? _Ready;
        BlazorJSRuntime JS;
        public THREEService(BlazorJSRuntime js)
        {
            JS = js;
        }
        async Task InitAsync()
        {
            if  (JS.IsUndefined("THREE"))
            {
                using var three = await JS.Import(LatestBundledVersionSrc);
                JS.Set("THREE", three);
            }
        }
    }
}
