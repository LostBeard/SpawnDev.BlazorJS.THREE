
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShadowMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public ShadowMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: ShadowMaterialParameters);
        /// </summary>
        public ShadowMaterial(ShadowMaterialParameters parameters) : base(JS.New("THREE.ShadowMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isShadowMaterial: boolean;
        /// </summary>
        public bool IsShadowMaterial { get => JSRef!.Get<bool>("isShadowMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: ShadowMaterialParameters): void;
        /// </summary>
        public void SetValues(ShadowMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
