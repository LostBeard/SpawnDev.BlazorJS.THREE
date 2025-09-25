
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Node : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public Node(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeType?: string | null);
        /// </summary>
        public Node(string nodeType) : base(JS.New("THREE.Node", nodeType)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// global: boolean;
        /// </summary>
        public bool Global { get => JSRef!.Get<bool>("global"); set => JSRef!.Set("global", value); }
        /// <summary>
        /// readonly id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); }
        /// <summary>
        /// readonly isNode: true;
        /// </summary>
        public bool IsNode { get => JSRef!.Get<bool>("isNode"); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// NodeChild
        /// </summary>
        public NodeChild NodeChild { get => JSRef!.Get<NodeChild>("NodeChild"); set => JSRef!.Set("NodeChild", value); }
        /// <summary>
        /// nodeType: string | null;
        /// </summary>
        public string NodeType { get => JSRef!.Get<string>("nodeType"); set => JSRef!.Set("nodeType", value); }
        /// <summary>
        /// parents: boolean;
        /// </summary>
        public bool Parents { get => JSRef!.Get<bool>("parents"); set => JSRef!.Set("parents", value); }
        /// <summary>
        /// self?: this;
        /// </summary>
        public Node Self { get => JSRef!.Get<Node>("self"); set => JSRef!.Set("self", value); }
        /// <summary>
        /// static get type(): string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// updateAfterType: NodeUpdateType;
        /// </summary>
        public NodeUpdateType UpdateAfterType { get => JSRef!.Get<NodeUpdateType>("updateAfterType"); set => JSRef!.Set("updateAfterType", value); }
        /// <summary>
        /// updateBeforeType: NodeUpdateType;
        /// </summary>
        public NodeUpdateType UpdateBeforeType { get => JSRef!.Get<NodeUpdateType>("updateBeforeType"); set => JSRef!.Set("updateBeforeType", value); }
        /// <summary>
        /// updateType: NodeUpdateType;
        /// </summary>
        public NodeUpdateType UpdateType { get => JSRef!.Get<NodeUpdateType>("updateType"); set => JSRef!.Set("updateType", value); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateReference(state: NodeBuilder | NodeFrame): object;
        /// </summary>
        public object UpdateReference(Union<NodeBuilder, NodeFrame> state)
        {
            return JSRef!.Call<object>("updateReference", state);
        }
        /// <summary>
        /// updateBefore(frame: NodeFrame): void;
        /// </summary>
        public void UpdateBefore(NodeFrame frame)
        {
            JSRef!.CallVoid("updateBefore", frame);
        }
        /// <summary>
        /// updateAfter(frame: NodeFrame): void;
        /// </summary>
        public void UpdateAfter(NodeFrame frame)
        {
            JSRef!.CallVoid("updateAfter", frame);
        }
        /// <summary>
        /// update(frame: NodeFrame): void;
        /// </summary>
        public void Update(NodeFrame frame)
        {
            JSRef!.CallVoid("update", frame);
        }
        /// <summary>
        /// traverse(callback: (node: Node) => void): void;
        /// </summary>
        public void Traverse(Callback callback, Node node)
        {
            JSRef!.CallVoid("traverse", callback, node);
        }
        /// <summary>
        /// setup(builder: NodeBuilder): object;
        /// </summary>
        public object Setup(NodeBuilder builder)
        {
            return JSRef!.Call<object>("setup", builder);
        }
        /// <summary>
        /// onUpdate(callback: (this: this, frame: NodeFrame) => object, updateType: NodeUpdateType): this;
        /// </summary>
        public Node OnUpdate(Callback callback, Node thisObj, NodeFrame frame, NodeUpdateType updateType)
        {
            return JSRef!.Call<Node>("onUpdate", callback, thisObj, frame, updateType);
        }
        /// <summary>
        /// onRenderUpdate(callback: (this: this, frame: NodeFrame) => void): this;
        /// </summary>
        public Node OnRenderUpdate(Callback callback, Node thisObj, NodeFrame frame)
        {
            return JSRef!.Call<Node>("onRenderUpdate", callback, thisObj, frame);
        }
        /// <summary>
        /// onReference(callback: (this: this, frame: NodeBuilder | NodeFrame) => object): this;
        /// </summary>
        public Node OnReference(Callback callback, Node thisObj, Union<NodeBuilder, NodeFrame> frame)
        {
            return JSRef!.Call<Node>("onReference", callback, thisObj, frame);
        }
        /// <summary>
        /// onObjectUpdate(callback: (this: this, frame: NodeFrame) => void): this;
        /// </summary>
        public Node OnObjectUpdate(Callback callback, Node thisObj, NodeFrame frame)
        {
            return JSRef!.Call<Node>("onObjectUpdate", callback, thisObj, frame);
        }
        /// <summary>
        /// onFrameUpdate(callback: (this: this, frame: NodeFrame) => void): this;
        /// </summary>
        public Node OnFrameUpdate(Callback callback, Node thisObj, NodeFrame frame)
        {
            return JSRef!.Call<Node>("onFrameUpdate", callback, thisObj, frame);
        }
        /// <summary>
        /// isGlobal(builder: NodeBuilder): boolean;
        /// </summary>
        public bool IsGlobal(NodeBuilder builder)
        {
            return JSRef!.Call<bool>("isGlobal", builder);
        }
        /// <summary>
        /// import(
        /// </summary>
        public object Import()
        {
            return JSRef!.Call<object>("import");
        }
        /// <summary>
        /// getUpdateType(): NodeUpdateType;
        /// </summary>
        public NodeUpdateType GetUpdateType()
        {
            return JSRef!.Call<NodeUpdateType>("getUpdateType");
        }
        /// <summary>
        /// getUpdateBeforeType(): NodeUpdateType;
        /// </summary>
        public NodeUpdateType GetUpdateBeforeType()
        {
            return JSRef!.Call<NodeUpdateType>("getUpdateBeforeType");
        }
        /// <summary>
        /// getUpdateAfterType(): NodeUpdateType;
        /// </summary>
        public NodeUpdateType GetUpdateAfterType()
        {
            return JSRef!.Call<NodeUpdateType>("getUpdateAfterType");
        }
        /// <summary>
        /// getShared(builder: NodeBuilder): Node;
        /// </summary>
        public Node GetShared(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("getShared", builder);
        }
        /// <summary>
        /// getSerializeChildren(): Generator<
        /// </summary>
        public object GetSerializeChildren()
        {
            return JSRef!.Call<object>("getSerializeChildren");
        }
        /// <summary>
        /// getScope(): this;
        /// </summary>
        public Node GetScope()
        {
            return JSRef!.Call<Node>("getScope");
        }
        /// <summary>
        /// getNodeType(builder: NodeBuilder): string | null;
        /// </summary>
        public string GetNodeType(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getNodeType", builder);
        }
        /// <summary>
        /// getMemberType(builder: NodeBuilder, name: string): string;
        /// </summary>
        public string GetMemberType(NodeBuilder builder, string name)
        {
            return JSRef!.Call<string>("getMemberType", builder, name);
        }
        /// <summary>
        /// getHash(builder: NodeBuilder): string;
        /// </summary>
        public string GetHash(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getHash", builder);
        }
        /// <summary>
        /// getElementType(builder: NodeBuilder): "bool" | "int" | "float" | "vec2" | "vec3" | "vec4" | "uint" | null;
        /// </summary>
        public string GetElementType(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getElementType", builder);
        }
        /// <summary>
        /// getChildren(): Generator<Node, void, object>;
        /// </summary>
        public Generator<Node, object> GetChildren()
        {
            return JSRef!.Call<Generator<Node, object>>("getChildren");
        }
        /// <summary>
        /// getCacheKey(force?: boolean): number;
        /// </summary>
        public float GetCacheKey(bool force)
        {
            return JSRef!.Call<float>("getCacheKey", force);
        }
        /// <summary>
        /// getArrayCount(builder: NodeBuilder): number | null;
        /// </summary>
        public float GetArrayCount(NodeBuilder builder)
        {
            return JSRef!.Call<float>("getArrayCount", builder);
        }
        /// <summary>
        /// generate(builder: NodeBuilder, output?: string | null): string | null | undefined;
        /// </summary>
        public string Generate(NodeBuilder builder, string output)
        {
            return JSRef!.Call<string>("generate", builder, output);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// customCacheKey(): number;
        /// </summary>
        public float CustomCacheKey()
        {
            return JSRef!.Call<float>("customCacheKey");
        }
        /// <summary>
        /// build(builder: NodeBuilder, output?: string | Node | null): Node | string | null;
        /// </summary>
        public Union<Node, string> Build(NodeBuilder builder, Union<string, Node> output)
        {
            return JSRef!.Call<Union<Node, string>>("build", builder, output);
        }
        /// <summary>
        /// analyze(builder: NodeBuilder, output?: Node | null): void;
        /// </summary>
        public void Analyze(NodeBuilder builder, Node output)
        {
            JSRef!.CallVoid("analyze", builder, output);
        }
        #endregion
    }
}
