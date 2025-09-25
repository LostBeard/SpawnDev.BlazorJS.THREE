
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ImageBitmapLoader : Loader<ImageBitmap>
    {
        #region Constructors
        /// <inheritdoc/>
        public ImageBitmapLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public ImageBitmapLoader(LoadingManager manager) : base(JS.New("THREE.ImageBitmapLoader", manager)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isImageBitmapLoader: true;
        /// </summary>
        public bool IsImageBitmapLoader { get => JSRef!.Get<bool>("isImageBitmapLoader"); }
        /// <summary>
        /// options: ImageBitmapOptions;
        /// </summary>
        public ImageBitmapOptions Options { get => JSRef!.Get<ImageBitmapOptions>("options"); set => JSRef!.Set("options", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setOptions(options: ImageBitmapOptions): this;
        /// </summary>
        public ImageBitmapLoader SetOptions(ImageBitmapOptions options)
        {
            return JSRef!.Call<ImageBitmapLoader>("setOptions", options);
        }
        /// <summary>
        /// load(
        ///         url: string,
        ///         onLoad?: (data: ImageBitmap) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): void;
        /// </summary>
        public void Load(string url, Callback onLoad, ImageBitmap data, Callback onProgress, ProgressEvent ev, Callback onError, object err)
        {
            JSRef!.CallVoid("load", url, onLoad, data, onProgress, ev, onError, err);
        }
        #endregion
    }
}
