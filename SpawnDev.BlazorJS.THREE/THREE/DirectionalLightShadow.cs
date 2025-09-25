
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DirectionalLightShadow : LightShadow<OrthographicCamera>
    {
        #region Constructors
        /// <inheritdoc/>
        public DirectionalLightShadow(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public DirectionalLightShadow() : base(JS.New("THREE.DirectionalLightShadow")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// camera: OrthographicCamera;
        /// </summary>
        public OrthographicCamera Camera { get => JSRef!.Get<OrthographicCamera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// readonly isDirectionalLightShadow: true;
        /// </summary>
        public bool IsDirectionalLightShadow { get => JSRef!.Get<bool>("isDirectionalLightShadow"); }
        #endregion

        #region Methods

        #endregion
    }
}
