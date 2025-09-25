
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class IrradianceNode : LightingNode
    {
        #region Constructors
        /// <inheritdoc/>
        public IrradianceNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node?: Node | null);
        /// </summary>
        public IrradianceNode(Node node) : base(JS.New("THREE.IrradianceNode", node)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// node: Node | null;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        #endregion

        #region Methods

        #endregion
    }
}
