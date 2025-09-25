
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class UniformArrayElementNode : ArrayElementNode
    {
        #region Constructors
        /// <inheritdoc/>
        public UniformArrayElementNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(arrayBuffer: Node, indexNode: Node);
        /// </summary>
        public UniformArrayElementNode(Node arrayBuffer, Node indexNode) : base(JS.New("THREE.UniformArrayElementNode", arrayBuffer, indexNode)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
