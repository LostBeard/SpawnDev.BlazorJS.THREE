
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isNodeMaterial: boolean;
        /// </summary>
        public bool IsNodeMaterial { get => JSRef!.Get<bool>("isNodeMaterial"); }
        /// <summary>
        /// static get type(): string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: NodeMaterialParameters): void;
        /// </summary>
        public void SetValues(NodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupVertex(builder: NodeBuilder): Node;
        /// </summary>
        public Node SetupVertex(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("setupVertex", builder);
        }
        /// <summary>
        /// setupVariants(builder: NodeBuilder): void;
        /// </summary>
        public void SetupVariants(NodeBuilder builder)
        {
            JSRef!.CallVoid("setupVariants", builder);
        }
        /// <summary>
        /// setupPremultipliedAlpha(builder: NodeBuilder, outputNode: Node): Node;
        /// </summary>
        public Node SetupPremultipliedAlpha(NodeBuilder builder, Node outputNode)
        {
            return JSRef!.Call<Node>("setupPremultipliedAlpha", builder, outputNode);
        }
        /// <summary>
        /// setupPositionView(builder: NodeBuilder): Node;
        /// </summary>
        public Node SetupPositionView(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("setupPositionView", builder);
        }
        /// <summary>
        /// setupPosition(builder: NodeBuilder): Node;
        /// </summary>
        public Node SetupPosition(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("setupPosition", builder);
        }
        /// <summary>
        /// setupOutput(builder: NodeBuilder, outputNode: Node): Node;
        /// </summary>
        public Node SetupOutput(NodeBuilder builder, Node outputNode)
        {
            return JSRef!.Call<Node>("setupOutput", builder, outputNode);
        }
        /// <summary>
        /// setupOutgoingLight(): Node;
        /// </summary>
        public Node SetupOutgoingLight()
        {
            return JSRef!.Call<Node>("setupOutgoingLight");
        }
        /// <summary>
        /// setupObserver(builder: NodeBuilder): NodeMaterialObserver;
        /// </summary>
        public NodeMaterialObserver SetupObserver(NodeBuilder builder)
        {
            return JSRef!.Call<NodeMaterialObserver>("setupObserver", builder);
        }
        /// <summary>
        /// setupNormal(): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> SetupNormal()
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("setupNormal");
        }
        /// <summary>
        /// setupModelViewProjection(): Node;
        /// </summary>
        public Node SetupModelViewProjection()
        {
            return JSRef!.Call<Node>("setupModelViewProjection");
        }
        /// <summary>
        /// setupLights(builder: NodeBuilder): LightsNode;
        /// </summary>
        public LightsNode SetupLights(NodeBuilder builder)
        {
            return JSRef!.Call<LightsNode>("setupLights", builder);
        }
        /// <summary>
        /// setupLightMap(builder: NodeBuilder): Node;
        /// </summary>
        public Node SetupLightMap(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("setupLightMap", builder);
        }
        /// <summary>
        /// setupLightingModel(): LightingModel;
        /// </summary>
        public LightingModel SetupLightingModel()
        {
            return JSRef!.Call<LightingModel>("setupLightingModel");
        }
        /// <summary>
        /// setupLighting(builder: NodeBuilder): Node;
        /// </summary>
        public Node SetupLighting(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("setupLighting", builder);
        }
        /// <summary>
        /// setupHardwareClipping(builder: NodeBuilder): void;
        /// </summary>
        public void SetupHardwareClipping(NodeBuilder builder)
        {
            JSRef!.CallVoid("setupHardwareClipping", builder);
        }
        /// <summary>
        /// setupFog(builder: NodeBuilder, outputNode: Node): Node;
        /// </summary>
        public Node SetupFog(NodeBuilder builder, Node outputNode)
        {
            return JSRef!.Call<Node>("setupFog", builder, outputNode);
        }
        /// <summary>
        /// setupEnvironment(builder: NodeBuilder): Node | null;
        /// </summary>
        public Node SetupEnvironment(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("setupEnvironment", builder);
        }
        /// <summary>
        /// setupDiffuseColor(builder: NodeBuilder): void;
        /// </summary>
        public void SetupDiffuseColor(NodeBuilder builder)
        {
            JSRef!.CallVoid("setupDiffuseColor", builder);
        }
        /// <summary>
        /// setupDepth(builder: NodeBuilder): void;
        /// </summary>
        public void SetupDepth(NodeBuilder builder)
        {
            JSRef!.CallVoid("setupDepth", builder);
        }
        /// <summary>
        /// setupClipping(builder: NodeBuilder): ClippingNode;
        /// </summary>
        public ClippingNode SetupClipping(NodeBuilder builder)
        {
            return JSRef!.Call<ClippingNode>("setupClipping", builder);
        }
        /// <summary>
        /// setup(builder: NodeBuilder): void;
        /// </summary>
        public void Setup(NodeBuilder builder)
        {
            JSRef!.CallVoid("setup", builder);
        }
        /// <summary>
        /// setDefaultValues(material: Material): void;
        /// </summary>
        public void SetDefaultValues(Material material)
        {
            JSRef!.CallVoid("setDefaultValues", material);
        }
        /// <summary>
        /// copy(source: NodeMaterial): this;
        /// </summary>
        public NodeMaterial Copy(NodeMaterial source)
        {
            return JSRef!.Call<NodeMaterial>("copy", source);
        }
        /// <summary>
        /// build(builder: NodeBuilder): void;
        /// </summary>
        public void Build(NodeBuilder builder)
        {
            JSRef!.CallVoid("build", builder);
        }
        #endregion
    }
}
