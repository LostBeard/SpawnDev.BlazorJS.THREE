
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShadowMaskModel : LightingModel
    {
        #region Constructors
        /// <inheritdoc/>
        public ShadowMaskModel(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public ShadowMaskModel() : base(JS.New("THREE.ShadowMaskModel")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// shadowNode: ShaderNodeObject<VarNode>;
        /// </summary>
        public ShaderNodeObject<VarNode> ShadowNode { get => JSRef!.Get<ShaderNodeObject<VarNode>>("shadowNode"); set => JSRef!.Set("shadowNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
