
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLObjects : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLObjects(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(gl: WebGLRenderingContext, geometries: any, attributes: any, info: any);
        /// </summary>
        public WebGLObjects(WebGLRenderingContext gl, object geometries, object attributes, object info) : base(JS.New("THREE.WebGLObjects", gl, geometries, attributes, info)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// update(object: any): any;
        /// </summary>
        public object Update(object obj)
        {
            return JSRef!.Call<object>("update", obj);
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
