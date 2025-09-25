
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshDepthMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshDepthMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshDepthMaterialParameters);
        /// </summary>
        public MeshDepthMaterial(MeshDepthMaterialParameters parameters) : base(JS.New("THREE.MeshDepthMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshDepthMaterial: boolean;
        /// </summary>
        public bool IsMeshDepthMaterial { get => JSRef!.Get<bool>("isMeshDepthMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshDepthMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshDepthMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
