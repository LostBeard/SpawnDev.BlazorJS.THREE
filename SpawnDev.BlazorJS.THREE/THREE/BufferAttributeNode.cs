
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BufferAttributeNode : InputNode
    {
        /// <inheritdoc/>
        public BufferAttributeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class BufferAttributeNode<T> : InputNode<T>
    {
        #region Constructors
        /// <inheritdoc/>
        public BufferAttributeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         value: TypedArray | InterleavedBuffer | BufferAttribute,
        ///         bufferType?: string | null,
        ///         bufferStride?: number,
        ///         bufferOffset?: number,
        ///     );
        /// </summary>
        public BufferAttributeNode(Union<TypedArray, InterleavedBuffer, BufferAttribute> value, string bufferType, float bufferStride, float bufferOffset) : base(JS.New("THREE.BufferAttributeNode", value, bufferType, bufferStride, bufferOffset)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// attribute: BufferAttribute | InterleavedBufferAttribute | null;
        /// </summary>
        public Union<BufferAttribute, InterleavedBufferAttribute> Attribute { get => JSRef!.Get<Union<BufferAttribute, InterleavedBufferAttribute>>("attribute"); set => JSRef!.Set("attribute", value); }
        /// <summary>
        /// bufferOffset: number;
        /// </summary>
        public float BufferOffset { get => JSRef!.Get<float>("bufferOffset"); set => JSRef!.Set("bufferOffset", value); }
        /// <summary>
        /// bufferStride: number;
        /// </summary>
        public float BufferStride { get => JSRef!.Get<float>("bufferStride"); set => JSRef!.Set("bufferStride", value); }
        /// <summary>
        /// bufferType: string | null;
        /// </summary>
        public string BufferType { get => JSRef!.Get<string>("bufferType"); set => JSRef!.Set("bufferType", value); }
        /// <summary>
        /// instanced: boolean;
        /// </summary>
        public bool Instanced { get => JSRef!.Get<bool>("instanced"); set => JSRef!.Set("instanced", value); }
        /// <summary>
        /// readonly isBufferNode: true;
        /// </summary>
        public bool IsBufferNode { get => JSRef!.Get<bool>("isBufferNode"); }
        /// <summary>
        /// static get type(): string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// usage: Usage;
        /// </summary>
        public Usage Usage { get => JSRef!.Get<Usage>("usage"); set => JSRef!.Set("usage", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setUsage(value: Usage): this;
        /// </summary>
        public BufferAttributeNode<T> SetUsage(Usage value)
        {
            return JSRef!.Call<BufferAttributeNode<T>>("setUsage", value);
        }
        /// <summary>
        /// setup(builder: NodeBuilder): void;
        /// </summary>
        public void Setup(NodeBuilder builder)
        {
            JSRef!.CallVoid("setup", builder);
        }
        /// <summary>
        /// setInstanced(value: boolean): this;
        /// </summary>
        public BufferAttributeNode<T> SetInstanced(bool value)
        {
            return JSRef!.Call<BufferAttributeNode<T>>("setInstanced", value);
        }
        /// <summary>
        /// getNodeType(builder: NodeBuilder): string | null;
        /// </summary>
        public string GetNodeType(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getNodeType", builder);
        }
        /// <summary>
        /// getInputType(): string;
        /// </summary>
        public string GetInputType()
        {
            return JSRef!.Call<string>("getInputType");
        }
        /// <summary>
        /// getHash(builder: NodeBuilder): string;
        /// </summary>
        public string GetHash(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getHash", builder);
        }
        /// <summary>
        /// generate(builder: NodeBuilder): string | null | undefined;
        /// </summary>
        public string Generate(NodeBuilder builder)
        {
            return JSRef!.Call<string>("generate", builder);
        }
        #endregion
    }
}
