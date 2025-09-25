
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ToonOutlinePassNode : PassNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ToonOutlinePassNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scene: Scene, camera: Camera, colorNode: Node, thicknessNode: Node, alphaNode: Node);
        /// </summary>
        public ToonOutlinePassNode(Scene scene, Camera camera, Node colorNode, Node thicknessNode, Node alphaNode) : base(JS.New("THREE.ToonOutlinePassNode", scene, camera, colorNode, thicknessNode, alphaNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// alphaNode: Node;
        /// </summary>
        public Node AlphaNode { get => JSRef!.Get<Node>("alphaNode"); set => JSRef!.Set("alphaNode", value); }
        /// <summary>
        /// colorNode: Node;
        /// </summary>
        public Node ColorNode { get => JSRef!.Get<Node>("colorNode"); set => JSRef!.Set("colorNode", value); }
        /// <summary>
        /// thicknessNode: Node;
        /// </summary>
        public Node ThicknessNode { get => JSRef!.Get<Node>("thicknessNode"); set => JSRef!.Set("thicknessNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
