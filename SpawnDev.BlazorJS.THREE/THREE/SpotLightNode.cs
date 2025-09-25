
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SpotLightNode : AnalyticLightNode<SpotLight>
    {
        #region Constructors
        /// <inheritdoc/>
        public SpotLightNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light?: SpotLight | null);
        /// </summary>
        public SpotLightNode(SpotLight light) : base(JS.New("THREE.SpotLightNode", light)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// colorNode: Node;
        /// </summary>
        public Node ColorNode { get => JSRef!.Get<Node>("colorNode"); set => JSRef!.Set("colorNode", value); }
        /// <summary>
        /// coneCosNode: Node;
        /// </summary>
        public Node ConeCosNode { get => JSRef!.Get<Node>("coneCosNode"); set => JSRef!.Set("coneCosNode", value); }
        /// <summary>
        /// cutoffDistanceNode: Node;
        /// </summary>
        public Node CutoffDistanceNode { get => JSRef!.Get<Node>("cutoffDistanceNode"); set => JSRef!.Set("cutoffDistanceNode", value); }
        /// <summary>
        /// decayExponentNode: Node;
        /// </summary>
        public Node DecayExponentNode { get => JSRef!.Get<Node>("decayExponentNode"); set => JSRef!.Set("decayExponentNode", value); }
        /// <summary>
        /// directionNode: Node;
        /// </summary>
        public Node DirectionNode { get => JSRef!.Get<Node>("directionNode"); set => JSRef!.Set("directionNode", value); }
        /// <summary>
        /// penumbraCosNode: Node;
        /// </summary>
        public Node PenumbraCosNode { get => JSRef!.Get<Node>("penumbraCosNode"); set => JSRef!.Set("penumbraCosNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getLightCoord(builder: NodeBuilder): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> GetLightCoord(NodeBuilder builder)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("getLightCoord", builder);
        }
        #endregion
    }
}
