
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LineDashedMaterial : LineBasicMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public LineDashedMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: LineDashedMaterialParameters);
        /// </summary>
        public LineDashedMaterial(LineDashedMaterialParameters parameters) : base(JS.New("THREE.LineDashedMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLineDashedMaterial: boolean;
        /// </summary>
        public bool IsLineDashedMaterial { get => JSRef!.Get<bool>("isLineDashedMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: LineDashedMaterialParameters): void;
        /// </summary>
        public void SetValues(LineDashedMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
