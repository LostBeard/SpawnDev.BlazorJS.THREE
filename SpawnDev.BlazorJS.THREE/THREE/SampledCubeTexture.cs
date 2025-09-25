
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SampledCubeTexture : SampledTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public SampledCubeTexture(IJSInProcessObjectReference _ref) : base(_ref) { }

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
