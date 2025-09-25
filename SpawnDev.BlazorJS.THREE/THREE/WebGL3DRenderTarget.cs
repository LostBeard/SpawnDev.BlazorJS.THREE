
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGL3DRenderTarget : WebGLRenderTarget
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGL3DRenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number, depth?: number, options?: RenderTargetOptions);
        /// </summary>
        public WebGL3DRenderTarget(float width, float height, float depth, RenderTargetOptions options) : base(JS.New("THREE.WebGL3DRenderTarget", width, height, depth, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isWebGL3DRenderTarget: true;
        /// </summary>
        public bool IsWebGL3DRenderTarget { get => JSRef!.Get<bool>("isWebGL3DRenderTarget"); }
        /// <summary>
        /// get texture(): Data3DTexture;
        /// </summary>
        public Data3DTexture Texture { get => JSRef!.Get<Data3DTexture>("texture"); set => JSRef!.Set("texture", value); }
        /// <summary>
        /// textures: Data3DTexture[];
        /// </summary>
        public Array<Data3DTexture> Textures { get => JSRef!.Get<Array<Data3DTexture>>("textures"); set => JSRef!.Set("textures", value); }
        #endregion

        #region Methods

        #endregion
    }
}
