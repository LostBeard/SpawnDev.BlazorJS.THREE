
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StorageTextureNode : TextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public StorageTextureNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         value: Texture,
        ///         uvNode?: ShaderNodeObject<Node> | null,
        ///         storeNode?: Node | null,
        ///     );
        /// </summary>
        public StorageTextureNode(Texture value, ShaderNodeObject<Node> uvNode, Node storeNode) : base(JS.New("THREE.StorageTextureNode", value, uvNode, storeNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// access: NodeAccess;
        /// </summary>
        public NodeAccess Access { get => JSRef!.Get<NodeAccess>("access"); set => JSRef!.Set("access", value); }
        /// <summary>
        /// readonly isStorageTextureNode: true;
        /// </summary>
        public bool IsStorageTextureNode { get => JSRef!.Get<bool>("isStorageTextureNode"); }
        /// <summary>
        /// storeNode: Node | null;
        /// </summary>
        public Node StoreNode { get => JSRef!.Get<Node>("storeNode"); set => JSRef!.Set("storeNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toWriteOnly(): this;
        /// </summary>
        public StorageTextureNode ToWriteOnly()
        {
            return JSRef!.Call<StorageTextureNode>("toWriteOnly");
        }
        /// <summary>
        /// toReadWrite(): this;
        /// </summary>
        public StorageTextureNode ToReadWrite()
        {
            return JSRef!.Call<StorageTextureNode>("toReadWrite");
        }
        /// <summary>
        /// toReadOnly(): this;
        /// </summary>
        public StorageTextureNode ToReadOnly()
        {
            return JSRef!.Call<StorageTextureNode>("toReadOnly");
        }
        /// <summary>
        /// setAccess(value: NodeAccess): this;
        /// </summary>
        public StorageTextureNode SetAccess(NodeAccess value)
        {
            return JSRef!.Call<StorageTextureNode>("setAccess", value);
        }
        /// <summary>
        /// generateStore(builder: NodeBuilder): void;
        /// </summary>
        public void GenerateStore(NodeBuilder builder)
        {
            JSRef!.CallVoid("generateStore", builder);
        }
        #endregion
    }
}
