
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class UniformNode<TValue> : InputNode<TValue>
    {
        #region Constructors
        /// <inheritdoc/>
        public UniformNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(value: TValue, nodeType?: string | null);
        /// </summary>
        public UniformNode(TValue value, string nodeType) : base(JS.New("THREE.UniformNode", value, nodeType)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// groupNode: UniformGroupNode;
        /// </summary>
        public UniformGroupNode GroupNode { get => JSRef!.Get<UniformGroupNode>("groupNode"); set => JSRef!.Set("groupNode", value); }
        /// <summary>
        /// readonly isUniformNode: true;
        /// </summary>
        public bool IsUniformNode { get => JSRef!.Get<bool>("isUniformNode"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// static get type(): string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// setName(name: string): this;
        /// </summary>
        public UniformNode<TValue> SetName(string name)
        {
            JSRef!.CallVoid("setName", name);
            return this;
        }
        /// <summary>
        /// setGroup(group: UniformGroupNode): this;
        /// </summary>
        public UniformNode<TValue> SetGroup(UniformGroupNode group)
        {
            JSRef!.CallVoid("setGroup", group);
            return this;
        }
        /// <summary>
        /// onUpdate(callback: (frame: NodeFrame, self: this) => TValue | undefined, updateType: NodeUpdateType): this;
        /// </summary>
        public UniformNode<TValue> OnUpdate(ActionCallback<NodeFrame, UniformNode<TValue>> callback, NodeUpdateType updateType)
        {
            JSRef!.CallVoid("onUpdate", callback, updateType);
            return this;
        }
        /// <summary>
        /// label(name: string): this;
        /// </summary>
        public UniformNode<TValue> Label(string name)
        {
            JSRef!.CallVoid("label", name);
            return this;
        }
        /// <summary>
        /// getUniformHash(builder: NodeBuilder): string;
        /// </summary>
        public string GetUniformHash(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getUniformHash", builder);
        }
        /// <summary>
        /// getInputType(builder: NodeBuilder): string | null;
        /// </summary>
        public string GetInputType(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getInputType", builder);
        }
        /// <summary>
        /// getGroup(): UniformGroupNode;
        /// </summary>
        public UniformGroupNode GetGroup()
        {
            return JSRef!.Call<UniformGroupNode>("getGroup");
        }
        /// <summary>
        /// generate(builder: NodeBuilder, output: string | null): string;
        /// </summary>
        public string Generate(NodeBuilder builder, string output)
        {
            return JSRef!.Call<string>("generate", builder, output);
        }
        #endregion
    }
}
