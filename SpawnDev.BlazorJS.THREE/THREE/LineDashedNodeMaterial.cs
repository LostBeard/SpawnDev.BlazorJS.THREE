
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LineDashedNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public LineDashedNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: LineDashedNodeMaterialParameters);
        /// </summary>
        public LineDashedNodeMaterial(LineDashedNodeMaterialParameters parameters) : base(JS.New("THREE.LineDashedNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLineDashedNodeMaterial: boolean;
        /// </summary>
        public bool IsLineDashedNodeMaterial { get => JSRef!.Get<bool>("isLineDashedNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: LineDashedNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(LineDashedNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
