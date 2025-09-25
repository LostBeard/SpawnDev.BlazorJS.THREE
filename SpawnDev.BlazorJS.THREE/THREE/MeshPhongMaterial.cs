
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshPhongMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshPhongMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshPhongMaterialParameters);
        /// </summary>
        public MeshPhongMaterial(MeshPhongMaterialParameters parameters) : base(JS.New("THREE.MeshPhongMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshPhongMaterial: boolean;
        /// </summary>
        public bool IsMeshPhongMaterial { get => JSRef!.Get<bool>("isMeshPhongMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshPhongMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshPhongMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
