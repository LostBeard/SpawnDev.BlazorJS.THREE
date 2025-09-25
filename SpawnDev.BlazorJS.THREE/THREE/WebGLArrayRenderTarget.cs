
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLArrayRenderTarget : WebGLRenderTarget
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLArrayRenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number, depth?: number, options?: RenderTargetOptions);
        /// </summary>
        public WebGLArrayRenderTarget(float width, float height, float depth, RenderTargetOptions options) : base(JS.New("THREE.WebGLArrayRenderTarget", width, height, depth, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isWebGLArrayRenderTarget: true;
        /// </summary>
        public bool IsWebGLArrayRenderTarget { get => JSRef!.Get<bool>("isWebGLArrayRenderTarget"); }
        /// <summary>
        /// get texture(): DataArrayTexture;
        /// </summary>
        public DataArrayTexture Texture { get => JSRef!.Get<DataArrayTexture>("texture"); set => JSRef!.Set("texture", value); }
        /// <summary>
        /// textures: DataArrayTexture[];
        /// </summary>
        public Array<DataArrayTexture> Textures { get => JSRef!.Get<Array<DataArrayTexture>>("textures"); set => JSRef!.Set("textures", value); }
        #endregion

        #region Methods

        #endregion
    }
}
