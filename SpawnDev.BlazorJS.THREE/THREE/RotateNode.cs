
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RotateNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public RotateNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(positionNode: Node, rotationNode: Node);
        /// </summary>
        public RotateNode(Node positionNode, Node rotationNode) : base(JS.New("THREE.RotateNode", positionNode, rotationNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// positionNode: Node;
        /// </summary>
        public Node PositionNode { get => JSRef!.Get<Node>("positionNode"); set => JSRef!.Set("positionNode", value); }
        /// <summary>
        /// rotationNode: Node;
        /// </summary>
        public Node RotationNode { get => JSRef!.Get<Node>("rotationNode"); set => JSRef!.Set("rotationNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
