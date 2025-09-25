
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshBasicMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshBasicMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshBasicMaterialParameters);
        /// </summary>
        public MeshBasicMaterial(MeshBasicMaterialParameters parameters) : base(JS.New("THREE.MeshBasicMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshBasicMaterial: boolean;
        /// </summary>
        public bool IsMeshBasicMaterial { get => JSRef!.Get<bool>("isMeshBasicMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshBasicMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshBasicMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
