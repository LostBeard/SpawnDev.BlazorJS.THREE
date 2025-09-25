
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StorageArrayElementNode<TValue> : ArrayElementNode
    {
        #region Constructors
        /// <inheritdoc/>
        public StorageArrayElementNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(storageBufferNode: StorageBufferNode, indexNode: Node);
        /// </summary>
        public StorageArrayElementNode(StorageBufferNode<TValue> storageBufferNode, Node indexNode) : base(JS.New("THREE.StorageArrayElementNode", storageBufferNode, indexNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isStorageArrayElementNode: true;
        /// </summary>
        public bool IsStorageArrayElementNode { get => JSRef!.Get<bool>("isStorageArrayElementNode"); }
        /// <summary>
        /// node: StorageBufferNode;
        /// </summary>
        public StorageBufferNode<TValue> Node { get => JSRef!.Get<StorageBufferNode<TValue>>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// get storageBufferNode(): StorageBufferNode;
        /// </summary>
        public StorageBufferNode<TValue> StorageBufferNode { get => JSRef!.Get<StorageBufferNode<TValue>>("storageBufferNode"); set => JSRef!.Set("storageBufferNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
