
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StorageBufferNode<TValue> : BufferNode<TValue>
    {
        #region Constructors
        /// <inheritdoc/>
        public StorageBufferNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         value: StorageBufferAttribute | StorageInstancedBufferAttribute,
        ///         bufferType?: string | Struct | null,
        ///         bufferCount?: number,
        ///     );
        /// </summary>
        public StorageBufferNode(Union<StorageBufferAttribute, StorageInstancedBufferAttribute> value, Union<string, Struct> bufferType, float bufferCount) : base(JS.New("THREE.StorageBufferNode", value, bufferType, bufferCount)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// access: NodeAccess;
        /// </summary>
        public NodeAccess Access { get => JSRef!.Get<NodeAccess>("access"); set => JSRef!.Set("access", value); }
        /// <summary>
        /// bufferObject: boolean;
        /// </summary>
        public bool BufferObject { get => JSRef!.Get<bool>("bufferObject"); set => JSRef!.Set("bufferObject", value); }
        /// <summary>
        /// isAtomic: boolean;
        /// </summary>
        public bool IsAtomic { get => JSRef!.Get<bool>("isAtomic"); set => JSRef!.Set("isAtomic", value); }
        /// <summary>
        /// isPBO: boolean;
        /// </summary>
        public bool IsPBO { get => JSRef!.Get<bool>("isPBO"); set => JSRef!.Set("isPBO", value); }
        /// <summary>
        /// readonly isStorageBufferNode: true;
        /// </summary>
        public bool IsStorageBufferNode { get => JSRef!.Get<bool>("isStorageBufferNode"); }
        /// <summary>
        /// structTypeNode: StructTypeNode | null;
        /// </summary>
        public StructTypeNode StructTypeNode { get => JSRef!.Get<StructTypeNode>("structTypeNode"); set => JSRef!.Set("structTypeNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toReadOnly(): this;
        /// </summary>
        public StorageBufferNode<TValue> ToReadOnly()
        {
            return JSRef!.Call<StorageBufferNode<TValue>>("toReadOnly");
        }
        /// <summary>
        /// toAtomic(): this;
        /// </summary>
        public StorageBufferNode<TValue> ToAtomic()
        {
            return JSRef!.Call<StorageBufferNode<TValue>>("toAtomic");
        }
        /// <summary>
        /// setPBO(value: boolean): this;
        /// </summary>
        public StorageBufferNode<TValue> SetPBO(bool value)
        {
            return JSRef!.Call<StorageBufferNode<TValue>>("setPBO", value);
        }
        /// <summary>
        /// setAtmoic(value: boolean): this;
        /// </summary>
        public StorageBufferNode<TValue> SetAtmoic(bool value)
        {
            return JSRef!.Call<StorageBufferNode<TValue>>("setAtmoic", value);
        }
        /// <summary>
        /// setAccess(value: NodeAccess): this;
        /// </summary>
        public StorageBufferNode<TValue> SetAccess(NodeAccess value)
        {
            return JSRef!.Call<StorageBufferNode<TValue>>("setAccess", value);
        }
        /// <summary>
        /// getPBO(): boolean;
        /// </summary>
        public bool GetPBO()
        {
            return JSRef!.Call<bool>("getPBO");
        }
        /// <summary>
        /// element(indexNode: Node | number): ShaderNodeObject<StorageArrayElementNode>;
        /// </summary>
        public ShaderNodeObject<StorageArrayElementNode<TValue>> Element(Union<Node, float> indexNode)
        {
            return JSRef!.Call<ShaderNodeObject<StorageArrayElementNode<TValue>>>("element", indexNode);
        }
        #endregion
    }
}
