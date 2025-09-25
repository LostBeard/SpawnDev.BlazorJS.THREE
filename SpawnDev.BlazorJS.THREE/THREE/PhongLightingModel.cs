
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PhongLightingModel : BasicLightingModel
    {
        #region Constructors
        /// <inheritdoc/>
        public PhongLightingModel(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(specular?: boolean);
        /// </summary>
        public PhongLightingModel(bool specular) : base(JS.New("THREE.PhongLightingModel", specular)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// specular: boolean;
        /// </summary>
        public bool Specular { get => JSRef!.Get<bool>("specular"); set => JSRef!.Set("specular", value); }
        #endregion

        #region Methods

        #endregion
    }
}
