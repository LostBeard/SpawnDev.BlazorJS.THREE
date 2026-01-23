using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeSampledCubeTexture : NodeSampledTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeSampledCubeTexture(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isSampledCubeTexture: true;
        /// </summary>
        public bool IsSampledCubeTexture { get => JSRef!.Get<bool>("isSampledCubeTexture"); }
        #endregion

        #region Methods

        #endregion
    }
}
