
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshPhysicalMaterial : MeshStandardMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshPhysicalMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshPhysicalMaterialParameters);
        /// </summary>
        public MeshPhysicalMaterial(MeshPhysicalMaterialParameters parameters) : base(JS.New("THREE.MeshPhysicalMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshPhysicalMaterial: boolean;
        /// </summary>
        public bool IsMeshPhysicalMaterial { get => JSRef!.Get<bool>("isMeshPhysicalMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshPhysicalMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshPhysicalMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
