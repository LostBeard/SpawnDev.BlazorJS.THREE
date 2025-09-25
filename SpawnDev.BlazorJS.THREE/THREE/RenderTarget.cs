
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderTarget : EventDispatcher
    {
        /// <inheritdoc/>
        public RenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class RenderTarget<TTexture> : RenderTarget
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number, options?: RenderTargetOptions);
        /// </summary>
        public RenderTarget(float width, float height, RenderTargetOptions options) : base(JS.New("THREE.RenderTarget", width, height, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// depth: number;
        /// </summary>
        public float Depth { get => JSRef!.Get<float>("depth"); set => JSRef!.Set("depth", value); }
        /// <summary>
        /// depthBuffer: boolean;
        /// </summary>
        public bool DepthBuffer { get => JSRef!.Get<bool>("depthBuffer"); set => JSRef!.Set("depthBuffer", value); }
        /// <summary>
        /// set depthTexture(current: DepthTexture | null);
        /// </summary>
        public DepthTexture DepthTexture { get => JSRef!.Get<DepthTexture>("depthTexture"); set => JSRef!.Set("depthTexture", value); }
        /// <summary>
        /// height: number;
        /// </summary>
        public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
        /// <summary>
        /// readonly isRenderTarget: true;
        /// </summary>
        public bool IsRenderTarget { get => JSRef!.Get<bool>("isRenderTarget"); }
        /// <summary>
        /// multiview: boolean;
        /// </summary>
        public bool Multiview { get => JSRef!.Get<bool>("multiview"); set => JSRef!.Set("multiview", value); }
        /// <summary>
        /// resolveDepthBuffer: boolean;
        /// </summary>
        public bool ResolveDepthBuffer { get => JSRef!.Get<bool>("resolveDepthBuffer"); set => JSRef!.Set("resolveDepthBuffer", value); }
        /// <summary>
        /// resolveStencilBuffer: boolean;
        /// </summary>
        public bool ResolveStencilBuffer { get => JSRef!.Get<bool>("resolveStencilBuffer"); set => JSRef!.Set("resolveStencilBuffer", value); }
        /// <summary>
        /// samples: number;
        /// </summary>
        public float Samples { get => JSRef!.Get<float>("samples"); set => JSRef!.Set("samples", value); }
        /// <summary>
        /// scissor: Vector4;
        /// </summary>
        public Vector4 Scissor { get => JSRef!.Get<Vector4>("scissor"); set => JSRef!.Set("scissor", value); }
        /// <summary>
        /// scissorTest: boolean;
        /// </summary>
        public bool ScissorTest { get => JSRef!.Get<bool>("scissorTest"); set => JSRef!.Set("scissorTest", value); }
        /// <summary>
        /// stencilBuffer: boolean;
        /// </summary>
        public bool StencilBuffer { get => JSRef!.Get<bool>("stencilBuffer"); set => JSRef!.Set("stencilBuffer", value); }
        /// <summary>
        /// get texture(): TTexture;
        /// </summary>
        public TTexture Texture { get => JSRef!.Get<TTexture>("texture"); set => JSRef!.Set("texture", value); }
        /// <summary>
        /// textures: TTexture[];
        /// </summary>
        public Array<TTexture> Textures { get => JSRef!.Get<Array<TTexture>>("textures"); set => JSRef!.Set("textures", value); }
        /// <summary>
        /// viewport: Vector4;
        /// </summary>
        public Vector4 Viewport { get => JSRef!.Get<Vector4>("viewport"); set => JSRef!.Set("viewport", value); }
        /// <summary>
        /// width: number;
        /// </summary>
        public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setSize(width: number, height: number, depth?: number): void;
        /// </summary>
        public void SetSize(float width, float height, float depth)
        {
            JSRef!.CallVoid("setSize", width, height, depth);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// copy(source: RenderTarget): this;
        /// </summary>
        public RenderTarget Copy(RenderTarget source)
        {
            return JSRef!.Call<RenderTarget>("copy", source);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public RenderTarget Clone()
        {
            return JSRef!.Call<RenderTarget>("clone");
        }
        #endregion
    }
}
