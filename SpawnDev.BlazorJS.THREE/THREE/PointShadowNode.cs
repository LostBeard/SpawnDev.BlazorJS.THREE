
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PointShadowNode : ShadowNode
    {
        #region Constructors
        /// <inheritdoc/>
        public PointShadowNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light: Light, shadow: LightShadow | null);
        /// </summary>
        public PointShadowNode(Light light, LightShadow shadow) : base(JS.New("THREE.PointShadowNode", light, shadow)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
