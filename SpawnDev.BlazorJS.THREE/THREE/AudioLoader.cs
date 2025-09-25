
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AudioLoader : Loader<AudioBuffer>
    {
        #region Constructors
        /// <inheritdoc/>
        public AudioLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public AudioLoader(LoadingManager manager) : base(JS.New("THREE.AudioLoader", manager)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
