
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StructNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public StructNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(structLayoutNode: StructTypeNode, values: Node[]);
        /// </summary>
        public StructNode(StructTypeNode structLayoutNode, Array<Node> values) : base(JS.New("THREE.StructNode", structLayoutNode, values)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// values: Node[];
        /// </summary>
        public Array<Node> Values { get => JSRef!.Get<Array<Node>>("values"); set => JSRef!.Set("values", value); }
        #endregion

        #region Methods

        #endregion
    }
}
