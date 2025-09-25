
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DirectionalLightNode : AnalyticLightNode
    {
        #region Constructors
        /// <inheritdoc/>
        public DirectionalLightNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light?: DirectionalLight | null);
        /// </summary>
        public DirectionalLightNode(DirectionalLight light) : base(JS.New("THREE.DirectionalLightNode", light)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
