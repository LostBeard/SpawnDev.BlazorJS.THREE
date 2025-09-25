
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Sampled3DTexture : SampledTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public Sampled3DTexture(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isSampled3DTexture: true;
        /// </summary>
        public bool IsSampled3DTexture { get => JSRef!.Get<bool>("isSampled3DTexture"); }
        #endregion

        #region Methods

        #endregion
    }
}
