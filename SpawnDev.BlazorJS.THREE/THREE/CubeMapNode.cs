
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CubeMapNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public CubeMapNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(envNode: Node);
        /// </summary>
        public CubeMapNode(Node envNode) : base(JS.New("THREE.CubeMapNode", envNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// envNode: Node;
        /// </summary>
        public Node EnvNode { get => JSRef!.Get<Node>("envNode"); set => JSRef!.Set("envNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
