
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshStandardNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshStandardNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshStandardNodeMaterialParameters);
        /// </summary>
        public MeshStandardNodeMaterial(MeshStandardNodeMaterialParameters parameters) : base(JS.New("THREE.MeshStandardNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshStandardNodeMaterial: boolean;
        /// </summary>
        public bool IsMeshStandardNodeMaterial { get => JSRef!.Get<bool>("isMeshStandardNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshStandardNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshStandardNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupSpecular(): void;
        /// </summary>
        public void SetupSpecular()
        {
            JSRef!.CallVoid("setupSpecular");
        }
        /// <summary>
        /// setupLightingModel(): PhysicalLightingModel;
        /// </summary>
        public PhysicalLightingModel SetupLightingModel()
        {
            return JSRef!.Call<PhysicalLightingModel>("setupLightingModel");
        }
        /// <summary>
        /// setupEnvironment(builder: NodeBuilder): EnvironmentNode | null;
        /// </summary>
        public EnvironmentNode SetupEnvironment(NodeBuilder builder)
        {
            return JSRef!.Call<EnvironmentNode>("setupEnvironment", builder);
        }
        #endregion
    }
}
