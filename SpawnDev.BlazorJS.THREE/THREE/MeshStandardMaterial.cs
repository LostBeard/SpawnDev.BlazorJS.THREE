
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshStandardMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshStandardMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshStandardMaterialParameters);
        /// </summary>
        public MeshStandardMaterial(MeshStandardMaterialParameters parameters) : base(JS.New("THREE.MeshStandardMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshStandardMaterial: boolean;
        /// </summary>
        public bool IsMeshStandardMaterial { get => JSRef!.Get<bool>("isMeshStandardMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshStandardMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshStandardMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
