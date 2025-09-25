
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CompressedTextureLoader : Loader<CompressedTexture>
    {
        #region Constructors
        /// <inheritdoc/>
        public CompressedTextureLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public CompressedTextureLoader(LoadingManager manager) : base(JS.New("THREE.CompressedTextureLoader", manager)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// load(
        ///         url: string,
        ///         onLoad?: (data: CompressedTexture) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): CompressedTexture;
        /// </summary>
        public CompressedTexture Load(string url, Callback onLoad, CompressedTexture data, Callback onProgress, ProgressEvent ev, Callback onError, object err)
        {
            return JSRef!.Call<CompressedTexture>("load", url, onLoad, data, onProgress, ev, onError, err);
        }
        #endregion
    }
}
