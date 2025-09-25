
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PointLightNode : AnalyticLightNode<PointLight>
    {
        #region Constructors
        /// <inheritdoc/>
        public PointLightNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light?: PointLight | null);
        /// </summary>
        public PointLightNode(PointLight light) : base(JS.New("THREE.PointLightNode", light)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// cutoffDistanceNode: Node;
        /// </summary>
        public Node CutoffDistanceNode { get => JSRef!.Get<Node>("cutoffDistanceNode"); set => JSRef!.Set("cutoffDistanceNode", value); }
        /// <summary>
        /// decayExponentNode: Node;
        /// </summary>
        public Node DecayExponentNode { get => JSRef!.Get<Node>("decayExponentNode"); set => JSRef!.Set("decayExponentNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setupShadowNode(): ShaderNodeObject<PointShadowNode>;
        /// </summary>
        public ShaderNodeObject<PointShadowNode> SetupShadowNode()
        {
            return JSRef!.Call<ShaderNodeObject<PointShadowNode>>("setupShadowNode");
        }
        #endregion
    }
}
