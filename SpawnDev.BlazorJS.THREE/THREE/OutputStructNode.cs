
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class OutputStructNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public OutputStructNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(...members: Node[]);
        /// </summary>
        public OutputStructNode(params Node[] members) : base(JS.NewApply("THREE.OutputStructNode", members)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isOutputStructNode: true;
        /// </summary>
        public bool IsOutputStructNode { get => JSRef!.Get<bool>("isOutputStructNode"); }
        /// <summary>
        /// members: Node[];
        /// </summary>
        public Array<Node> Members { get => JSRef!.Get<Array<Node>>("members"); set => JSRef!.Set("members", value); }
        #endregion

        #region Methods

        #endregion
    }
}
