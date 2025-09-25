
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TextureLoader : Loader<Texture>
    {
        #region Constructors
        /// <inheritdoc/>
        public TextureLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public TextureLoader(LoadingManager manager) : base(JS.New("THREE.TextureLoader", manager)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// load(
        ///         url: string,
        ///         onLoad?: (data: Texture) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): Texture;
        /// </summary>
        public Texture Load(string url, ActionCallback<Texture> onLoad, ActionCallback<ProgressEvent> onProgress, Callback onError)
        {
            return JSRef!.Call<Texture>("load", url, onLoad, onProgress, onError);
        }
        #endregion
    }
}
