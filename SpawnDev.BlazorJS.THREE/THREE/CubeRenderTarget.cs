
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CubeRenderTarget : WebGLCubeRenderTarget
    {
        #region Constructors
        /// <inheritdoc/>
        public CubeRenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(size?: number, options?: RenderTargetOptions);
        /// </summary>
        public CubeRenderTarget(float size, RenderTargetOptions options) : base(JS.New("THREE.CubeRenderTarget", size, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isCubeRenderTarget: true;
        /// </summary>
        public bool IsCubeRenderTarget { get => JSRef!.Get<bool>("isCubeRenderTarget"); }
        #endregion

        #region Methods
        /// <summary>
        /// fromEquirectangularTexture(renderer: WebGLRenderer, texture: Texture): this;
        /// </summary>
        public CubeRenderTarget FromEquirectangularTexture(WebGLRenderer renderer, Texture texture)
        {
            return JSRef!.Call<CubeRenderTarget>("fromEquirectangularTexture", renderer, texture);
        }
        #endregion
    }
}
