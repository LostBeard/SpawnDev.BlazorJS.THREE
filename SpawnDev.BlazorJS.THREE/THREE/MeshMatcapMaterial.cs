
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshMatcapMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshMatcapMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshMatcapMaterialParameters);
        /// </summary>
        public MeshMatcapMaterial(MeshMatcapMaterialParameters parameters) : base(JS.New("THREE.MeshMatcapMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshMatcapMaterial: boolean;
        /// </summary>
        public bool IsMeshMatcapMaterial { get => JSRef!.Get<bool>("isMeshMatcapMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshMatcapMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshMatcapMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
