
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshPhysicalNodeMaterial : MeshStandardNodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshPhysicalNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshPhysicalNodeMaterialParameters);
        /// </summary>
        public MeshPhysicalNodeMaterial(MeshPhysicalNodeMaterialParameters parameters) : base(JS.New("THREE.MeshPhysicalNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshPhysicalNodeMaterial: boolean;
        /// </summary>
        public bool IsMeshPhysicalNodeMaterial { get => JSRef!.Get<bool>("isMeshPhysicalNodeMaterial"); }
        /// <summary>
        /// get useAnisotropy(): boolean;
        /// </summary>
        public bool UseAnisotropy { get => JSRef!.Get<bool>("useAnisotropy"); }
        /// <summary>
        /// get useClearcoat(): boolean;
        /// </summary>
        public bool UseClearcoat { get => JSRef!.Get<bool>("useClearcoat"); }
        /// <summary>
        /// get useDispersion(): boolean;
        /// </summary>
        public bool UseDispersion { get => JSRef!.Get<bool>("useDispersion"); }
        /// <summary>
        /// get useIridescence(): boolean;
        /// </summary>
        public bool UseIridescence { get => JSRef!.Get<bool>("useIridescence"); }
        /// <summary>
        /// get useSheen(): boolean;
        /// </summary>
        public bool UseSheen { get => JSRef!.Get<bool>("useSheen"); }
        /// <summary>
        /// get useTransmission(): boolean;
        /// </summary>
        public bool UseTransmission { get => JSRef!.Get<bool>("useTransmission"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshPhysicalNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshPhysicalNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupVariants(builder: NodeBuilder): void;
        /// </summary>
        public void SetupVariants(NodeBuilder builder)
        {
            JSRef!.CallVoid("setupVariants", builder);
        }
        /// <summary>
        /// setupClearcoatNormal(): Node;
        /// </summary>
        public Node SetupClearcoatNormal()
        {
            return JSRef!.Call<Node>("setupClearcoatNormal");
        }
        #endregion
    }
}
