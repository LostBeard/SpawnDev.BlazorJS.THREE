
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class HemisphereLightNode : AnalyticLightNode<HemisphereLight>
    {
        #region Constructors
        /// <inheritdoc/>
        public HemisphereLightNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light?: HemisphereLight | null);
        /// </summary>
        public HemisphereLightNode(HemisphereLight light) : base(JS.New("THREE.HemisphereLightNode", light)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// groundColorNode: Node;
        /// </summary>
        public Node GroundColorNode { get => JSRef!.Get<Node>("groundColorNode"); set => JSRef!.Set("groundColorNode", value); }
        /// <summary>
        /// lightDirectionNode: Node;
        /// </summary>
        public Node LightDirectionNode { get => JSRef!.Get<Node>("lightDirectionNode"); set => JSRef!.Set("lightDirectionNode", value); }
        /// <summary>
        /// lightPositionNode: Object3DNode;
        /// </summary>
        public Object3DNode LightPositionNode { get => JSRef!.Get<Object3DNode>("lightPositionNode"); set => JSRef!.Set("lightPositionNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
