
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLLights : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLLights(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(extensions: WebGLExtensions);
        /// </summary>
        public WebGLLights(WebGLExtensions extensions) : base(JS.New("THREE.WebGLLights", extensions)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// state: WebGLLightsState;
        /// </summary>
        public WebGLLightsState State { get => JSRef!.Get<WebGLLightsState>("state"); set => JSRef!.Set("state", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setupView(lights: any, camera: any): void;
        /// </summary>
        public void SetupView(object lights, object camera)
        {
            JSRef!.CallVoid("setupView", lights, camera);
        }
        /// <summary>
        /// setup(lights: any): void;
        /// </summary>
        public void Setup(object lights)
        {
            JSRef!.CallVoid("setup", lights);
        }
        /// <summary>
        /// get(light: any): any;
        /// </summary>
        public object Get(object light)
        {
            return JSRef!.Call<object>("get", light);
        }
        #endregion
    }
}
