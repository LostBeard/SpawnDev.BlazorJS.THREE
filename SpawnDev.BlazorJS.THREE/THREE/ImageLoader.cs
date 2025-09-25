
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ImageLoader : Loader<HTMLImageElement>
    {
        #region Constructors
        /// <inheritdoc/>
        public ImageLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public ImageLoader(LoadingManager manager) : base(JS.New("THREE.ImageLoader", manager)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// load(
        ///         url: string,
        ///         onLoad?: (data: HTMLImageElement) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): HTMLImageElement;
        /// </summary>
        public HTMLImageElement Load(string url, Callback onLoad, HTMLImageElement data, Callback onProgress, ProgressEvent ev, Callback onError, object err)
        {
            return JSRef!.Call<HTMLImageElement>("load", url, onLoad, data, onProgress, ev, onError, err);
        }
        #endregion
    }
}
