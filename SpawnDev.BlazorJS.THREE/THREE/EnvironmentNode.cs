
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class EnvironmentNode : LightingNode
    {
        #region Constructors
        /// <inheritdoc/>
        public EnvironmentNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(envNode?: Node | null);
        /// </summary>
        public EnvironmentNode(Node envNode) : base(JS.New("THREE.EnvironmentNode", envNode)) { }
        
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
