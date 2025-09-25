
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Line2NodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public Line2NodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: Line2NodeMaterialParameters);
        /// </summary>
        public Line2NodeMaterial(Line2NodeMaterialParameters parameters) : base(JS.New("THREE.Line2NodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLine2NodeMaterial: boolean;
        /// </summary>
        public bool IsLine2NodeMaterial { get => JSRef!.Get<bool>("isLine2NodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: Line2NodeMaterialParameters): void;
        /// </summary>
        public void SetValues(Line2NodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
