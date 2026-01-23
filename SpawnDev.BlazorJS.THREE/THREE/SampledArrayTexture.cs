using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.THREE
{
    public class SampledArrayTexture : SampledTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public SampledArrayTexture(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isSampledArrayTexture: true;
        /// </summary>
        public bool IsSampledArrayTexture { get => JSRef!.Get<bool>("isSampledArrayTexture"); }
        #endregion

        #region Methods

        #endregion
    }
}
