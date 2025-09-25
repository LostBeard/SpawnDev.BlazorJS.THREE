
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LineBasicMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public LineBasicMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: LineBasicMaterialParameters);
        /// </summary>
        public LineBasicMaterial(LineBasicMaterialParameters parameters) : base(JS.New("THREE.LineBasicMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLineBasicMaterial: boolean;
        /// </summary>
        public bool IsLineBasicMaterial { get => JSRef!.Get<bool>("isLineBasicMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: LineBasicMaterialParameters): void;
        /// </summary>
        public void SetValues(LineBasicMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
