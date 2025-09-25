
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshToonMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshToonMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshToonMaterialParameters);
        /// </summary>
        public MeshToonMaterial(MeshToonMaterialParameters parameters) : base(JS.New("THREE.MeshToonMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshToonMaterial: boolean;
        /// </summary>
        public bool IsMeshToonMaterial { get => JSRef!.Get<bool>("isMeshToonMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshToonMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshToonMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
