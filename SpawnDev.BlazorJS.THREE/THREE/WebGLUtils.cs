
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLUtils : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLUtils(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         gl: WebGLRenderingContext | WebGL2RenderingContext,
        ///         extensions: WebGLExtensions,
        ///     );
        /// </summary>
        public WebGLUtils(Union<WebGLRenderingContext, WebGL2RenderingContext> gl, WebGLExtensions extensions) : base(JS.New("THREE.WebGLUtils", gl, extensions)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// convert(p: PixelFormat | CompressedPixelFormat | TextureDataType, colorSpace?: string): number | null;
        /// </summary>
        public float Convert(Union<PixelFormat, CompressedPixelFormat, TextureDataType> p, string colorSpace)
        {
            return JSRef!.Call<float>("convert", p, colorSpace);
        }
        #endregion
    }
}
