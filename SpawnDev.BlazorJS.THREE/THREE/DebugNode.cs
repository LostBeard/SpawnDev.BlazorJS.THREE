
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DebugNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public DebugNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, callback?: ((code: string) => void) | null);
        /// </summary>
        public DebugNode(Node node, Callback callback, string code) : base(JS.New("THREE.DebugNode", node, callback, code)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
