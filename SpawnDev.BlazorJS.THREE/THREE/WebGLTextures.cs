
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLTextures : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLTextures(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         gl: WebGLRenderingContext,
        ///         extensions: WebGLExtensions,
        ///         state: WebGLState,
        ///         properties: WebGLProperties,
        ///         capabilities: WebGLCapabilities,
        ///         utils: WebGLUtils,
        ///         info: WebGLInfo,
        ///     );
        /// </summary>
        public WebGLTextures(WebGLRenderingContext gl, WebGLExtensions extensions, WebGLState state, WebGLProperties properties, WebGLCapabilities capabilities, WebGLUtils utils, WebGLInfo info) : base(JS.New("THREE.WebGLTextures", gl, extensions, state, properties, capabilities, utils, info)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// updateRenderTargetMipmap(renderTarget: any): void;
        /// </summary>
        public void UpdateRenderTargetMipmap(object renderTarget)
        {
            JSRef!.CallVoid("updateRenderTargetMipmap", renderTarget);
        }
        /// <summary>
        /// updateMultisampleRenderTarget(renderTarget: any): void;
        /// </summary>
        public void UpdateMultisampleRenderTarget(object renderTarget)
        {
            JSRef!.CallVoid("updateMultisampleRenderTarget", renderTarget);
        }
        /// <summary>
        /// setupRenderTarget(renderTarget: any): void;
        /// </summary>
        public void SetupRenderTarget(object renderTarget)
        {
            JSRef!.CallVoid("setupRenderTarget", renderTarget);
        }
        /// <summary>
        /// setTextureCube(texture: any, slot: number): void;
        /// </summary>
        public void SetTextureCube(object texture, float slot)
        {
            JSRef!.CallVoid("setTextureCube", texture, slot);
        }
        /// <summary>
        /// setTexture3D(texture: any, slot: number): void;
        /// </summary>
        public void SetTexture3D(object texture, float slot)
        {
            JSRef!.CallVoid("setTexture3D", texture, slot);
        }
        /// <summary>
        /// setTexture2DArray(texture: any, slot: number): void;
        /// </summary>
        public void SetTexture2DArray(object texture, float slot)
        {
            JSRef!.CallVoid("setTexture2DArray", texture, slot);
        }
        /// <summary>
        /// setTexture2D(texture: any, slot: number): void;
        /// </summary>
        public void SetTexture2D(object texture, float slot)
        {
            JSRef!.CallVoid("setTexture2D", texture, slot);
        }
        /// <summary>
        /// safeSetTextureCube(texture: any, slot: number): void;
        /// </summary>
        public void SafeSetTextureCube(object texture, float slot)
        {
            JSRef!.CallVoid("safeSetTextureCube", texture, slot);
        }
        /// <summary>
        /// safeSetTexture2D(texture: any, slot: number): void;
        /// </summary>
        public void SafeSetTexture2D(object texture, float slot)
        {
            JSRef!.CallVoid("safeSetTexture2D", texture, slot);
        }
        /// <summary>
        /// resetTextureUnits(): void;
        /// </summary>
        public void ResetTextureUnits()
        {
            JSRef!.CallVoid("resetTextureUnits");
        }
        /// <summary>
        /// allocateTextureUnit(): void;
        /// </summary>
        public void AllocateTextureUnit()
        {
            JSRef!.CallVoid("allocateTextureUnit");
        }
        #endregion
    }
}
