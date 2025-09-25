
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AssignNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public AssignNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(targetNode: Node, sourceNode: Node);
        /// </summary>
        public AssignNode(Node targetNode, Node sourceNode) : base(JS.New("THREE.AssignNode", targetNode, sourceNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isAssignNode: true;
        /// </summary>
        public bool IsAssignNode { get => JSRef!.Get<bool>("isAssignNode"); }
        #endregion

        #region Methods
        /// <summary>
        /// needsSplitAssign(builder: NodeBuilder): boolean;
        /// </summary>
        public bool NeedsSplitAssign(NodeBuilder builder)
        {
            return JSRef!.Call<bool>("needsSplitAssign", builder);
        }
        #endregion
    }
}
