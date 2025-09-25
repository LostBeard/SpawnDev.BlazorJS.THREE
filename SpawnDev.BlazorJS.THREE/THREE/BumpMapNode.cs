
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BumpMapNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public BumpMapNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(textureNode: Node, scaleNode?: Node | null);
        /// </summary>
        public BumpMapNode(Node textureNode, Node scaleNode) : base(JS.New("THREE.BumpMapNode", textureNode, scaleNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// scaleNode: Node | null;
        /// </summary>
        public Node ScaleNode { get => JSRef!.Get<Node>("scaleNode"); set => JSRef!.Set("scaleNode", value); }
        /// <summary>
        /// textureNode: Node;
        /// </summary>
        public Node TextureNode { get => JSRef!.Get<Node>("textureNode"); set => JSRef!.Set("textureNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
