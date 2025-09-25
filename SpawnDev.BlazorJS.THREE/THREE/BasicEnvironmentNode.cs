
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BasicEnvironmentNode : LightingNode
    {
        #region Constructors
        /// <inheritdoc/>
        public BasicEnvironmentNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(envNode?: Node | null);
        /// </summary>
        public BasicEnvironmentNode(Node envNode) : base(JS.New("THREE.BasicEnvironmentNode", envNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// envNode: Node | null;
        /// </summary>
        public Node EnvNode { get => JSRef!.Get<Node>("envNode"); set => JSRef!.Set("envNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
