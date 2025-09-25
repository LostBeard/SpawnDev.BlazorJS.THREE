
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShadowBaseNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ShadowBaseNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light: Light);
        /// </summary>
        public ShadowBaseNode(Light light) : base(JS.New("THREE.ShadowBaseNode", light)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isShadowBasedNode: true;
        /// </summary>
        public bool IsShadowBasedNode { get => JSRef!.Get<bool>("isShadowBasedNode"); }
        /// <summary>
        /// light: Light;
        /// </summary>
        public Light Light { get => JSRef!.Get<Light>("light"); set => JSRef!.Set("light", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setupShadowPosition(builder: NodeBuilder): void;
        /// </summary>
        public void SetupShadowPosition(NodeBuilder builder)
        {
            JSRef!.CallVoid("setupShadowPosition", builder);
        }
        #endregion
    }
}
