
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeBuilder : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeBuilder(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// buildStage: BuildStageOption | null;
        /// </summary>
        public BuildStageOption BuildStage { get => JSRef!.Get<BuildStageOption>("buildStage"); set => JSRef!.Set("buildStage", value); }
        /// <summary>
        /// cache: NodeCache;
        /// </summary>
        public NodeCache Cache { get => JSRef!.Get<NodeCache>("cache"); set => JSRef!.Set("cache", value); }
        /// <summary>
        /// computeShader: string;
        /// </summary>
        public string ComputeShader { get => JSRef!.Get<string>("computeShader"); set => JSRef!.Set("computeShader", value); }
        /// <summary>
        /// get currentNode(): Node;
        /// </summary>
        public Node CurrentNode { get => JSRef!.Get<Node>("currentNode"); }
        /// <summary>
        /// flowsData: any;
        /// </summary>
        public object FlowsData { get => JSRef!.Get<object>("flowsData"); set => JSRef!.Set("flowsData", value); }
        /// <summary>
        /// fogNode: Node;
        /// </summary>
        public Node FogNode { get => JSRef!.Get<Node>("fogNode"); set => JSRef!.Set("fogNode", value); }
        /// <summary>
        /// fragmentShader: string;
        /// </summary>
        public string FragmentShader { get => JSRef!.Get<string>("fragmentShader"); set => JSRef!.Set("fragmentShader", value); }
        /// <summary>
        /// geometry: BufferGeometry;
        /// </summary>
        public BufferGeometry Geometry { get => JSRef!.Get<BufferGeometry>("geometry"); set => JSRef!.Set("geometry", value); }
        /// <summary>
        /// globalCache: NodeCache;
        /// </summary>
        public NodeCache GlobalCache { get => JSRef!.Get<NodeCache>("globalCache"); set => JSRef!.Set("globalCache", value); }
        /// <summary>
        /// hashNodes: { [hash: string]: Node };
        /// </summary>
        public object HashNodes { get => JSRef!.Get<object>("hashNodes"); set => JSRef!.Set("hashNodes", value); }
        /// <summary>
        /// lightsNode: LightsNode;
        /// </summary>
        public LightsNode LightsNode { get => JSRef!.Get<LightsNode>("lightsNode"); set => JSRef!.Set("lightsNode", value); }
        /// <summary>
        /// material: Material;
        /// </summary>
        public Material Material { get => JSRef!.Get<Material>("material"); set => JSRef!.Set("material", value); }
        /// <summary>
        /// nodes: Node[];
        /// </summary>
        public Array<Node> Nodes { get => JSRef!.Get<Array<Node>>("nodes"); set => JSRef!.Set("nodes", value); }
        /// <summary>
        /// object: Object3D;
        /// </summary>
        public Object3D Object { get => JSRef!.Get<Object3D>("object"); set => JSRef!.Set("object", value); }
        /// <summary>
        /// parser: NodeParser;
        /// </summary>
        public NodeParser Parser { get => JSRef!.Get<NodeParser>("parser"); set => JSRef!.Set("parser", value); }
        /// <summary>
        /// renderer: Renderer;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        /// <summary>
        /// shaderStage: NodeShaderStage | null;
        /// </summary>
        public NodeShaderStage ShaderStage { get => JSRef!.Get<NodeShaderStage>("shaderStage"); set => JSRef!.Set("shaderStage", value); }
        /// <summary>
        /// stack: StackNode;
        /// </summary>
        public StackNode Stack { get => JSRef!.Get<StackNode>("stack"); set => JSRef!.Set("stack", value); }
        /// <summary>
        /// updateNodes: Node[];
        /// </summary>
        public Array<Node> UpdateNodes { get => JSRef!.Get<Array<Node>>("updateNodes"); set => JSRef!.Set("updateNodes", value); }
        /// <summary>
        /// vertexShader: string;
        /// </summary>
        public string VertexShader { get => JSRef!.Get<string>("vertexShader"); set => JSRef!.Set("vertexShader", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setShaderStage(shaderStage: NodeShaderStage): void;
        /// </summary>
        public void SetShaderStage(NodeShaderStage shaderStage)
        {
            JSRef!.CallVoid("setShaderStage", shaderStage);
        }
        /// <summary>
        /// setHashNode(node: Node, hash: string): void;
        /// </summary>
        public void SetHashNode(Node node, string hash)
        {
            JSRef!.CallVoid("setHashNode", node, hash);
        }
        /// <summary>
        /// setContext(context: NodeBuilderContext): void;
        /// </summary>
        public void SetContext(NodeBuilderContext context)
        {
            JSRef!.CallVoid("setContext", context);
        }
        /// <summary>
        /// setCache(cache: NodeCache): void;
        /// </summary>
        public void SetCache(NodeCache cache)
        {
            JSRef!.CallVoid("setCache", cache);
        }
        /// <summary>
        /// setBuildStage(buildStage: BuildStageOption): void;
        /// </summary>
        public void SetBuildStage(BuildStageOption buildStage)
        {
            JSRef!.CallVoid("setBuildStage", buildStage);
        }
        /// <summary>
        /// isVector(type: string): boolean;
        /// </summary>
        public bool IsVector(string type)
        {
            return JSRef!.Call<bool>("isVector", type);
        }
        /// <summary>
        /// isReference(type: string): boolean;
        /// </summary>
        public bool IsReference(string type)
        {
            return JSRef!.Call<bool>("isReference", type);
        }
        /// <summary>
        /// isMatrix(type: string): boolean;
        /// </summary>
        public bool IsMatrix(string type)
        {
            return JSRef!.Call<bool>("isMatrix", type);
        }
        /// <summary>
        /// isFlipY(): boolean;
        /// </summary>
        public bool IsFlipY()
        {
            return JSRef!.Call<bool>("isFlipY");
        }
        /// <summary>
        /// isFilteredTexture(texture: Texture): boolean;
        /// </summary>
        public bool IsFilteredTexture(Texture texture)
        {
            return JSRef!.Call<bool>("isFilteredTexture", texture);
        }
        /// <summary>
        /// isAvailable(name: string): boolean;
        /// </summary>
        public bool IsAvailable(string name)
        {
            return JSRef!.Call<bool>("isAvailable", name);
        }
        /// <summary>
        /// hasGeometryAttribute(name: string): boolean;
        /// </summary>
        public bool HasGeometryAttribute(string name)
        {
            return JSRef!.Call<bool>("hasGeometryAttribute", name);
        }
        /// <summary>
        /// getVectorType(type: string): string;
        /// </summary>
        public string GetVectorType(string type)
        {
            return JSRef!.Call<string>("getVectorType", type);
        }
        /// <summary>
        /// getVectorFromMatrix(type: string): string;
        /// </summary>
        public string GetVectorFromMatrix(string type)
        {
            return JSRef!.Call<string>("getVectorFromMatrix", type);
        }
        /// <summary>
        /// abstract getVaryings(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetVaryings(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getVaryings", shaderStage);
        }
        /// <summary>
        /// getVaryFromNode(node: Node, type: string): NodeVarying;
        /// </summary>
        public NodeVarying GetVaryFromNode(Node node, string type)
        {
            return JSRef!.Call<NodeVarying>("getVaryFromNode", node, type);
        }
        /// <summary>
        /// getVars(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetVars(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getVars", shaderStage);
        }
        /// <summary>
        /// getVarFromNode(node: Node, type: string, shaderStage?: NodeShaderStage): NodeVar;
        /// </summary>
        public NodeVar GetVarFromNode(Node node, string type, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<NodeVar>("getVarFromNode", node, type, shaderStage);
        }
        /// <summary>
        /// abstract getUniforms(stage: NodeShaderStage): string;
        /// </summary>
        public string GetUniforms(NodeShaderStage stage)
        {
            return JSRef!.Call<string>("getUniforms", stage);
        }
        /// <summary>
        /// getUniformFromNode(
        ///         node: Node,
        ///         type: string,
        ///         shaderStage?: NodeShaderStage,
        ///         name?: string | null,
        ///     ): NodeUniform<string>;
        /// </summary>
        public NodeUniform<string> GetUniformFromNode(Node node, string type, NodeShaderStage shaderStage, string name)
        {
            return JSRef!.Call<NodeUniform<string>>("getUniformFromNode", node, type, shaderStage, name);
        }
        /// <summary>
        /// getTypeLength(type: string): number;
        /// </summary>
        public float GetTypeLength(string type)
        {
            return JSRef!.Call<float>("getTypeLength", type);
        }
        /// <summary>
        /// getTypeFromLength(length: number): string;
        /// </summary>
        public string GetTypeFromLength(float length)
        {
            return JSRef!.Call<string>("getTypeFromLength", length);
        }
        /// <summary>
        /// getType(type: string): string;
        /// </summary>
        public string GetType(string type)
        {
            return JSRef!.Call<string>("getType", type);
        }
        /// <summary>
        /// getSignature(): string;
        /// </summary>
        public string GetSignature()
        {
            return JSRef!.Call<string>("getSignature");
        }
        /// <summary>
        /// getShaderStage(): NodeShaderStage;
        /// </summary>
        public NodeShaderStage GetShaderStage()
        {
            return JSRef!.Call<NodeShaderStage>("getShaderStage");
        }
        /// <summary>
        /// getPropertyName<TValue>(node: NodeVar | NodeUniform<TValue>, shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetPropertyName<TValue>(Union<NodeVar, NodeUniform<TValue>> node, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getPropertyName", node, shaderStage);
        }
        /// <summary>
        /// getNodeProperties(node: Node, shaderStage?: NodeShaderStage): { [key: string]: object };
        /// </summary>
        public object GetNodeProperties(Node node, NodeShaderStage shaderStage, string key)
        {
            return JSRef!.Call<object>("getNodeProperties", node, shaderStage, key);
        }
        /// <summary>
        /// getNodeFromHash(hash: string): Node;
        /// </summary>
        public Node GetNodeFromHash(string hash)
        {
            return JSRef!.Call<Node>("getNodeFromHash", hash);
        }
        /// <summary>
        /// getMethod(method: string): string;
        /// </summary>
        public string GetMethod(string method)
        {
            return JSRef!.Call<string>("getMethod", method);
        }
        /// <summary>
        /// abstract getInstanceIndex(): string;
        /// </summary>
        public string GetInstanceIndex()
        {
            return JSRef!.Call<string>("getInstanceIndex");
        }
        /// <summary>
        /// getHash(): string;
        /// </summary>
        public string GetHash()
        {
            return JSRef!.Call<string>("getHash");
        }
        /// <summary>
        /// abstract getFrontFacing(): string;
        /// </summary>
        public string GetFrontFacing()
        {
            return JSRef!.Call<string>("getFrontFacing");
        }
        /// <summary>
        /// abstract getFragCoord(): string;
        /// </summary>
        public string GetFragCoord()
        {
            return JSRef!.Call<string>("getFragCoord");
        }
        /// <summary>
        /// getFlowData(node: Node, shaderStage: NodeShaderStage): FlowData;
        /// </summary>
        public FlowData GetFlowData(Node node, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<FlowData>("getFlowData", node, shaderStage);
        }
        /// <summary>
        /// getElementType(type: string): string | null;
        /// </summary>
        public string GetElementType(string type)
        {
            return JSRef!.Call<string>("getElementType", type);
        }
        /// <summary>
        /// abstract getDrawIndex(): string | null;
        /// </summary>
        public string GetDrawIndex()
        {
            return JSRef!.Call<string>("getDrawIndex");
        }
        /// <summary>
        /// getDataFromNode(node: Node, shaderStage?: NodeShaderStage): NodeData;
        /// </summary>
        public NodeData GetDataFromNode(Node node, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<NodeData>("getDataFromNode", node, shaderStage);
        }
        /// <summary>
        /// getContext(): NodeBuilderContext;
        /// </summary>
        public NodeBuilderContext GetContext()
        {
            return JSRef!.Call<NodeBuilderContext>("getContext");
        }
        /// <summary>
        /// getConst(type: string, value?: object): Node;
        /// </summary>
        public Node GetConst(string type, object value)
        {
            return JSRef!.Call<Node>("getConst", type, value);
        }
        /// <summary>
        /// getComponentType(type: string): string | null;
        /// </summary>
        public string GetComponentType(string type)
        {
            return JSRef!.Call<string>("getComponentType", type);
        }
        /// <summary>
        /// getCodes(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetCodes(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getCodes", shaderStage);
        }
        /// <summary>
        /// getCodeFromNode(node: Node, type: string, shaderStage?: NodeShaderStage): string;
        /// </summary>
        public string GetCodeFromNode(Node node, string type, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getCodeFromNode", node, type, shaderStage);
        }
        /// <summary>
        /// getCacheFromNode(node: Node, parent?: boolean): NodeCache;
        /// </summary>
        public NodeCache GetCacheFromNode(Node node, bool parent)
        {
            return JSRef!.Call<NodeCache>("getCacheFromNode", node, parent);
        }
        /// <summary>
        /// getCache(): NodeCache;
        /// </summary>
        public NodeCache GetCache()
        {
            return JSRef!.Call<NodeCache>("getCache");
        }
        /// <summary>
        /// getBuildStage(): BuildStageOption;
        /// </summary>
        public BuildStageOption GetBuildStage()
        {
            return JSRef!.Call<BuildStageOption>("getBuildStage");
        }
        /// <summary>
        /// abstract getAttributes(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetAttributes(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getAttributes", shaderStage);
        }
        /// <summary>
        /// getAttribute(name: string, type: string): NodeAttribute;
        /// </summary>
        public NodeAttribute GetAttribute(string name, string type)
        {
            return JSRef!.Call<NodeAttribute>("getAttribute", name, type);
        }
        /// <summary>
        /// generateMethod(method: string): string;
        /// </summary>
        public string GenerateMethod(string method)
        {
            return JSRef!.Call<string>("generateMethod", method);
        }
        /// <summary>
        /// format(snippet: string, fromType: string, toType: string): string;
        /// </summary>
        public string Format(string snippet, string fromType, string toType)
        {
            return JSRef!.Call<string>("format", snippet, fromType, toType);
        }
        /// <summary>
        /// flowNodeFromShaderStage(
        ///         shaderStage: NodeShaderStage,
        ///         node: Node,
        ///         output?: string | null,
        ///         propertyName?: string,
        ///     ): FlowData;
        /// </summary>
        public FlowData FlowNodeFromShaderStage(NodeShaderStage shaderStage, Node node, string output, string propertyName)
        {
            return JSRef!.Call<FlowData>("flowNodeFromShaderStage", shaderStage, node, output, propertyName);
        }
        /// <summary>
        /// flowNode(node: Node): FlowData;
        /// </summary>
        public FlowData FlowNode(Node node)
        {
            return JSRef!.Call<FlowData>("flowNode", node);
        }
        /// <summary>
        /// flowChildNode(node: Node, output?: string | null): FlowData;
        /// </summary>
        public FlowData FlowChildNode(Node node, string output)
        {
            return JSRef!.Call<FlowData>("flowChildNode", node, output);
        }
        /// <summary>
        /// abstract buildCode(): void;
        /// </summary>
        public void BuildCode()
        {
            JSRef!.CallVoid("buildCode");
        }
        /// <summary>
        /// build(): this;
        /// </summary>
        public NodeBuilder Build()
        {
            return JSRef!.Call<NodeBuilder>("build");
        }
        /// <summary>
        /// addNode(node: Node): void;
        /// </summary>
        public void AddNode(Node node)
        {
            JSRef!.CallVoid("addNode", node);
        }
        /// <summary>
        /// addFlowCode(code: string): void;
        /// </summary>
        public void AddFlowCode(string code)
        {
            JSRef!.CallVoid("addFlowCode", code);
        }
        /// <summary>
        /// addFlow(shaderStage: NodeShaderStage, node: Node): Node;
        /// </summary>
        public Node AddFlow(NodeShaderStage shaderStage, Node node)
        {
            return JSRef!.Call<Node>("addFlow", shaderStage, node);
        }
        #endregion
    }
}
