
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class VolumeNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public VolumeNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: VolumeNodeMaterialParameters);
        /// </summary>
        public VolumeNodeMaterial(VolumeNodeMaterialParameters parameters) : base(JS.New("THREE.VolumeNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isVolumeNodeMaterial: boolean;
        /// </summary>
        public bool IsVolumeNodeMaterial { get => JSRef!.Get<bool>("isVolumeNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: VolumeNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(VolumeNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupLightingModel(): VolumetricLightingModel;
        /// </summary>
        public VolumetricLightingModel SetupLightingModel()
        {
            return JSRef!.Call<VolumetricLightingModel>("setupLightingModel");
        }
        #endregion
    }
}
