
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AmbientLightNode : AnalyticLightNode<AmbientLight>
    {
        #region Constructors
        /// <inheritdoc/>
        public AmbientLightNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light?: AmbientLight | null);
        /// </summary>
        public AmbientLightNode(AmbientLight light) : base(JS.New("THREE.AmbientLightNode", light)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
