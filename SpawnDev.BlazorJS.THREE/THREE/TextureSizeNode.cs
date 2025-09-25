
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TextureSizeNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public TextureSizeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(textureNode: Node, levelNode?: Node | null);
        /// </summary>
        public TextureSizeNode(Node textureNode, Node levelNode) : base(JS.New("THREE.TextureSizeNode", textureNode, levelNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isTextureSizeNode: true;
        /// </summary>
        public bool IsTextureSizeNode { get => JSRef!.Get<bool>("isTextureSizeNode"); }
        /// <summary>
        /// levelNode: Node | null;
        /// </summary>
        public Node LevelNode { get => JSRef!.Get<Node>("levelNode"); set => JSRef!.Set("levelNode", value); }
        /// <summary>
        /// textureNode: Node;
        /// </summary>
        public Node TextureNode { get => JSRef!.Get<Node>("textureNode"); set => JSRef!.Set("textureNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
