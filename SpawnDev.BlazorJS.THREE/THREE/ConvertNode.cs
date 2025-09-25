
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ConvertNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ConvertNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, convertTo: string);
        /// </summary>
        public ConvertNode(Node node, string convertTo) : base(JS.New("THREE.ConvertNode", node, convertTo)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// convertTo: string;
        /// </summary>
        public string ConvertTo { get => JSRef!.Get<string>("convertTo"); set => JSRef!.Set("convertTo", value); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        #endregion

        #region Methods

        #endregion
    }
}
