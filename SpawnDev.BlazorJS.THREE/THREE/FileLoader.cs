
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class FileLoader : Loader<Union<string, ArrayBuffer>>
    {
        #region Constructors
        /// <inheritdoc/>
        public FileLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public FileLoader(LoadingManager manager) : base(JS.New("THREE.FileLoader", manager)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// mimeType: string;
        /// </summary>
        public string MimeType { get => JSRef!.Get<string>("mimeType"); set => JSRef!.Set("mimeType", value); }
        /// <summary>
        /// responseType: string;
        /// </summary>
        public string ResponseType { get => JSRef!.Get<string>("responseType"); set => JSRef!.Set("responseType", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setResponseType(value: string): this;
        /// </summary>
        public FileLoader SetResponseType(string value)
        {
            return JSRef!.Call<FileLoader>("setResponseType", value);
        }
        /// <summary>
        /// setMimeType(value: string): this;
        /// </summary>
        public FileLoader SetMimeType(string value)
        {
            return JSRef!.Call<FileLoader>("setMimeType", value);
        }
        /// <summary>
        /// load(
        ///         url: string,
        ///         onLoad?: (data: string | ArrayBuffer) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): void;
        /// </summary>
        public void Load(string url, ActionCallback<JSObject> onLoad, ActionCallback<ProgressEvent> onProgress, Callback onError)
        {
            JSRef!.CallVoid("load", url, onLoad, onProgress, onError);
        }
        #endregion
    }
}
