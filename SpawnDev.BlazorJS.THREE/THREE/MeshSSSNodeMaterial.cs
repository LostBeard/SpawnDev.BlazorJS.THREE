
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshSSSNodeMaterial : MeshPhysicalNodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshSSSNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshSSSNodeMaterialParameters);
        /// </summary>
        public MeshSSSNodeMaterial(MeshSSSNodeMaterialParameters parameters) : base(JS.New("THREE.MeshSSSNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get useSSS(): boolean;
        /// </summary>
        public bool UseSSS { get => JSRef!.Get<bool>("useSSS"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshSSSNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshSSSNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupLightingModel(): SSSLightingModel;
        /// </summary>
        public SSSLightingModel SetupLightingModel()
        {
            return JSRef!.Call<SSSLightingModel>("setupLightingModel");
        }
        #endregion
    }
}
