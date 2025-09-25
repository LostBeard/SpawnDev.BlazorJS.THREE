
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshPhongNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshPhongNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshPhongNodeMaterialParameters);
        /// </summary>
        public MeshPhongNodeMaterial(MeshPhongNodeMaterialParameters parameters) : base(JS.New("THREE.MeshPhongNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshPhongNodeMaterial: boolean;
        /// </summary>
        public bool IsMeshPhongNodeMaterial { get => JSRef!.Get<bool>("isMeshPhongNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshPhongNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshPhongNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupLightingModel(): PhongLightingModel;
        /// </summary>
        public PhongLightingModel SetupLightingModel()
        {
            return JSRef!.Call<PhongLightingModel>("setupLightingModel");
        }
        /// <summary>
        /// setupEnvironment(builder: NodeBuilder): BasicEnvironmentNode | null;
        /// </summary>
        public BasicEnvironmentNode SetupEnvironment(NodeBuilder builder)
        {
            return JSRef!.Call<BasicEnvironmentNode>("setupEnvironment", builder);
        }
        #endregion
    }
}
