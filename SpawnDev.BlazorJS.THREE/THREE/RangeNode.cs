
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RangeNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public RangeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(minNode: Node, maxNode: Node);
        /// </summary>
        public RangeNode(Node minNode, Node maxNode) : base(JS.New("THREE.RangeNode", minNode, maxNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// maxNode: Node;
        /// </summary>
        public Node MaxNode { get => JSRef!.Get<Node>("maxNode"); set => JSRef!.Set("maxNode", value); }
        /// <summary>
        /// minNode: Node;
        /// </summary>
        public Node MinNode { get => JSRef!.Get<Node>("minNode"); set => JSRef!.Set("minNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getVectorLength(builder: NodeBuilder): number;
        /// </summary>
        public float GetVectorLength(NodeBuilder builder)
        {
            return JSRef!.Call<float>("getVectorLength", builder);
        }
        #endregion
    }
}
