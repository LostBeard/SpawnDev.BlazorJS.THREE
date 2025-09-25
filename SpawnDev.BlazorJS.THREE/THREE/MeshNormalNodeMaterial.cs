
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshNormalNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshNormalNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshNormalNodeMaterialParameters);
        /// </summary>
        public MeshNormalNodeMaterial(MeshNormalNodeMaterialParameters parameters) : base(JS.New("THREE.MeshNormalNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshNormalNodeMaterial: boolean;
        /// </summary>
        public bool IsMeshNormalNodeMaterial { get => JSRef!.Get<bool>("isMeshNormalNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshNormalNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshNormalNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupDiffuseColor(): void;
        /// </summary>
        public void SetupDiffuseColor()
        {
            JSRef!.CallVoid("setupDiffuseColor");
        }
        #endregion
    }
}
