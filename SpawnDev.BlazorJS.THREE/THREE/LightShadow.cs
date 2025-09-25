
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LightShadow : JSObject
    {
        /// <inheritdoc/>
        public LightShadow(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class LightShadow<TCamera> : LightShadow
    {
        #region Constructors
        /// <inheritdoc/>
        public LightShadow(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(camera: TCamera);
        /// </summary>
        public LightShadow(TCamera camera) : base(JS.New("THREE.LightShadow", camera)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// autoUpdate: boolean;
        /// </summary>
        public bool AutoUpdate { get => JSRef!.Get<bool>("autoUpdate"); set => JSRef!.Set("autoUpdate", value); }
        /// <summary>
        /// bias: number;
        /// </summary>
        public float Bias { get => JSRef!.Get<float>("bias"); set => JSRef!.Set("bias", value); }
        /// <summary>
        /// blurSamples: number;
        /// </summary>
        public float BlurSamples { get => JSRef!.Get<float>("blurSamples"); set => JSRef!.Set("blurSamples", value); }
        /// <summary>
        /// camera: TCamera;
        /// </summary>
        public TCamera Camera { get => JSRef!.Get<TCamera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// intensity: number;
        /// </summary>
        public float Intensity { get => JSRef!.Get<float>("intensity"); set => JSRef!.Set("intensity", value); }
        /// <summary>
        /// map: WebGLRenderTarget | null;
        /// </summary>
        public WebGLRenderTarget Map { get => JSRef!.Get<WebGLRenderTarget>("map"); set => JSRef!.Set("map", value); }
        /// <summary>
        /// mapPass: WebGLRenderTarget | null;
        /// </summary>
        public WebGLRenderTarget MapPass { get => JSRef!.Get<WebGLRenderTarget>("mapPass"); set => JSRef!.Set("mapPass", value); }
        /// <summary>
        /// mapSize: Vector2;
        /// </summary>
        public Vector2 MapSize { get => JSRef!.Get<Vector2>("mapSize"); set => JSRef!.Set("mapSize", value); }
        /// <summary>
        /// mapType: TextureDataType;
        /// </summary>
        public TextureDataType MapType { get => JSRef!.Get<TextureDataType>("mapType"); set => JSRef!.Set("mapType", value); }
        /// <summary>
        /// matrix: Matrix4;
        /// </summary>
        public Matrix4 Matrix { get => JSRef!.Get<Matrix4>("matrix"); set => JSRef!.Set("matrix", value); }
        /// <summary>
        /// needsUpdate: boolean;
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// normalBias: number;
        /// </summary>
        public float NormalBias { get => JSRef!.Get<float>("normalBias"); set => JSRef!.Set("normalBias", value); }
        /// <summary>
        /// radius: number;
        /// </summary>
        public float Radius { get => JSRef!.Get<float>("radius"); set => JSRef!.Set("radius", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateMatrices(light: Light): void;
        /// </summary>
        public void UpdateMatrices(Light light)
        {
            JSRef!.CallVoid("updateMatrices", light);
        }
        /// <summary>
        /// toJSON(): LightShadowJSON;
        /// </summary>
        public LightShadowJSON ToJSON()
        {
            return JSRef!.Call<LightShadowJSON>("toJSON");
        }
        /// <summary>
        /// getViewportCount(): number;
        /// </summary>
        public float GetViewportCount()
        {
            return JSRef!.Call<float>("getViewportCount");
        }
        /// <summary>
        /// getViewport(viewportIndex: number): Vector4;
        /// </summary>
        public Vector4 GetViewport(float viewportIndex)
        {
            return JSRef!.Call<Vector4>("getViewport", viewportIndex);
        }
        /// <summary>
        /// getFrustum(): Frustum;
        /// </summary>
        public Frustum GetFrustum()
        {
            return JSRef!.Call<Frustum>("getFrustum");
        }
        /// <summary>
        /// getFrameExtents(): Vector2;
        /// </summary>
        public Vector2 GetFrameExtents()
        {
            return JSRef!.Call<Vector2>("getFrameExtents");
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// copy(source: LightShadow): this;
        /// </summary>
        public LightShadow<TCamera> Copy(LightShadow<TCamera> source)
        {
            return JSRef!.Call<LightShadow<TCamera>>("copy", source);
        }
        /// <summary>
        /// clone(recursive?: boolean): this;
        /// </summary>
        public LightShadow<TCamera> Clone(bool recursive)
        {
            return JSRef!.Call<LightShadow<TCamera>>("clone", recursive);
        }
        #endregion
    }
}
