
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ArrayElementNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ArrayElementNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, indexNode: Node);
        /// </summary>
        public ArrayElementNode(Node node, Node indexNode) : base(JS.New("THREE.ArrayElementNode", node, indexNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// indexNode: Node;
        /// </summary>
        public Node IndexNode { get => JSRef!.Get<Node>("indexNode"); set => JSRef!.Set("indexNode", value); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        #endregion

        #region Methods

        #endregion
    }
}
