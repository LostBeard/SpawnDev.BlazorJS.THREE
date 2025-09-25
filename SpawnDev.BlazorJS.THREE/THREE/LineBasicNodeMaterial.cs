
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LineBasicNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public LineBasicNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: LineBasicNodeMaterialParameters);
        /// </summary>
        public LineBasicNodeMaterial(LineBasicNodeMaterialParameters parameters) : base(JS.New("THREE.LineBasicNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLineBasicNodeMaterial: boolean;
        /// </summary>
        public bool IsLineBasicNodeMaterial { get => JSRef!.Get<bool>("isLineBasicNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: LineBasicNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(LineBasicNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
