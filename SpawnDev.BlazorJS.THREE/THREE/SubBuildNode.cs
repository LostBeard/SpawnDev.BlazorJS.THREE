
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SubBuildNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public SubBuildNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, name: string, nodeType?: string | null);
        /// </summary>
        public SubBuildNode(Node node, string name, string nodeType) : base(JS.New("THREE.SubBuildNode", node, name, nodeType)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isSubBuildNode: true;
        /// </summary>
        public bool IsSubBuildNode { get => JSRef!.Get<bool>("isSubBuildNode"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        #endregion

        #region Methods

        #endregion
    }
}
