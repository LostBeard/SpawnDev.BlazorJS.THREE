
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class FrontFacingNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public FrontFacingNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public FrontFacingNode() : base(JS.New("THREE.FrontFacingNode")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// isFrontFacingNode: true;
        /// </summary>
        public bool IsFrontFacingNode { get => JSRef!.Get<bool>("isFrontFacingNode"); set => JSRef!.Set("isFrontFacingNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
