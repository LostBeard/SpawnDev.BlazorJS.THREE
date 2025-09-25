
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SpriteNodeMaterial : NodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public SpriteNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: SpriteNodeMaterialParameters);
        /// </summary>
        public SpriteNodeMaterial(SpriteNodeMaterialParameters parameters) : base(JS.New("THREE.SpriteNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isSpriteMaterial: boolean;
        /// </summary>
        public bool IsSpriteMaterial { get => JSRef!.Get<bool>("isSpriteMaterial"); }
        /// <summary>
        /// readonly isSpriteNodeMaterial: boolean;
        /// </summary>
        public bool IsSpriteNodeMaterial { get => JSRef!.Get<bool>("isSpriteNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: SpriteNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(SpriteNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// setupPositionView(builder: NodeBuilder): Node;
        /// </summary>
        public Node SetupPositionView(NodeBuilder builder)
        {
            return JSRef!.Call<Node>("setupPositionView", builder);
        }
        #endregion
    }
}
