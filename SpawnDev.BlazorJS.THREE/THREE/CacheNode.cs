
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CacheNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public CacheNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, parent?: boolean);
        /// </summary>
        public CacheNode(Node node, bool parent) : base(JS.New("THREE.CacheNode", node, parent)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isCacheNode: true;
        /// </summary>
        public bool IsCacheNode { get => JSRef!.Get<bool>("isCacheNode"); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// parent: boolean;
        /// </summary>
        public bool Parent { get => JSRef!.Get<bool>("parent"); set => JSRef!.Set("parent", value); }
        #endregion

        #region Methods

        #endregion
    }
}
