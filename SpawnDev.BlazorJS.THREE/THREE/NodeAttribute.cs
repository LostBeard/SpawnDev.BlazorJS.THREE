
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeAttribute : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, type: string | null, node?: Node | null);
        /// </summary>
        public NodeAttribute(string name, string type, Node node) : base(JS.New("THREE.NodeAttribute", name, type, node)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isNodeAttribute: true;
        /// </summary>
        public bool IsNodeAttribute { get => JSRef!.Get<bool>("isNodeAttribute"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// node: Node | null;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// type: string | null;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods

        #endregion
    }
}
