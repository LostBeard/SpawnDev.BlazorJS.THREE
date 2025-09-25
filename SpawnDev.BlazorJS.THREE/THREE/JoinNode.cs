
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class JoinNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public JoinNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodes: Node[]);
        /// </summary>
        public JoinNode(Array<Node> nodes) : base(JS.New("THREE.JoinNode", nodes)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodes: Node[];
        /// </summary>
        public Array<Node> Nodes { get => JSRef!.Get<Array<Node>>("nodes"); set => JSRef!.Set("nodes", value); }
        #endregion

        #region Methods

        #endregion
    }
}
