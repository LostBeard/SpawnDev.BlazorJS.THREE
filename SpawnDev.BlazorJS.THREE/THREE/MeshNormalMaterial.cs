
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshNormalMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshNormalMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshNormalMaterialParameters);
        /// </summary>
        public MeshNormalMaterial(MeshNormalMaterialParameters? parameters = null) : base(parameters == null ? JS.New("THREE.MeshNormalMaterial") : JS.New("THREE.MeshNormalMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshNormalMaterial: boolean;
        /// </summary>
        public bool IsMeshNormalMaterial { get => JSRef!.Get<bool>("isMeshNormalMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshNormalMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshNormalMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
