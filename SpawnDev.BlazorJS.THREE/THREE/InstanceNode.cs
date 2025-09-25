
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InstanceNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public InstanceNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         count: number,
        ///         instanceMatrix: InstancedBufferAttribute,
        ///         instanceColor?: InstancedBufferAttribute | null,
        ///     );
        /// </summary>
        public InstanceNode(float count, InstancedBufferAttribute instanceMatrix, InstancedBufferAttribute instanceColor) : base(JS.New("THREE.InstanceNode", count, instanceMatrix, instanceColor)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// count: number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// instanceColor: InstancedBufferAttribute | null;
        /// </summary>
        public InstancedBufferAttribute InstanceColor { get => JSRef!.Get<InstancedBufferAttribute>("instanceColor"); set => JSRef!.Set("instanceColor", value); }
        /// <summary>
        /// instanceColorNode: Node | null;
        /// </summary>
        public Node InstanceColorNode { get => JSRef!.Get<Node>("instanceColorNode"); set => JSRef!.Set("instanceColorNode", value); }
        /// <summary>
        /// instanceMatrix: InstancedBufferAttribute;
        /// </summary>
        public InstancedBufferAttribute InstanceMatrix { get => JSRef!.Get<InstancedBufferAttribute>("instanceMatrix"); set => JSRef!.Set("instanceMatrix", value); }
        /// <summary>
        /// instanceMatrixNode: Node | null;
        /// </summary>
        public Node InstanceMatrixNode { get => JSRef!.Get<Node>("instanceMatrixNode"); set => JSRef!.Set("instanceMatrixNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
