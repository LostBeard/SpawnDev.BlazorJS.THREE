
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderContext : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderContext(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public RenderContext() : base(JS.New("THREE.RenderContext")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// activeCubeFace: number;
        /// </summary>
        public float ActiveCubeFace { get => JSRef!.Get<float>("activeCubeFace"); set => JSRef!.Set("activeCubeFace", value); }
        /// <summary>
        /// activeMipmapLevel?: number | undefined;
        /// </summary>
        public float ActiveMipmapLevel { get => JSRef!.Get<float>("activeMipmapLevel"); set => JSRef!.Set("activeMipmapLevel", value); }
        /// <summary>
        /// clearColor: boolean;
        /// </summary>
        public bool ClearColor { get => JSRef!.Get<bool>("clearColor"); set => JSRef!.Set("clearColor", value); }
        /// <summary>
        /// clearColorValue: {
                ///         r: number;
                ///         g: number;
                ///         b: number;
                ///         a: number;
                ///     };
        /// </summary>
        public object ClearColorValue { get => JSRef!.Get<object>("clearColorValue"); set => JSRef!.Set("clearColorValue", value); }
        /// <summary>
        /// clearDepth: boolean;
        /// </summary>
        public bool ClearDepth { get => JSRef!.Get<bool>("clearDepth"); set => JSRef!.Set("clearDepth", value); }
        /// <summary>
        /// clearDepthValue: number;
        /// </summary>
        public float ClearDepthValue { get => JSRef!.Get<float>("clearDepthValue"); set => JSRef!.Set("clearDepthValue", value); }
        /// <summary>
        /// clearStencil: boolean;
        /// </summary>
        public bool ClearStencil { get => JSRef!.Get<bool>("clearStencil"); set => JSRef!.Set("clearStencil", value); }
        /// <summary>
        /// clearStencilValue: number;
        /// </summary>
        public float ClearStencilValue { get => JSRef!.Get<float>("clearStencilValue"); set => JSRef!.Set("clearStencilValue", value); }
        /// <summary>
        /// clippingContext: ClippingContext | null;
        /// </summary>
        public ClippingContext ClippingContext { get => JSRef!.Get<ClippingContext>("clippingContext"); set => JSRef!.Set("clippingContext", value); }
        /// <summary>
        /// color: boolean;
        /// </summary>
        public bool Color { get => JSRef!.Get<bool>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// depth: boolean;
        /// </summary>
        public bool Depth { get => JSRef!.Get<bool>("depth"); set => JSRef!.Set("depth", value); }
        /// <summary>
        /// depthClearValue?: number | undefined;
        /// </summary>
        public float DepthClearValue { get => JSRef!.Get<float>("depthClearValue"); set => JSRef!.Set("depthClearValue", value); }
        /// <summary>
        /// depthTexture: DepthTexture | null;
        /// </summary>
        public DepthTexture DepthTexture { get => JSRef!.Get<DepthTexture>("depthTexture"); set => JSRef!.Set("depthTexture", value); }
        /// <summary>
        /// height: number;
        /// </summary>
        public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// readonly isRenderContext: true;
        /// </summary>
        public bool IsRenderContext { get => JSRef!.Get<bool>("isRenderContext"); }
        /// <summary>
        /// occlusionQueryCount: number;
        /// </summary>
        public float OcclusionQueryCount { get => JSRef!.Get<float>("occlusionQueryCount"); set => JSRef!.Set("occlusionQueryCount", value); }
        /// <summary>
        /// renderTarget: RenderTarget | null;
        /// </summary>
        public RenderTarget RenderTarget { get => JSRef!.Get<RenderTarget>("renderTarget"); set => JSRef!.Set("renderTarget", value); }
        /// <summary>
        /// sampleCount: number;
        /// </summary>
        public float SampleCount { get => JSRef!.Get<float>("sampleCount"); set => JSRef!.Set("sampleCount", value); }
        /// <summary>
        /// scissor: boolean;
        /// </summary>
        public bool Scissor { get => JSRef!.Get<bool>("scissor"); set => JSRef!.Set("scissor", value); }
        /// <summary>
        /// scissorValue: Vector4;
        /// </summary>
        public Vector4 ScissorValue { get => JSRef!.Get<Vector4>("scissorValue"); set => JSRef!.Set("scissorValue", value); }
        /// <summary>
        /// stencil: boolean;
        /// </summary>
        public bool Stencil { get => JSRef!.Get<bool>("stencil"); set => JSRef!.Set("stencil", value); }
        /// <summary>
        /// stencilClearValue?: number | undefined;
        /// </summary>
        public float StencilClearValue { get => JSRef!.Get<float>("stencilClearValue"); set => JSRef!.Set("stencilClearValue", value); }
        /// <summary>
        /// textures: Texture[] | null;
        /// </summary>
        public Array<Texture> Textures { get => JSRef!.Get<Array<Texture>>("textures"); set => JSRef!.Set("textures", value); }
        /// <summary>
        /// viewport: boolean;
        /// </summary>
        public bool Viewport { get => JSRef!.Get<bool>("viewport"); set => JSRef!.Set("viewport", value); }
        /// <summary>
        /// viewportValue: Vector4;
        /// </summary>
        public Vector4 ViewportValue { get => JSRef!.Get<Vector4>("viewportValue"); set => JSRef!.Set("viewportValue", value); }
        /// <summary>
        /// width: number;
        /// </summary>
        public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getCacheKey(): number;
        /// </summary>
        public float GetCacheKey()
        {
            return JSRef!.Call<float>("getCacheKey");
        }
        #endregion
    }
}
