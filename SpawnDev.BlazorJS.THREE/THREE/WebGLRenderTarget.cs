
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLRenderTarget : RenderTarget
    {
        /// <inheritdoc/>
        public WebGLRenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class WebGLRenderTarget<TTexture> : RenderTarget<TTexture>
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLRenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number, options?: RenderTargetOptions);
        /// </summary>
        public WebGLRenderTarget(float width, float height, RenderTargetOptions options) : base(JS.New("THREE.WebGLRenderTarget", width, height, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isWebGLRenderTarget: true;
        /// </summary>
        public bool IsWebGLRenderTarget { get => JSRef!.Get<bool>("isWebGLRenderTarget"); }
        #endregion

        #region Methods

        #endregion
    }
}
