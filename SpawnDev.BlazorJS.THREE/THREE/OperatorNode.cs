
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class OperatorNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public OperatorNode(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(op: OperatorNodeOp, ...params: [Node, Node, ...Node[]
        /// </summary>
        public OperatorNode(OperatorNodeOp op, params object[] nodes) : base(JS.NewApply("THREE.OperatorNode", new object[] { op }.Concat(nodes).ToArray())) { }

        #endregion

        #region Properties
        /// <summary>
        /// aNode: Node;
        /// </summary>
        public Node ANode { get => JSRef!.Get<Node>("aNode"); set => JSRef!.Set("aNode", value); }
        /// <summary>
        /// bNode: Node;
        /// </summary>
        public Node BNode { get => JSRef!.Get<Node>("bNode"); set => JSRef!.Set("bNode", value); }
        /// <summary>
        /// readonly isOperatorNode: true;
        /// </summary>
        public bool IsOperatorNode { get => JSRef!.Get<bool>("isOperatorNode"); }
        /// <summary>
        /// op: OperatorNodeOp;
        /// </summary>
        public OperatorNodeOp Op { get => JSRef!.Get<OperatorNodeOp>("op"); set => JSRef!.Set("op", value); }
        #endregion

        #region Methods

        #endregion
    }
}
