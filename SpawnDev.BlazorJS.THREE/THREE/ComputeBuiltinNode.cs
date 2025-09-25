
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ComputeBuiltinNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ComputeBuiltinNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(builtinName: string, nodeType: string);
        /// </summary>
        public ComputeBuiltinNode(string builtinName, string nodeType) : base(JS.New("THREE.ComputeBuiltinNode", builtinName, nodeType)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
