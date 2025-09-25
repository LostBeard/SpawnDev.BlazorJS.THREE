
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BypassNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public BypassNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(returnNode: Node, callNode: Node);
        /// </summary>
        public BypassNode(Node returnNode, Node callNode) : base(JS.New("THREE.BypassNode", returnNode, callNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// callNode: Node;
        /// </summary>
        public Node CallNode { get => JSRef!.Get<Node>("callNode"); set => JSRef!.Set("callNode", value); }
        /// <summary>
        /// isBypassNode: true;
        /// </summary>
        public bool IsBypassNode { get => JSRef!.Get<bool>("isBypassNode"); set => JSRef!.Set("isBypassNode", value); }
        /// <summary>
        /// outputNode: Node;
        /// </summary>
        public Node OutputNode { get => JSRef!.Get<Node>("outputNode"); set => JSRef!.Set("outputNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
