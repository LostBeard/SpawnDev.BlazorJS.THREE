
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PointLightShadow : LightShadow<PerspectiveCamera>
    {
        #region Constructors
        /// <inheritdoc/>
        public PointLightShadow(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isPointLightShadow = true;
        /// </summary>
        public bool IsPointLightShadow { get => JSRef!.Get<bool>("isPointLightShadow"); }
        #endregion

        #region Methods
        /// <summary>
        /// override updateMatrices(light: Light, viewportIndex?: number): void;
        /// </summary>
        public void UpdateMatrices(Light light, float viewportIndex)
        {
            JSRef!.CallVoid("updateMatrices", light, viewportIndex);
        }
        #endregion
    }
}
