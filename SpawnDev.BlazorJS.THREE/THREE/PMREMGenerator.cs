
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PMREMGenerator : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public PMREMGenerator(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(renderer: WebGLRenderer);
        /// </summary>
        public PMREMGenerator(WebGLRenderer renderer) : base(JS.New("THREE.PMREMGenerator", renderer)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// fromScene(
        ///         scene: Scene,
        ///         sigma?: number,
        ///         near?: number,
        ///         far?: number,
        ///         options?: PMREMGeneratorOptions,
        ///     ): WebGLRenderTarget;
        /// </summary>
        public WebGLRenderTarget FromScene(Scene scene, float sigma, float near, float far, PMREMGeneratorOptions options)
        {
            return JSRef!.Call<WebGLRenderTarget>("fromScene", scene, sigma, near, far, options);
        }
        /// <summary>
        /// fromEquirectangular(equirectangular: Texture, renderTarget?: WebGLRenderTarget | null): WebGLRenderTarget;
        /// </summary>
        public WebGLRenderTarget FromEquirectangular(Texture equirectangular, WebGLRenderTarget renderTarget)
        {
            return JSRef!.Call<WebGLRenderTarget>("fromEquirectangular", equirectangular, renderTarget);
        }
        /// <summary>
        /// fromCubemap(cubemap: CubeTexture, renderTarget?: WebGLRenderTarget | null): WebGLRenderTarget;
        /// </summary>
        public WebGLRenderTarget FromCubemap(CubeTexture cubemap, WebGLRenderTarget renderTarget)
        {
            return JSRef!.Call<WebGLRenderTarget>("fromCubemap", cubemap, renderTarget);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// compileEquirectangularShader(): void;
        /// </summary>
        public void CompileEquirectangularShader()
        {
            JSRef!.CallVoid("compileEquirectangularShader");
        }
        /// <summary>
        /// compileCubemapShader(): void;
        /// </summary>
        public void CompileCubemapShader()
        {
            JSRef!.CallVoid("compileCubemapShader");
        }
        #endregion
    }
}
