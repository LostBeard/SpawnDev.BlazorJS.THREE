
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MemberNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public MemberNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, property: string);
        /// </summary>
        public MemberNode(Node node, string property) : base(JS.New("THREE.MemberNode", node, property)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMemberNode: true;
        /// </summary>
        public bool IsMemberNode { get => JSRef!.Get<bool>("isMemberNode"); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// property: string;
        /// </summary>
        public string Property { get => JSRef!.Get<string>("property"); set => JSRef!.Set("property", value); }
        #endregion

        #region Methods

        #endregion
    }
}
