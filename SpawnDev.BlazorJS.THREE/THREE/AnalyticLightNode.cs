
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AnalyticLightNode<TLight> : AnalyticLightNode
    {
        /// <inheritdoc/>
        public AnalyticLightNode(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class AnalyticLightNode : LightingNode
    {
        #region Constructors
        /// <inheritdoc/>
        public AnalyticLightNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light?: T | null);
        /// </summary>
        public AnalyticLightNode(Light light) : base(JS.New("THREE.AnalyticLightNode", light)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// light: T | null;
        /// </summary>
        public Light? Light { get => JSRef!.Get<Light?>("light"); set => JSRef!.Set("light", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setupShadowNode(): ShaderNodeObject<ShadowNode>;
        /// </summary>
        public JSObject SetupShadowNode()
        {
            return JSRef!.Call<JSObject>("setupShadowNode");
        }
        /// <summary>
        /// setupShadow(builder: NodeBuilder): void;
        /// </summary>
        public void SetupShadow(NodeBuilder builder)
        {
            JSRef!.CallVoid("setupShadow", builder);
        }
        /// <summary>
        /// setupDirectRectArea(builder: NodeBuilder): DirectRectAreaLightData | undefined;
        /// </summary>
        public DirectRectAreaLightData SetupDirectRectArea(NodeBuilder builder)
        {
            return JSRef!.Call<DirectRectAreaLightData>("setupDirectRectArea", builder);
        }
        /// <summary>
        /// setupDirect(builder: NodeBuilder): DirectLightData | undefined;
        /// </summary>
        public DirectLightData SetupDirect(NodeBuilder builder)
        {
            return JSRef!.Call<DirectLightData>("setupDirect", builder);
        }
        /// <summary>
        /// getLightVector(builder: NodeBuilder): Node;
        /// </summary>
        public Node GetLightVector(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("getLightVector", builder);
        }
        #endregion
    }
}
