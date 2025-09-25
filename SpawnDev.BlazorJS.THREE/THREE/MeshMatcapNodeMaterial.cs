
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MeshMatcapNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public MeshMatcapNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: MeshMatcapNodeMaterialParameters);
        /// </summary>
        public MeshMatcapNodeMaterial(MeshMatcapNodeMaterialParameters parameters) : base(JS.New("THREE.MeshMatcapNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMeshMatcapNodeMaterial: boolean;
        /// </summary>
        public bool IsMeshMatcapNodeMaterial { get => JSRef!.Get<bool>("isMeshMatcapNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: MeshMatcapNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(MeshMatcapNodeMaterialParameters values)
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
        #endregion
    }
}
