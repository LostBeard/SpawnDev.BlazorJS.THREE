
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RemapNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public RemapNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, inLowNode: Node, inHighNode: Node, outLowNode?: Node, outHighNode?: Node);
        /// </summary>
        public RemapNode(Node node, Node inLowNode, Node inHighNode, Node outLowNode, Node outHighNode) : base(JS.New("THREE.RemapNode", node, inLowNode, inHighNode, outLowNode, outHighNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// doClamp: boolean;
        /// </summary>
        public bool DoClamp { get => JSRef!.Get<bool>("doClamp"); set => JSRef!.Set("doClamp", value); }
        /// <summary>
        /// inHighNode: Node;
        /// </summary>
        public Node InHighNode { get => JSRef!.Get<Node>("inHighNode"); set => JSRef!.Set("inHighNode", value); }
        /// <summary>
        /// inLowNode: Node;
        /// </summary>
        public Node InLowNode { get => JSRef!.Get<Node>("inLowNode"); set => JSRef!.Set("inLowNode", value); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// outHighNode: Node;
        /// </summary>
        public Node OutHighNode { get => JSRef!.Get<Node>("outHighNode"); set => JSRef!.Set("outHighNode", value); }
        /// <summary>
        /// outLowNode: Node;
        /// </summary>
        public Node OutLowNode { get => JSRef!.Get<Node>("outLowNode"); set => JSRef!.Set("outLowNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
