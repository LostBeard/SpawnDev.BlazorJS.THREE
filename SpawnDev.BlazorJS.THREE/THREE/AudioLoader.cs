using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// Class for loading an AudioBuffer.<br/>
    /// https://threejs.org/docs/index.html#api/en/loaders/AudioLoader
    /// </summary>
    public class AudioLoader : Loader<AudioBuffer>
    {
        #region Constructors
        /// <inheritdoc/>
        public AudioLoader(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Create a new AudioLoader.
        /// </summary>
        /// <param name="manager">The loadingManager for the loader to use. Default is THREE.DefaultLoadingManager.</param>
        public AudioLoader(LoadingManager? manager = null) : base(manager == null ? JS.New("THREE.AudioLoader") : JS.New("THREE.AudioLoader", manager)) { }

        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
