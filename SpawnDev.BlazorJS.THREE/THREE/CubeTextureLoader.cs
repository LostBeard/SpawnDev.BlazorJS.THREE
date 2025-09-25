
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CubeTextureLoader : Loader<CubeTexture>
    {
        #region Constructors
        /// <inheritdoc/>
        public CubeTextureLoader(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public CubeTextureLoader(LoadingManager manager) : base(JS.New("THREE.CubeTextureLoader", manager)) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// load(
        ///         url: readonlystring[],
        ///         onLoad?: (data: CubeTexture) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): CubeTexture;
        /// </summary>
        public CubeTexture Load(string[] url, ActionCallback<CubeTexture> onLoad, ActionCallback<ProgressEvent> onProgress, Callback onError)
        {
            return JSRef!.Call<CubeTexture>("load", url, onLoad, onProgress, onError);
        }
        #endregion
    }
}
