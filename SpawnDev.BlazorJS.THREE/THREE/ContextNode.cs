
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ContextNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ContextNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, value?: NodeBuilderContext);
        /// </summary>
        public ContextNode(Node node, NodeBuilderContext value) : base(JS.New("THREE.ContextNode", node, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isContextNode: true;
        /// </summary>
        public bool IsContextNode { get => JSRef!.Get<bool>("isContextNode"); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// value: NodeBuilderContext;
        /// </summary>
        public NodeBuilderContext Value { get => JSRef!.Get<NodeBuilderContext>("value"); set => JSRef!.Set("value", value); }
        #endregion

        #region Methods

        #endregion
    }
}
