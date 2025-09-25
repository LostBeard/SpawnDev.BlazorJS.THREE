
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshLambertNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshLambertNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshLambertNodeMaterialParameters);
        /// </summary>
        public MeshLambertNodeMaterial(MeshLambertNodeMaterialParameters parameters) : base(JS.New("THREE.MeshLambertNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshLambertNodeMaterial: boolean;
        /// </summary>
        public bool IsMeshLambertNodeMaterial { get => JSRef!.Get<bool>("isMeshLambertNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshLambertNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshLambertNodeMaterialParameters values)
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
