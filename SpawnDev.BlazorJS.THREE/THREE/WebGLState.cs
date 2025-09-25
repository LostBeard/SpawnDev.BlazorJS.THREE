
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLState : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLState(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(gl: WebGLRenderingContext, extensions: WebGLExtensions);
        /// </summary>
        public WebGLState(WebGLRenderingContext gl, WebGLExtensions extensions) : base(JS.New("THREE.WebGLState", gl, extensions)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// buffers: {
                ///         color: WebGLColorBuffer;
                ///         depth: WebGLDepthBuffer;
                ///         stencil: WebGLStencilBuffer;
                ///     };
        /// </summary>
        public object Buffers { get => JSRef!.Get<object>("buffers"); set => JSRef!.Set("buffers", value); }
        #endregion

        #region Methods
        /// <summary>
        /// viewport(viewport: Vector4): void;
        /// </summary>
        public void Viewport(Vector4 viewport)
        {
            JSRef!.CallVoid("viewport", viewport);
        }
        /// <summary>
        /// useProgram(program: any): boolean;
        /// </summary>
        public bool UseProgram(object program)
        {
            return JSRef!.Call<bool>("useProgram", program);
        }
        /// <summary>
        /// unbindTexture(): void;
        /// </summary>
        public void UnbindTexture()
        {
            JSRef!.CallVoid("unbindTexture");
        }
        /// <summary>
        /// texImage3D(
        ///         target: number,
        ///         level: number,
        ///         internalformat: number,
        ///         width: number,
        ///         height: number,
        ///         depth: number,
        ///         border: number,
        ///         format: number,
        ///         type: number,
        ///         pixels: any,
        ///     ): void;
        /// </summary>
        public void TexImage3D(float target, float level, float internalformat, float width, float height, float depth, float border, float format, float type, object pixels)
        {
            JSRef!.CallVoid("texImage3D", target, level, internalformat, width, height, depth, border, format, type, pixels);
        }
        /// <summary>
        /// texImage2D(
        ///         target: number,
        ///         level: number,
        ///         internalformat: number,
        ///         width: number,
        ///         height: number,
        ///         border: number,
        ///         format: number,
        ///         type: number,
        ///         pixels: ArrayBufferView | null,
        ///     ): void;
        /// </summary>
        public void TexImage2D(float target, float level, float internalformat, float width, float height, float border, float format, float type, ArrayBufferView pixels)
        {
            JSRef!.CallVoid("texImage2D", target, level, internalformat, width, height, border, format, type, pixels);
        }
        /// <summary>
        /// texImage2D(target: number, level: number, internalformat: number, format: number, type: number, source: any): void;
        /// </summary>
        public void TexImage2D(float target, float level, float internalformat, float format, float type, object source)
        {
            JSRef!.CallVoid("texImage2D", target, level, internalformat, format, type, source);
        }
        /// <summary>
        /// setScissorTest(scissorTest: boolean): void;
        /// </summary>
        public void SetScissorTest(bool scissorTest)
        {
            JSRef!.CallVoid("setScissorTest", scissorTest);
        }
        /// <summary>
        /// setPolygonOffset(polygonoffset: boolean, factor?: number, units?: number): void;
        /// </summary>
        public void SetPolygonOffset(bool polygonoffset, float factor, float units)
        {
            JSRef!.CallVoid("setPolygonOffset", polygonoffset, factor, units);
        }
        /// <summary>
        /// setMaterial(material: Material, frontFaceCW: boolean, hardwareClippingPlanes: number): void;
        /// </summary>
        public void SetMaterial(Material material, bool frontFaceCW, float hardwareClippingPlanes)
        {
            JSRef!.CallVoid("setMaterial", material, frontFaceCW, hardwareClippingPlanes);
        }
        /// <summary>
        /// setLineWidth(width: number): void;
        /// </summary>
        public void SetLineWidth(float width)
        {
            JSRef!.CallVoid("setLineWidth", width);
        }
        /// <summary>
        /// setFlipSided(flipSided: boolean): void;
        /// </summary>
        public void SetFlipSided(bool flipSided)
        {
            JSRef!.CallVoid("setFlipSided", flipSided);
        }
        /// <summary>
        /// setCullFace(cullFace: CullFace): void;
        /// </summary>
        public void SetCullFace(CullFace cullFace)
        {
            JSRef!.CallVoid("setCullFace", cullFace);
        }
        /// <summary>
        /// setBlending(
        ///         blending: Blending,
        ///         blendEquation?: BlendingEquation,
        ///         blendSrc?: BlendingSrcFactor,
        ///         blendDst?: BlendingDstFactor,
        ///         blendEquationAlpha?: BlendingEquation,
        ///         blendSrcAlpha?: BlendingSrcFactor,
        ///         blendDstAlpha?: BlendingDstFactor,
        ///         premultiplyAlpha?: boolean,
        ///     ): void;
        /// </summary>
        public void SetBlending(Blending blending, BlendingEquation blendEquation, BlendingSrcFactor blendSrc, BlendingDstFactor blendDst, BlendingEquation blendEquationAlpha, BlendingSrcFactor blendSrcAlpha, BlendingDstFactor blendDstAlpha, bool premultiplyAlpha)
        {
            JSRef!.CallVoid("setBlending", blending, blendEquation, blendSrc, blendDst, blendEquationAlpha, blendSrcAlpha, blendDstAlpha, premultiplyAlpha);
        }
        /// <summary>
        /// scissor(scissor: Vector4): void;
        /// </summary>
        public void Scissor(Vector4 scissor)
        {
            JSRef!.CallVoid("scissor", scissor);
        }
        /// <summary>
        /// reset(): void;
        /// </summary>
        public void Reset()
        {
            JSRef!.CallVoid("reset");
        }
        /// <summary>
        /// enable(id: number): void;
        /// </summary>
        public void Enable(float id)
        {
            JSRef!.CallVoid("enable", id);
        }
        /// <summary>
        /// drawBuffers(renderTarget: WebGLRenderTarget | null, framebuffer: WebGLFramebuffer | null): void;
        /// </summary>
        public void DrawBuffers(WebGLRenderTarget renderTarget, WebGLFramebuffer framebuffer)
        {
            JSRef!.CallVoid("drawBuffers", renderTarget, framebuffer);
        }
        /// <summary>
        /// disable(id: number): void;
        /// </summary>
        public void Disable(float id)
        {
            JSRef!.CallVoid("disable", id);
        }
        /// <summary>
        /// compressedTexImage2D(
        ///         target: number,
        ///         level: number,
        ///         internalformat: number,
        ///         width: number,
        ///         height: number,
        ///         border: number,
        ///         data: ArrayBufferView,
        ///     ): void;
        /// </summary>
        public void CompressedTexImage2D(float target, float level, float internalformat, float width, float height, float border, ArrayBufferView data)
        {
            JSRef!.CallVoid("compressedTexImage2D", target, level, internalformat, width, height, border, data);
        }
        /// <summary>
        /// bindTexture(webglType: number, webglTexture: any): void;
        /// </summary>
        public void BindTexture(float webglType, object webglTexture)
        {
            JSRef!.CallVoid("bindTexture", webglType, webglTexture);
        }
        /// <summary>
        /// bindFramebuffer(target: number, framebuffer: WebGLFramebuffer | null): void;
        /// </summary>
        public void BindFramebuffer(float target, WebGLFramebuffer framebuffer)
        {
            JSRef!.CallVoid("bindFramebuffer", target, framebuffer);
        }
        /// <summary>
        /// activeTexture(webglSlot: number): void;
        /// </summary>
        public void ActiveTexture(float webglSlot)
        {
            JSRef!.CallVoid("activeTexture", webglSlot);
        }
        #endregion
    }
}
