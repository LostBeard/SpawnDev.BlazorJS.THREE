
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BasicLightingModel : LightingModel
    {
        #region Constructors
        /// <inheritdoc/>
        public BasicLightingModel(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public BasicLightingModel() : base(JS.New("THREE.BasicLightingModel")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
