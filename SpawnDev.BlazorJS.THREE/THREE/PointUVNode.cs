
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PointUVNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public PointUVNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public PointUVNode() : base(JS.New("THREE.PointUVNode")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// isPointUVNode: true;
        /// </summary>
        public bool IsPointUVNode { get => JSRef!.Get<bool>("isPointUVNode"); set => JSRef!.Set("isPointUVNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
