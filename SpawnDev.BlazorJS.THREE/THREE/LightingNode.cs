
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LightingNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public LightingNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public LightingNode() : base(JS.New("THREE.LightingNode")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLightingNode: true;
        /// </summary>
        public bool IsLightingNode { get => JSRef!.Get<bool>("isLightingNode"); }
        #endregion

        #region Methods

        #endregion
    }
}
