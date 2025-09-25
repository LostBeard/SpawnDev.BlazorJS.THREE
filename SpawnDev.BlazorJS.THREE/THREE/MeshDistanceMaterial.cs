
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshDistanceMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshDistanceMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshDistanceMaterialParameters);
        /// </summary>
        public MeshDistanceMaterial(MeshDistanceMaterialParameters parameters) : base(JS.New("THREE.MeshDistanceMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshDistanceMaterial: boolean;
        /// </summary>
        public bool IsMeshDistanceMaterial { get => JSRef!.Get<bool>("isMeshDistanceMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshDistanceMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshDistanceMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
