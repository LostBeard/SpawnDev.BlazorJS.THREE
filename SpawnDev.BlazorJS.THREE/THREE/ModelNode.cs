
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ModelNode : Object3DNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ModelNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope: string);
        /// </summary>
        public ModelNode(string scope) : base(JS.New("THREE.ModelNode", scope)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
