
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLRenderer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLRenderer(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(parameters?: WebGLRendererParameters);
        /// </summary>
        public WebGLRenderer(WebGLRendererParameters parameters) : base(JS.New("THREE.WebGLRenderer", parameters)) { }

        #endregion

        #region Properties
        /// <summary>
        /// autoClear: boolean;
        /// </summary>
        public bool AutoClear { get => JSRef!.Get<bool>("autoClear"); set => JSRef!.Set("autoClear", value); }
        /// <summary>
        /// autoClearColor: boolean;
        /// </summary>
        public bool AutoClearColor { get => JSRef!.Get<bool>("autoClearColor"); set => JSRef!.Set("autoClearColor", value); }
        /// <summary>
        /// autoClearDepth: boolean;
        /// </summary>
        public bool AutoClearDepth { get => JSRef!.Get<bool>("autoClearDepth"); set => JSRef!.Set("autoClearDepth", value); }
        /// <summary>
        /// autoClearStencil: boolean;
        /// </summary>
        public bool AutoClearStencil { get => JSRef!.Get<bool>("autoClearStencil"); set => JSRef!.Set("autoClearStencil", value); }
        /// <summary>
        /// capabilities: WebGLCapabilities;
        /// </summary>
        public WebGLCapabilities Capabilities { get => JSRef!.Get<WebGLCapabilities>("capabilities"); set => JSRef!.Set("capabilities", value); }
        /// <summary>
        /// clippingPlanes: Plane[];
        /// </summary>
        public Array<Plane> ClippingPlanes { get => JSRef!.Get<Array<Plane>>("clippingPlanes"); set => JSRef!.Set("clippingPlanes", value); }
        /// <summary>
        /// get coordinateSystem(): typeof WebGLCoordinateSystem;
        /// </summary>
        public WebGLCoordinateSystem CoordinateSystem { get => JSRef!.Get<WebGLCoordinateSystem>("coordinateSystem"); }
        /// <summary>
        /// debug: WebGLDebug;
        /// </summary>
        public WebGLDebug Debug { get => JSRef!.Get<WebGLDebug>("debug"); set => JSRef!.Set("debug", value); }
        /// <summary>
        /// domElement: HTMLCanvasElement;
        /// </summary>
        public HTMLCanvasElement DomElement { get => JSRef!.Get<HTMLCanvasElement>("domElement"); set => JSRef!.Set("domElement", value); }
        /// <summary>
        /// extensions: WebGLExtensions;
        /// </summary>
        public WebGLExtensions Extensions { get => JSRef!.Get<WebGLExtensions>("extensions"); set => JSRef!.Set("extensions", value); }
        /// <summary>
        /// info: WebGLInfo;
        /// </summary>
        public WebGLInfo Info { get => JSRef!.Get<WebGLInfo>("info"); set => JSRef!.Set("info", value); }
        /// <summary>
        /// localClippingEnabled: boolean;
        /// </summary>
        public bool LocalClippingEnabled { get => JSRef!.Get<bool>("localClippingEnabled"); set => JSRef!.Set("localClippingEnabled", value); }
        /// <summary>
        /// get outputColorSpace(): string;
        /// </summary>
        public string OutputColorSpace { get => JSRef!.Get<string>("outputColorSpace"); set => JSRef!.Set("outputColorSpace", value); }
        /// <summary>
        /// properties: WebGLProperties;
        /// </summary>
        public WebGLProperties Properties { get => JSRef!.Get<WebGLProperties>("properties"); set => JSRef!.Set("properties", value); }
        /// <summary>
        /// renderLists: WebGLRenderLists;
        /// </summary>
        public WebGLRenderLists RenderLists { get => JSRef!.Get<WebGLRenderLists>("renderLists"); set => JSRef!.Set("renderLists", value); }
        /// <summary>
        /// shadowMap: WebGLShadowMap;
        /// </summary>
        public WebGLShadowMap ShadowMap { get => JSRef!.Get<WebGLShadowMap>("shadowMap"); set => JSRef!.Set("shadowMap", value); }
        /// <summary>
        /// shadowMapCullFace: CullFace;
        /// </summary>
        public CullFace ShadowMapCullFace { get => JSRef!.Get<CullFace>("shadowMapCullFace"); set => JSRef!.Set("shadowMapCullFace", value); }
        /// <summary>
        /// shadowMapEnabled: boolean;
        /// </summary>
        public bool ShadowMapEnabled { get => JSRef!.Get<bool>("shadowMapEnabled"); set => JSRef!.Set("shadowMapEnabled", value); }
        /// <summary>
        /// shadowMapType: ShadowMapType;
        /// </summary>
        public ShadowMapType ShadowMapType { get => JSRef!.Get<ShadowMapType>("shadowMapType"); set => JSRef!.Set("shadowMapType", value); }
        /// <summary>
        /// sortObjects: boolean;
        /// </summary>
        public bool SortObjects { get => JSRef!.Get<bool>("sortObjects"); set => JSRef!.Set("sortObjects", value); }
        /// <summary>
        /// state: WebGLState;
        /// </summary>
        public WebGLState State { get => JSRef!.Get<WebGLState>("state"); set => JSRef!.Set("state", value); }
        /// <summary>
        /// toneMapping: ToneMapping;
        /// </summary>
        public ToneMapping ToneMapping { get => JSRef!.Get<ToneMapping>("toneMapping"); set => JSRef!.Set("toneMapping", value); }
        /// <summary>
        /// toneMappingExposure: number;
        /// </summary>
        public float ToneMappingExposure { get => JSRef!.Get<float>("toneMappingExposure"); set => JSRef!.Set("toneMappingExposure", value); }
        /// <summary>
        /// transmissionResolutionScale: number;
        /// </summary>
        public float TransmissionResolutionScale { get => JSRef!.Get<float>("transmissionResolutionScale"); set => JSRef!.Set("transmissionResolutionScale", value); }
        /// <summary>
        /// vr: boolean;
        /// </summary>
        public bool Vr { get => JSRef!.Get<bool>("vr"); set => JSRef!.Set("vr", value); }
        /// <summary>
        /// xr: WebXRManager;
        /// </summary>
        public WebXRManager Xr { get => JSRef!.Get<WebXRManager>("xr"); set => JSRef!.Set("xr", value); }
        #endregion

        #region Methods
        /// <summary>
        /// supportsVertexTextures(): any;
        /// </summary>
        public object SupportsVertexTextures()
        {
            return JSRef!.Call<object>("supportsVertexTextures");
        }
        /// <summary>
        /// supportsStandardDerivatives(): any;
        /// </summary>
        public object SupportsStandardDerivatives()
        {
            return JSRef!.Call<object>("supportsStandardDerivatives");
        }
        /// <summary>
        /// supportsInstancedArrays(): any;
        /// </summary>
        public object SupportsInstancedArrays()
        {
            return JSRef!.Call<object>("supportsInstancedArrays");
        }
        /// <summary>
        /// supportsHalfFloatTextures(): any;
        /// </summary>
        public object SupportsHalfFloatTextures()
        {
            return JSRef!.Call<object>("supportsHalfFloatTextures");
        }
        /// <summary>
        /// supportsFloatTextures(): any;
        /// </summary>
        public object SupportsFloatTextures()
        {
            return JSRef!.Call<object>("supportsFloatTextures");
        }
        /// <summary>
        /// supportsCompressedTextureS3TC(): any;
        /// </summary>
        public object SupportsCompressedTextureS3TC()
        {
            return JSRef!.Call<object>("supportsCompressedTextureS3TC");
        }
        /// <summary>
        /// supportsCompressedTexturePVRTC(): any;
        /// </summary>
        public object SupportsCompressedTexturePVRTC()
        {
            return JSRef!.Call<object>("supportsCompressedTexturePVRTC");
        }
        /// <summary>
        /// supportsBlendMinMax(): any;
        /// </summary>
        public object SupportsBlendMinMax()
        {
            return JSRef!.Call<object>("supportsBlendMinMax");
        }
        /// <summary>
        /// setViewport(x: Vector4 | number, y?: number, width?: number, height?: number): void;
        /// </summary>
        public void SetViewport(Union<Vector4, float> x, float y, float width, float height)
        {
            JSRef!.CallVoid("setViewport", x, y, width, height);
        }
        /// <summary>
        /// setTransparentSort(method: ((a: any, b: any) => number) | null): void;
        /// </summary>
        public void SetTransparentSort(FuncCallback<JSObject, JSObject, int> method)
        {
            JSRef!.CallVoid("setTransparentSort", method);
        }
        /// <summary>
        /// setSize(width: number, height: number, updateStyle?: boolean): void;
        /// </summary>
        public void SetSize(float width, float height, bool updateStyle = false)
        {
            JSRef!.CallVoid("setSize", width, height, updateStyle);
        }
        /// <summary>
        /// setScissorTest(enable: boolean): void;
        /// </summary>
        public void SetScissorTest(bool enable)
        {
            JSRef!.CallVoid("setScissorTest", enable);
        }
        /// <summary>
        /// setScissor(x: Vector4 | number, y?: number, width?: number, height?: number): void;
        /// </summary>
        public void SetScissor(Union<Vector4, float> x, float y, float width, float height)
        {
            JSRef!.CallVoid("setScissor", x, y, width, height);
        }
        /// <summary>
        /// setRenderTarget(
        ///         renderTarget: WebGLRenderTarget | WebGLRenderTarget<Texture[]> | null,
        ///         activeCubeFace?: number,
        ///         activeMipmapLevel?: number,
        ///     ): void;
        /// </summary>
        public void SetRenderTarget(Union<WebGLRenderTarget, WebGLRenderTarget<Array<Texture>>> renderTarget, float activeCubeFace, float activeMipmapLevel)
        {
            JSRef!.CallVoid("setRenderTarget", renderTarget, activeCubeFace, activeMipmapLevel);
        }
        /// <summary>
        /// setPixelRatio(value: number): void;
        /// </summary>
        public void SetPixelRatio(float value)
        {
            JSRef!.CallVoid("setPixelRatio", value);
        }
        /// <summary>
        /// setOpaqueSort(method: ((a: any, b: any) => number) | null): void;
        /// </summary>
        public void SetOpaqueSort(Callback method, object a, object b)
        {
            JSRef!.CallVoid("setOpaqueSort", method, a, b);
        }
        /// <summary>
        /// setDrawingBufferSize(width: number, height: number, pixelRatio: number): void;
        /// </summary>
        public void SetDrawingBufferSize(float width, float height, float pixelRatio)
        {
            JSRef!.CallVoid("setDrawingBufferSize", width, height, pixelRatio);
        }
        /// <summary>
        /// setClearColor(color: ColorRepresentation, alpha?: number): void;
        /// </summary>
        public void SetClearColor(ColorRepresentation color, float alpha)
        {
            JSRef!.CallVoid("setClearColor", color, alpha);
        }
        /// <summary>
        /// setClearAlpha(alpha: number): void;
        /// </summary>
        public void SetClearAlpha(float alpha)
        {
            JSRef!.CallVoid("setClearAlpha", alpha);
        }
        /// <summary>
        /// setAnimationLoop(callback: XRFrameRequestCallback | null): void;
        /// </summary>
        public void SetAnimationLoop(XRFrameRequestCallback callback)
        {
            JSRef!.CallVoid("setAnimationLoop", callback);
        }
        /// <summary>
        /// resetState(): void;
        /// </summary>
        public void ResetState()
        {
            JSRef!.CallVoid("resetState");
        }
        /// <summary>
        /// resetGLState(): void;
        /// </summary>
        public void ResetGLState()
        {
            JSRef!.CallVoid("resetGLState");
        }
        /// <summary>
        /// renderBufferDirect(
        ///         camera: Camera,
        ///         scene: Scene,
        ///         geometry: BufferGeometry,
        ///         material: Material,
        ///         object: Object3D,
        ///         geometryGroup: any,
        ///     ): void;
        /// </summary>
        public void RenderBufferDirect(Camera camera, Scene scene, BufferGeometry geometry, Material material, Object3D obj, object geometryGroup)
        {
            JSRef!.CallVoid("renderBufferDirect", camera, scene, geometry, material, obj, geometryGroup);
        }
        /// <summary>
        /// render(scene: Object3D, camera: Camera): void;
        /// </summary>
        public void Render(Object3D scene, Camera camera)
        {
            JSRef!.CallVoid("render", scene, camera);
        }
        /// <summary>
        /// readRenderTargetPixelsAsync(
        ///         renderTarget: WebGLRenderTarget | WebGLRenderTarget<Texture[]>,
        ///         x: number,
        ///         y: number,
        ///         width: number,
        ///         height: number,
        ///         buffer: TypedArray,
        ///         activeCubeFaceIndex?: number,
        ///         textureIndex?: number,
        ///     ): Promise<TypedArray>;
        /// </summary>
        public Task<TypedArray> ReadRenderTargetPixelsAsync(Union<WebGLRenderTarget, WebGLRenderTarget<Array<Texture>>> renderTarget, float x, float y, float width, float height, TypedArray buffer, float activeCubeFaceIndex, float textureIndex)
        {
            return JSRef!.CallAsync<TypedArray>("readRenderTargetPixelsAsync", renderTarget, x, y, width, height, buffer, activeCubeFaceIndex, textureIndex);
        }
        /// <summary>
        /// readRenderTargetPixels(
        ///         renderTarget: WebGLRenderTarget | WebGLRenderTarget<Texture[]>,
        ///         x: number,
        ///         y: number,
        ///         width: number,
        ///         height: number,
        ///         buffer: TypedArray,
        ///         activeCubeFaceIndex?: number,
        ///         textureIndex?: number,
        ///     ): void;
        /// </summary>
        public void ReadRenderTargetPixels(Union<WebGLRenderTarget, WebGLRenderTarget<Array<Texture>>> renderTarget, float x, float y, float width, float height, TypedArray buffer, float activeCubeFaceIndex, float textureIndex)
        {
            JSRef!.CallVoid("readRenderTargetPixels", renderTarget, x, y, width, height, buffer, activeCubeFaceIndex, textureIndex);
        }
        /// <summary>
        /// initTexture(texture: Texture): void;
        /// </summary>
        public void InitTexture(Texture texture)
        {
            JSRef!.CallVoid("initTexture", texture);
        }
        /// <summary>
        /// initRenderTarget(target: WebGLRenderTarget): void;
        /// </summary>
        public void InitRenderTarget(WebGLRenderTarget target)
        {
            JSRef!.CallVoid("initRenderTarget", target);
        }
        /// <summary>
        /// getViewport(target: Vector4): Vector4;
        /// </summary>
        public Vector4 GetViewport(Vector4 target)
        {
            return JSRef!.Call<Vector4>("getViewport", target);
        }
        /// <summary>
        /// getSize(target: Vector2): Vector2;
        /// </summary>
        public Vector2 GetSize(Vector2 target)
        {
            return JSRef!.Call<Vector2>("getSize", target);
        }
        /// <summary>
        /// getScissorTest(): boolean;
        /// </summary>
        public bool GetScissorTest()
        {
            return JSRef!.Call<bool>("getScissorTest");
        }
        /// <summary>
        /// getScissor(target: Vector4): Vector4;
        /// </summary>
        public Vector4 GetScissor(Vector4 target)
        {
            return JSRef!.Call<Vector4>("getScissor", target);
        }
        /// <summary>
        /// getRenderTarget(): WebGLRenderTarget | null;
        /// </summary>
        public WebGLRenderTarget GetRenderTarget()
        {
            return JSRef!.Call<WebGLRenderTarget>("getRenderTarget");
        }
        /// <summary>
        /// getPrecision(): string;
        /// </summary>
        public string GetPrecision()
        {
            return JSRef!.Call<string>("getPrecision");
        }
        /// <summary>
        /// getPixelRatio(): number;
        /// </summary>
        public float GetPixelRatio()
        {
            return JSRef!.Call<float>("getPixelRatio");
        }
        /// <summary>
        /// getMaxAnisotropy(): number;
        /// </summary>
        public float GetMaxAnisotropy()
        {
            return JSRef!.Call<float>("getMaxAnisotropy");
        }
        /// <summary>
        /// getDrawingBufferSize(target: Vector2): Vector2;
        /// </summary>
        public Vector2 GetDrawingBufferSize(Vector2 target)
        {
            return JSRef!.Call<Vector2>("getDrawingBufferSize", target);
        }
        /// <summary>
        /// getCurrentViewport(target: Vector4): Vector4;
        /// </summary>
        public Vector4 GetCurrentViewport(Vector4 target)
        {
            return JSRef!.Call<Vector4>("getCurrentViewport", target);
        }
        /// <summary>
        /// getCurrentRenderTarget(): WebGLRenderTarget | null;
        /// </summary>
        public WebGLRenderTarget GetCurrentRenderTarget()
        {
            return JSRef!.Call<WebGLRenderTarget>("getCurrentRenderTarget");
        }
        /// <summary>
        /// getContextAttributes(): any;
        /// </summary>
        public object GetContextAttributes()
        {
            return JSRef!.Call<object>("getContextAttributes");
        }
        /// <summary>
        /// getContext(): WebGLRenderingContext | WebGL2RenderingContext;
        /// </summary>
        public Union<WebGLRenderingContext, WebGL2RenderingContext> GetContext()
        {
            return JSRef!.Call<Union<WebGLRenderingContext, WebGL2RenderingContext>>("getContext");
        }
        /// <summary>
        /// getClearColor(target: Color): Color;
        /// </summary>
        public Color GetClearColor(Color target)
        {
            return JSRef!.Call<Color>("getClearColor", target);
        }
        /// <summary>
        /// getClearAlpha(): number;
        /// </summary>
        public float GetClearAlpha()
        {
            return JSRef!.Call<float>("getClearAlpha");
        }
        /// <summary>
        /// getActiveMipmapLevel(): number;
        /// </summary>
        public float GetActiveMipmapLevel()
        {
            return JSRef!.Call<float>("getActiveMipmapLevel");
        }
        /// <summary>
        /// getActiveCubeFace(): number;
        /// </summary>
        public float GetActiveCubeFace()
        {
            return JSRef!.Call<float>("getActiveCubeFace");
        }
        /// <summary>
        /// forceContextRestore(): void;
        /// </summary>
        public void ForceContextRestore()
        {
            JSRef!.CallVoid("forceContextRestore");
        }
        /// <summary>
        /// forceContextLoss(): void;
        /// </summary>
        public void ForceContextLoss()
        {
            JSRef!.CallVoid("forceContextLoss");
        }
        /// <summary>
        /// enableScissorTest(boolean: any): any;
        /// </summary>
        public object EnableScissorTest(object boolean)
        {
            return JSRef!.Call<object>("enableScissorTest", boolean);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// copyTextureToTexture(
        ///         srcTexture: Texture,
        ///         dstTexture: Texture,
        ///         srcRegion?: Box2 | Box3 | null,
        ///         dstPosition?: Vector2 | Vector3 | null,
        ///         srcLevel?: number,
        ///         dstLevel?: number,
        ///     ): void;
        /// </summary>
        public void CopyTextureToTexture(Texture srcTexture, Texture dstTexture, Union<Box2, Box3> srcRegion, Union<Vector2, Vector3> dstPosition, float srcLevel, float dstLevel)
        {
            JSRef!.CallVoid("copyTextureToTexture", srcTexture, dstTexture, srcRegion, dstPosition, srcLevel, dstLevel);
        }
        /// <summary>
        /// copyFramebufferToTexture(texture: Texture, position?: Vector2 | null, level?: number): void;
        /// </summary>
        public void CopyFramebufferToTexture(Texture texture, Vector2 position, float level)
        {
            JSRef!.CallVoid("copyFramebufferToTexture", texture, position, level);
        }
        /// <summary>
        /// (scene: Object3D, camera: Camera, targetScene?: Scene | null) => Promise<Object3D>
        /// </summary>
        public Task<Object3D> CompileAsync(Object3D scene, Camera camera, Scene targetScene)
        {
            return JSRef!.CallAsync<Object3D>("compileAsync", scene, camera, targetScene);
        }
        /// <summary>
        /// (scene: Object3D, camera: Camera, targetScene?: Scene | null) => Set<Material>
        /// </summary>
        public Set<Material> Compile(Object3D scene, Camera camera, Scene targetScene)
        {
            return JSRef!.Call<Set<Material>>("compile", scene, camera, targetScene);
        }
        /// <summary>
        /// clearTarget(renderTarget: WebGLRenderTarget, color: boolean, depth: boolean, stencil: boolean): void;
        /// </summary>
        public void ClearTarget(WebGLRenderTarget renderTarget, bool color, bool depth, bool stencil)
        {
            JSRef!.CallVoid("clearTarget", renderTarget, color, depth, stencil);
        }
        /// <summary>
        /// clearStencil(): void;
        /// </summary>
        public void ClearStencil()
        {
            JSRef!.CallVoid("clearStencil");
        }
        /// <summary>
        /// clearDepth(): void;
        /// </summary>
        public void ClearDepth()
        {
            JSRef!.CallVoid("clearDepth");
        }
        /// <summary>
        /// clearColor(): void;
        /// </summary>
        public void ClearColor()
        {
            JSRef!.CallVoid("clearColor");
        }
        /// <summary>
        /// clear(color?: boolean, depth?: boolean, stencil?: boolean): void;
        /// </summary>
        public void Clear(bool color, bool depth, bool stencil)
        {
            JSRef!.CallVoid("clear", color, depth, stencil);
        }
        /// <summary>
        /// animate(callback: () => void): void;
        /// </summary>
        public void Animate(Callback callback)
        {
            JSRef!.CallVoid("animate", callback);
        }
        #endregion
    }
}
