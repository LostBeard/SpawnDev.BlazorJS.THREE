
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SpriteSheetUVNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public SpriteSheetUVNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(countNode: Node, uvNode?: Node, frameNode?: Node);
        /// </summary>
        public SpriteSheetUVNode(Node countNode, Node uvNode, Node frameNode) : base(JS.New("THREE.SpriteSheetUVNode", countNode, uvNode, frameNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// countNode: Node;
        /// </summary>
        public Node CountNode { get => JSRef!.Get<Node>("countNode"); set => JSRef!.Set("countNode", value); }
        /// <summary>
        /// frameNode: Node;
        /// </summary>
        public Node FrameNode { get => JSRef!.Get<Node>("frameNode"); set => JSRef!.Set("frameNode", value); }
        /// <summary>
        /// uvNode: Node;
        /// </summary>
        public Node UvNode { get => JSRef!.Get<Node>("uvNode"); set => JSRef!.Set("uvNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
