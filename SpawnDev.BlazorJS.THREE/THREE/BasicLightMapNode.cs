
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BasicLightMapNode : LightingNode
    {
        #region Constructors
        /// <inheritdoc/>
        public BasicLightMapNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(lightMapNode?: Node | null);
        /// </summary>
        public BasicLightMapNode(Node lightMapNode) : base(JS.New("THREE.BasicLightMapNode", lightMapNode)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
