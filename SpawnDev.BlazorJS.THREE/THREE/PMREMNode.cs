
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PMREMNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public PMREMNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(value: Texture, uvNode?: Node | null, levelNode?: Node | null);
        /// </summary>
        public PMREMNode(Texture value, Node uvNode, Node levelNode) : base(JS.New("THREE.PMREMNode", value, uvNode, levelNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// levelNode: Node | null;
        /// </summary>
        public Node LevelNode { get => JSRef!.Get<Node>("levelNode"); set => JSRef!.Set("levelNode", value); }
        /// <summary>
        /// uvNode: Node | null;
        /// </summary>
        public Node UvNode { get => JSRef!.Get<Node>("uvNode"); set => JSRef!.Set("uvNode", value); }
        /// <summary>
        /// set value(value: Texture);
        /// </summary>
        public Texture Value { get => JSRef!.Get<Texture>("value"); set => JSRef!.Set("value", value); }
        #endregion

        #region Methods

        #endregion
    }
}
