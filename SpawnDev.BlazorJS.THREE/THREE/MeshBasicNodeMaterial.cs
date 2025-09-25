
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshBasicNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshBasicNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshBasicNodeMaterialParameters);
        /// </summary>
        public MeshBasicNodeMaterial(MeshBasicNodeMaterialParameters parameters) : base(JS.New("THREE.MeshBasicNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshBasicNodeMaterial: boolean;
        /// </summary>
        public bool IsMeshBasicNodeMaterial { get => JSRef!.Get<bool>("isMeshBasicNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshBasicNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshBasicNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupLightingModel(): BasicLightingModel;
        /// </summary>
        public BasicLightingModel SetupLightingModel()
        {
            return JSRef!.Call<BasicLightingModel>("setupLightingModel");
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
