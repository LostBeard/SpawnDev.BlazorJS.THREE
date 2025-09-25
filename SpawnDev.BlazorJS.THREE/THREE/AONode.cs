
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AONode : LightingNode
    {
        #region Constructors
        /// <inheritdoc/>
        public AONode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(aoNode?: Node | null);
        /// </summary>
        public AONode(Node aoNode) : base(JS.New("THREE.AONode", aoNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// aoNode: Node | null;
        /// </summary>
        public Node AoNode { get => JSRef!.Get<Node>("aoNode"); set => JSRef!.Set("aoNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
