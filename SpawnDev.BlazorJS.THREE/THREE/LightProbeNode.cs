
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LightProbeNode : AnalyticLightNode<LightProbe>
    {
        #region Constructors
        /// <inheritdoc/>
        public LightProbeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light?: LightProbe | null);
        /// </summary>
        public LightProbeNode(LightProbe light) : base(JS.New("THREE.LightProbeNode", light)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// lightProbe: UniformArrayNode;
        /// </summary>
        public UniformArrayNode LightProbe { get => JSRef!.Get<UniformArrayNode>("lightProbe"); set => JSRef!.Set("lightProbe", value); }
        #endregion

        #region Methods

        #endregion
    }
}
