
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BatchNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public BatchNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(batchMesh: BatchedMesh);
        /// </summary>
        public BatchNode(BatchedMesh batchMesh) : base(JS.New("THREE.BatchNode", batchMesh)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// batchingIdNode: Node | null;
        /// </summary>
        public Node BatchingIdNode { get => JSRef!.Get<Node>("batchingIdNode"); set => JSRef!.Set("batchingIdNode", value); }
        /// <summary>
        /// batchMesh: BatchedMesh;
        /// </summary>
        public BatchedMesh BatchMesh { get => JSRef!.Get<BatchedMesh>("batchMesh"); set => JSRef!.Set("batchMesh", value); }
        #endregion

        #region Methods

        #endregion
    }
}
