
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshToonNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshToonNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshToonNodeMaterialParameters);
        /// </summary>
        public MeshToonNodeMaterial(MeshToonNodeMaterialParameters parameters) : base(JS.New("THREE.MeshToonNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshToonNodeMaterial: boolean;
        /// </summary>
        public bool IsMeshToonNodeMaterial { get => JSRef!.Get<bool>("isMeshToonNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshToonNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshToonNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupLightingModel(): ToonLightingModel;
        /// </summary>
        public ToonLightingModel SetupLightingModel()
        {
            return JSRef!.Call<ToonLightingModel>("setupLightingModel");
        }
        #endregion
    }
}
