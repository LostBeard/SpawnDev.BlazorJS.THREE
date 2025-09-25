
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SpotLightShadow : LightShadow
    {
        #region Constructors
        /// <inheritdoc/>
        public SpotLightShadow(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// aspect: number;
        /// </summary>
        public float Aspect { get => JSRef!.Get<float>("aspect"); set => JSRef!.Set("aspect", value); }
        /// <summary>
        /// camera: PerspectiveCamera;
        /// </summary>
        public PerspectiveCamera Camera { get => JSRef!.Get<PerspectiveCamera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// focus: number;
        /// </summary>
        public float Focus { get => JSRef!.Get<float>("focus"); set => JSRef!.Set("focus", value); }
        /// <summary>
        /// readonly isSpotLightShadow: true;
        /// </summary>
        public bool IsSpotLightShadow { get => JSRef!.Get<bool>("isSpotLightShadow"); }
        #endregion

        #region Methods

        #endregion
    }
}
