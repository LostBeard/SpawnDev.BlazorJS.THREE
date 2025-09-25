
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LoadingManager : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public LoadingManager(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         onLoad?: () => void,
        ///         onProgress?: (url: string, loaded: number, total: number) => void,
        ///         onError?: (url: string) => void,
        ///     );
        /// </summary>
        public LoadingManager(ActionCallback onLoad, ActionCallback<string, float, float> onProgress, ActionCallback<string> onError) : base(JS.New("THREE.LoadingManager", onLoad, onProgress, onError)) { }

        #endregion

        #region Properties
        /// <summary>
        /// abortController: AbortController;
        /// </summary>
        public AbortController AbortController { get => JSRef!.Get<AbortController>("abortController"); set => JSRef!.Set("abortController", value); }
        /// <summary>
        /// onError: (url: string) => void;
        /// </summary>
        public Callback OnError { get => JSRef!.Get<Callback>("onError"); set => JSRef!.Set("onError", value); }
        /// <summary>
        /// onLoad: () => void;
        /// </summary>
        public Callback OnLoad { get => JSRef!.Get<Callback>("onLoad"); set => JSRef!.Set("onLoad", value); }
        /// <summary>
        /// onProgress: (url: string, loaded: number, total: number) => void;
        /// </summary>
        public Callback OnProgress { get => JSRef!.Get<Callback>("onProgress"); set => JSRef!.Set("onProgress", value); }
        /// <summary>
        /// onStart: ((url: string, loaded: number, total: number) => void) | undefined;
        /// </summary>
        public Callback OnStart { get => JSRef!.Get<Callback>("onStart"); set => JSRef!.Set("onStart", value); }
        #endregion

        #region Methods
        /// <summary>
        /// (callback?: (url: string) => string) => this
        /// </summary>
        public LoadingManager SetURLModifier(Callback callback, string url)
        {
            return JSRef!.Call<LoadingManager>("setURLModifier", callback, url);
        }
        /// <summary>
        /// (url: string) => string
        /// </summary>
        public string ResolveURL(string url)
        {
            return JSRef!.Call<string>("resolveURL", url);
        }
        /// <summary>
        /// (regex: RegExp) => this
        /// </summary>
        public LoadingManager RemoveHandler(RegExp regex)
        {
            return JSRef!.Call<LoadingManager>("removeHandler", regex);
        }
        /// <summary>
        /// (url: string) => void
        /// </summary>
        public void ItemStart(string url)
        {
            JSRef!.CallVoid("itemStart", url);
        }
        /// <summary>
        /// (url: string) => void
        /// </summary>
        public void ItemError(string url)
        {
            JSRef!.CallVoid("itemError", url);
        }
        /// <summary>
        /// (url: string) => void
        /// </summary>
        public void ItemEnd(string url)
        {
            JSRef!.CallVoid("itemEnd", url);
        }
        /// <summary>
        /// (file: string) => Loader | null
        /// </summary>
        public Loader GetHandler(string file)
        {
            return JSRef!.Call<Loader>("getHandler", file);
        }
        /// <summary>
        /// (regex: RegExp, loader: Loader) => this
        /// </summary>
        public LoadingManager AddHandler(RegExp regex, Loader loader)
        {
            return JSRef!.Call<LoadingManager>("addHandler", regex, loader);
        }
        /// <summary>
        /// () => this
        /// </summary>
        public LoadingManager Abort()
        {
            return JSRef!.Call<LoadingManager>("abort");
        }
        #endregion
    }
}
