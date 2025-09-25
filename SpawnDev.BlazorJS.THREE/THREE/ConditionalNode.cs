
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ConditionalNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ConditionalNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(condNode: Node, ifNode: Node, elseNode?: Node | null);
        /// </summary>
        public ConditionalNode(Node condNode, Node ifNode, Node elseNode) : base(JS.New("THREE.ConditionalNode", condNode, ifNode, elseNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// condNode: Node;
        /// </summary>
        public Node CondNode { get => JSRef!.Get<Node>("condNode"); set => JSRef!.Set("condNode", value); }
        /// <summary>
        /// elseNode: Node | null;
        /// </summary>
        public Node ElseNode { get => JSRef!.Get<Node>("elseNode"); set => JSRef!.Set("elseNode", value); }
        /// <summary>
        /// ifNode: Node;
        /// </summary>
        public Node IfNode { get => JSRef!.Get<Node>("ifNode"); set => JSRef!.Set("ifNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
