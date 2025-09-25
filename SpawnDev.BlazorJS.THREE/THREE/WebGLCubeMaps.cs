
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLCubeMaps : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLCubeMaps(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(renderer: WebGLRenderer);
        /// </summary>
        public WebGLCubeMaps(WebGLRenderer renderer) : base(JS.New("THREE.WebGLCubeMaps", renderer)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// get(texture: any): any;
        /// </summary>
        public object Get(object texture)
        {
            return JSRef!.Call<object>("get", texture);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
