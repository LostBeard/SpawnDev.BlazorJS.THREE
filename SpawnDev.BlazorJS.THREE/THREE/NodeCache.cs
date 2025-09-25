
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeCache : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeCache(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parent?: NodeCache | null);
        /// </summary>
        public NodeCache(NodeCache parent) : base(JS.New("THREE.NodeCache", parent)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// nodesData: WeakMap<Node | TypedArray | InterleavedBuffer | BufferAttribute, NodeData | BufferAttributeData>;
        /// </summary>
        public WeakMap<Union<Node, TypedArray, InterleavedBuffer, BufferAttribute>, Union<NodeData, BufferAttributeData>> NodesData { get => JSRef!.Get<WeakMap<Union<Node, TypedArray, InterleavedBuffer, BufferAttribute>, Union<NodeData, BufferAttributeData>>>("nodesData"); set => JSRef!.Set("nodesData", value); }
        /// <summary>
        /// parent: NodeCache | null;
        /// </summary>
        public NodeCache Parent { get => JSRef!.Get<NodeCache>("parent"); set => JSRef!.Set("parent", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setData(node: Node, data: NodeData): void;
        /// </summary>
        public void SetData(Node node, NodeData data)
        {
            JSRef!.CallVoid("setData", node, data);
        }
        /// <summary>
        /// setData(node: TypedArray | InterleavedBuffer | BufferAttribute, data: BufferAttributeData): void;
        /// </summary>
        public void SetData(Union<TypedArray, InterleavedBuffer, BufferAttribute> node, BufferAttributeData data)
        {
            JSRef!.CallVoid("setData", node, data);
        }
        /// <summary>
        /// getData(node: Node): NodeData | undefined;
        /// </summary>
        public NodeData GetData(Node node)
        {
            return JSRef!.Call<NodeData>("getData", node);
        }
        /// <summary>
        /// getData(node: TypedArray | InterleavedBuffer | BufferAttribute): BufferAttributeData | undefined;
        /// </summary>
        public BufferAttributeData GetData(Union<TypedArray, InterleavedBuffer, BufferAttribute> node)
        {
            return JSRef!.Call<BufferAttributeData>("getData", node);
        }
        #endregion
    }
}
