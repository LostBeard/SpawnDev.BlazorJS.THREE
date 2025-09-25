
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShadowNode : ShadowBaseNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ShadowNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light: Light, shadow: LightShadow | null);
        /// </summary>
        public ShadowNode(Light light, LightShadow shadow) : base(JS.New("THREE.ShadowNode", light, shadow)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
