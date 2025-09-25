
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShadowNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public ShadowNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: ShadowNodeMaterialParameters);
        /// </summary>
        public ShadowNodeMaterial(ShadowNodeMaterialParameters parameters) : base(JS.New("THREE.ShadowNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isShadowNodeMaterial: boolean;
        /// </summary>
        public bool IsShadowNodeMaterial { get => JSRef!.Get<bool>("isShadowNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: ShadowNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(ShadowNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupLightingModel(): ShadowMaskModel;
        /// </summary>
        public ShadowMaskModel SetupLightingModel()
        {
            return JSRef!.Call<ShadowMaskModel>("setupLightingModel");
        }
        #endregion
    }
}
