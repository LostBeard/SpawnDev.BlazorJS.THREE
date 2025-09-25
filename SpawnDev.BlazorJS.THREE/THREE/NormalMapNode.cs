
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NormalMapNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public NormalMapNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, scaleNode?: Node | null);
        /// </summary>
        public NormalMapNode(Node node, Node scaleNode) : base(JS.New("THREE.NormalMapNode", node, scaleNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// normalMapType: NormalMapTypes;
        /// </summary>
        public NormalMapTypes NormalMapType { get => JSRef!.Get<NormalMapTypes>("normalMapType"); set => JSRef!.Set("normalMapType", value); }
        /// <summary>
        /// scaleNode: Node | null;
        /// </summary>
        public Node ScaleNode { get => JSRef!.Get<Node>("scaleNode"); set => JSRef!.Set("scaleNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
