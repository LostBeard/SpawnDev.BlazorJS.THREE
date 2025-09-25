
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PointsMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public PointsMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: PointsMaterialParameters);
        /// </summary>
        public PointsMaterial(PointsMaterialParameters parameters) : base(JS.New("THREE.PointsMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isPointsMaterial: boolean;
        /// </summary>
        public bool IsPointsMaterial { get => JSRef!.Get<bool>("isPointsMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: PointsMaterialParameters): void;
        /// </summary>
        public void SetValues(PointsMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
