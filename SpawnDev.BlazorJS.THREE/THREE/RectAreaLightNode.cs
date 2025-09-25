
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RectAreaLightNode : AnalyticLightNode<RectAreaLight>
    {
        #region Constructors
        /// <inheritdoc/>
        public RectAreaLightNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light?: RectAreaLight | null);
        /// </summary>
        public RectAreaLightNode(RectAreaLight light) : base(JS.New("THREE.RectAreaLightNode", light)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// halfHeight: Node;
        /// </summary>
        public Node HalfHeight { get => JSRef!.Get<Node>("halfHeight"); set => JSRef!.Set("halfHeight", value); }
        /// <summary>
        /// halfWidth: Node;
        /// </summary>
        public Node HalfWidth { get => JSRef!.Get<Node>("halfWidth"); set => JSRef!.Set("halfWidth", value); }
        #endregion

        #region Methods
        /// <summary>
        /// static setLTC(ltc: RectAreaLightTexturesLib): void;
        /// </summary>
        public void SetLTC(RectAreaLightTexturesLib ltc)
        {
            JSRef!.CallVoid("setLTC", ltc);
        }
        #endregion
    }
}
