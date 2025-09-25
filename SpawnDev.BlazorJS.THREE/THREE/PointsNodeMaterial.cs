
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PointsNodeMaterial : SpriteNodeMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public PointsNodeMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: PointsNodeMaterialParameters);
        /// </summary>
        public PointsNodeMaterial(PointsNodeMaterialParameters parameters) : base(JS.New("THREE.PointsNodeMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isPointsNodeMaterial: boolean;
        /// </summary>
        public bool IsPointsNodeMaterial { get => JSRef!.Get<bool>("isPointsNodeMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: PointsNodeMaterialParameters): void;
        /// </summary>
        public void SetValues(PointsNodeMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
