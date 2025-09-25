
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLCubeRenderTarget : WebGLRenderTarget
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLCubeRenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(size?: number, options?: RenderTargetOptions);
        /// </summary>
        public WebGLCubeRenderTarget(float size, RenderTargetOptions options) : base(JS.New("THREE.WebGLCubeRenderTarget", size, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get texture(): CubeTexture;
        /// </summary>
        public CubeTexture Texture { get => JSRef!.Get<CubeTexture>("texture"); set => JSRef!.Set("texture", value); }
        /// <summary>
        /// textures: CubeTexture[];
        /// </summary>
        public Array<CubeTexture> Textures { get => JSRef!.Get<Array<CubeTexture>>("textures"); set => JSRef!.Set("textures", value); }
        #endregion

        #region Methods
        /// <summary>
        /// fromEquirectangularTexture(renderer: WebGLRenderer, texture: Texture): this;
        /// </summary>
        public WebGLCubeRenderTarget FromEquirectangularTexture(WebGLRenderer renderer, Texture texture)
        {
            return JSRef!.Call<WebGLCubeRenderTarget>("fromEquirectangularTexture", renderer, texture);
        }
        /// <summary>
        /// clear(renderer: WebGLRenderer, color: boolean, depth: boolean, stencil: boolean): void;
        /// </summary>
        public void Clear(WebGLRenderer renderer, bool color, bool depth, bool stencil)
        {
            JSRef!.CallVoid("clear", renderer, color, depth, stencil);
        }
        #endregion
    }
}
