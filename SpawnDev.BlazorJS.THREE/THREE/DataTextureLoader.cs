
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DataTextureLoader : Loader<DataTexture>
    {
        #region Constructors
        /// <inheritdoc/>
        public DataTextureLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public DataTextureLoader(LoadingManager manager) : base(JS.New("THREE.DataTextureLoader", manager)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// load(
        ///         url: string,
        ///         onLoad?: (data: DataTexture, texData: object) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): DataTexture;
        /// </summary>
        public DataTexture Load(string url, Callback onLoad, DataTexture data, object texData, Callback onProgress, ProgressEvent ev, Callback onError, object err)
        {
            return JSRef!.Call<DataTexture>("load", url, onLoad, data, texData, onProgress, ev, onError, err);
        }
        #endregion
    }
}
