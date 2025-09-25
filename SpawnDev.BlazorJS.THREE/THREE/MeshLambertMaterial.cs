
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshLambertMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshLambertMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshLambertMaterialParameters);
        /// </summary>
        public MeshLambertMaterial(MeshLambertMaterialParameters parameters) : base(JS.New("THREE.MeshLambertMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshLambertMaterial: boolean;
        /// </summary>
        public bool IsMeshLambertMaterial { get => JSRef!.Get<bool>("isMeshLambertMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshLambertMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshLambertMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
