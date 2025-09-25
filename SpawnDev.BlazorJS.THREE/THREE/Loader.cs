
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{   
    public class Loader<TData,TData2> : Loader<TData>
    {
        /// <inheritdoc/>
        public Loader(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class Loader<TData> : Loader
    {
        /// <inheritdoc/>
        public Loader(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// loadAsync(url: TUrl, onProgress?: (event: ProgressEvent) => void): Promise<TData>;
        /// </summary>
        public Task<TData> LoadAsync(string url, Callback onProgress, ProgressEvent ev)
        {
            return JSRef!.CallAsync<TData>("loadAsync", url, onProgress, ev);
        }
        /// <summary>
        /// load(
        ///         url: TUrl,
        ///         onLoad: (data: TData) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): void;
        /// </summary>
        public void Load(string url, ActionCallback<TData> onLoad, Callback onProgress, Callback onError)
        {
            JSRef!.CallVoid("load", url, onLoad, onProgress, onError);
        }
    }
    public class Loader : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Loader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public Loader(LoadingManager manager) : base(JS.New("THREE.Loader", manager)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// crossOrigin: string;
        /// </summary>
        public string CrossOrigin { get => JSRef!.Get<string>("crossOrigin"); set => JSRef!.Set("crossOrigin", value); }
        /// <summary>
        /// static DEFAULT_MATERIAL_NAME: string;
        /// </summary>
        public static string DEFAULT_MATERIAL_NAME { get => JS.Get<string>("THREE.Loader.DEFAULT_MATERIAL_NAME"); set => JS.Set("THREE.Loader.DEFAULT_MATERIAL_NAME", value); }
        /// <summary>
        /// manager: LoadingManager;
        /// </summary>
        public LoadingManager Manager { get => JSRef!.Get<LoadingManager>("manager"); set => JSRef!.Set("manager", value); }
        /// <summary>
        /// path: string;
        /// </summary>
        public string Path { get => JSRef!.Get<string>("path"); set => JSRef!.Set("path", value); }
        /// <summary>
        /// requestHeader: { [header: string]: string };
        /// </summary>
        public object RequestHeader { get => JSRef!.Get<object>("requestHeader"); set => JSRef!.Set("requestHeader", value); }
        /// <summary>
        /// resourcePath: string;
        /// </summary>
        public string ResourcePath { get => JSRef!.Get<string>("resourcePath"); set => JSRef!.Set("resourcePath", value); }
        /// <summary>
        /// withCredentials: boolean;
        /// </summary>
        public bool WithCredentials { get => JSRef!.Get<bool>("withCredentials"); set => JSRef!.Set("withCredentials", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setWithCredentials(value: boolean): this;
        /// </summary>
        public Loader SetWithCredentials(bool value)
        {
            return JSRef!.Call<Loader>("setWithCredentials", value);
        }
        /// <summary>
        /// setResourcePath(resourcePath: string): this;
        /// </summary>
        public Loader SetResourcePath(string resourcePath)
        {
            return JSRef!.Call<Loader>("setResourcePath", resourcePath);
        }
        /// <summary>
        /// setRequestHeader(requestHeader: { [header: string]: string }): this;
        /// </summary>
        public Loader SetRequestHeader(object requestHeader, string header)
        {
            return JSRef!.Call<Loader>("setRequestHeader", requestHeader, header);
        }
        /// <summary>
        /// setPath(path: string): this;
        /// </summary>
        public Loader SetPath(string path)
        {
            return JSRef!.Call<Loader>("setPath", path);
        }
        /// <summary>
        /// setCrossOrigin(crossOrigin: string): this;
        /// </summary>
        public Loader SetCrossOrigin(string crossOrigin)
        {
            return JSRef!.Call<Loader>("setCrossOrigin", crossOrigin);
        }
        /// <summary>
        /// loadAsync(url: TUrl, onProgress?: (event: ProgressEvent) => void): Promise<TData>;
        /// </summary>
        public Task<TData> LoadAsync<TData>(string url, Callback onProgress, ProgressEvent ev)
        {
            return JSRef!.CallAsync<TData>("loadAsync", url, onProgress, ev);
        }
        /// <summary>
        /// load(
        ///         url: TUrl,
        ///         onLoad: (data: TData) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): void;
        /// </summary>
        public void Load<TData>(string url, ActionCallback<TData> onLoad, Callback onProgress, Callback onError)
        {
            JSRef!.CallVoid("load", url, onLoad, onProgress, onError);
        }
        /// <summary>
        /// abort(): this;
        /// </summary>
        public Loader Abort()
        {
            return JSRef!.Call<Loader>("abort");
        }
        #endregion
    }
}
