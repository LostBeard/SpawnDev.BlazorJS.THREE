
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLRenderLists : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLRenderLists(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(properties: WebGLProperties);
        /// </summary>
        public WebGLRenderLists(WebGLProperties properties) : base(JS.New("THREE.WebGLRenderLists", properties)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// get(scene: Scene, renderCallDepth: number): WebGLRenderList;
        /// </summary>
        public WebGLRenderList Get(Scene scene, float renderCallDepth)
        {
            return JSRef!.Call<WebGLRenderList>("get", scene, renderCallDepth);
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
