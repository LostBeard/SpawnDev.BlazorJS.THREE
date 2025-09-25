
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LightsNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public LightsNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public LightsNode() : base(JS.New("THREE.LightsNode")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get hasLights(): boolean;
        /// </summary>
        public bool HasLights { get => JSRef!.Get<bool>("hasLights"); }
        /// <summary>
        /// outgoingLightNode: Node;
        /// </summary>
        public Node OutgoingLightNode { get => JSRef!.Get<Node>("outgoingLightNode"); set => JSRef!.Set("outgoingLightNode", value); }
        /// <summary>
        /// totalDiffuseNode: Node;
        /// </summary>
        public Node TotalDiffuseNode { get => JSRef!.Get<Node>("totalDiffuseNode"); set => JSRef!.Set("totalDiffuseNode", value); }
        /// <summary>
        /// totalSpecularNode: Node;
        /// </summary>
        public Node TotalSpecularNode { get => JSRef!.Get<Node>("totalSpecularNode"); set => JSRef!.Set("totalSpecularNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setupLightsNode(builder: NodeBuilder): void;
        /// </summary>
        public void SetupLightsNode(NodeBuilder builder)
        {
            JSRef!.CallVoid("setupLightsNode", builder);
        }
        /// <summary>
        /// setupLights(builder: NodeBuilder, lightNodes: LightingNode[]): void;
        /// </summary>
        public void SetupLights(NodeBuilder builder, Array<LightingNode> lightNodes)
        {
            JSRef!.CallVoid("setupLights", builder, lightNodes);
        }
        /// <summary>
        /// setupDirectRectAreaLight(builder: NodeBuilder, lightNode: Node, lightData: DirectRectAreaLightData): void;
        /// </summary>
        public void SetupDirectRectAreaLight(NodeBuilder builder, Node lightNode, DirectRectAreaLightData lightData)
        {
            JSRef!.CallVoid("setupDirectRectAreaLight", builder, lightNode, lightData);
        }
        /// <summary>
        /// setupDirectLight(builder: NodeBuilder, lightNode: Node, lightData: DirectLightData): void;
        /// </summary>
        public void SetupDirectLight(NodeBuilder builder, Node lightNode, DirectLightData lightData)
        {
            JSRef!.CallVoid("setupDirectLight", builder, lightNode, lightData);
        }
        /// <summary>
        /// setLights(lights: Light[]): this;
        /// </summary>
        public LightsNode SetLights(Array<Light> lights)
        {
            return JSRef!.Call<LightsNode>("setLights", lights);
        }
        /// <summary>
        /// getLights(): Light[];
        /// </summary>
        public Array<Light> GetLights()
        {
            return JSRef!.Call<Array<Light>>("getLights");
        }
        /// <summary>
        /// getLightNodes(): LightingNode[];
        /// </summary>
        public Array<LightingNode> GetLightNodes()
        {
            return JSRef!.Call<Array<LightingNode>>("getLightNodes");
        }
        #endregion
    }
}
