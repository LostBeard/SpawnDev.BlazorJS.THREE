
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Renderer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Renderer(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(backend: Backend, parameters?: RendererParameters);
        /// </summary>
        public Renderer(Backend backend, RendererParameters parameters) : base(JS.New("THREE.Renderer", backend, parameters)) { }

        #endregion

        #region Properties
        /// <summary>
        /// alpha: boolean;
        /// </summary>
        public bool Alpha { get => JSRef!.Get<bool>("alpha"); set => JSRef!.Set("alpha", value); }
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
        /// backend: Backend;
        /// </summary>
        public Backend Backend { get => JSRef!.Get<Backend>("backend"); set => JSRef!.Set("backend", value); }
        /// <summary>
        /// get compile(): (scene: Object3D, camera: Camera, targetScene?: Scene | null) => Promise<void>;
        /// </summary>
        public Task Compile(Object3D scene, Camera camera, Scene? targetScene = null) 
            => targetScene ==  null ? JSRef!.CallVoidAsync("compile", scene, camera) : JSRef!.CallVoidAsync("compile", scene, camera, targetScene);
        /// <summary>
        /// CoordinateSystem;
        /// </summary>
        public CoordinateSystem CoordinateSystem { get => JSRef!.Get<CoordinateSystem>("CoordinateSystem"); set => JSRef!.Set("CoordinateSystem", value); }
        /// <summary>
        /// get currentColorSpace(): string;
        /// </summary>
        public string CurrentColorSpace { get => JSRef!.Get<string>("currentColorSpace"); }
        /// <summary>
        /// get currentToneMapping(): ToneMapping;
        /// </summary>
        public ToneMapping CurrentToneMapping { get => JSRef!.Get<ToneMapping>("currentToneMapping"); }
        /// <summary>
        /// debug: {
        ///         checkShaderErrors: boolean;
        ///         onShaderError:
        ///             | ((
        ///                 gl: WebGL2RenderingContext,
        ///                 programGPU: WebGLProgram,
        ///                 glVertexShader: WebGLShader,
        ///                 glFragmentShader: WebGLShader,
        ///             ) => void)
        ///             | null;
        ///         getShaderAsync: (scene: Scene, camera: Camera, object: Object3D) => Promise<{
        ///             fragmentShader: string | null;
        ///             vertexShader: string | null;
        ///         }>;
        ///     };
        /// </summary>
        public object Debug { get => JSRef!.Get<object>("debug"); set => JSRef!.Set("debug", value); }
        /// <summary>
        /// depth: boolean;
        /// </summary>
        public bool Depth { get => JSRef!.Get<bool>("depth"); set => JSRef!.Set("depth", value); }
        /// <summary>
        /// domElement: HTMLCanvasElement;
        /// </summary>
        public HTMLCanvasElement DomElement { get => JSRef!.Get<HTMLCanvasElement>("domElement"); set => JSRef!.Set("domElement", value); }
        /// <summary>
        /// set highPrecision(value: boolean);
        /// </summary>
        public bool HighPrecision { get => JSRef!.Get<bool>("highPrecision"); set => JSRef!.Set("highPrecision", value); }
        /// <summary>
        /// info: Info;
        /// </summary>
        public Info Info { get => JSRef!.Get<Info>("info"); set => JSRef!.Set("info", value); }
        /// <summary>
        /// get isOutputTarget(): boolean;
        /// </summary>
        public bool IsOutputTarget { get => JSRef!.Get<bool>("isOutputTarget"); }
        /// <summary>
        /// readonly isRenderer: true;
        /// </summary>
        public bool IsRenderer { get => JSRef!.Get<bool>("isRenderer"); }
        /// <summary>
        /// library: NodeLibrary;
        /// </summary>
        public NodeLibrary Library { get => JSRef!.Get<NodeLibrary>("library"); set => JSRef!.Set("library", value); }
        /// <summary>
        /// lighting: Lighting;
        /// </summary>
        public Lighting Lighting { get => JSRef!.Get<Lighting>("lighting"); set => JSRef!.Set("lighting", value); }
        /// <summary>
        /// localClippingEnabled?: boolean | undefined;
        /// </summary>
        public bool LocalClippingEnabled { get => JSRef!.Get<bool>("localClippingEnabled"); set => JSRef!.Set("localClippingEnabled", value); }
        /// <summary>
        /// logarithmicDepthBuffer: boolean;
        /// </summary>
        public bool LogarithmicDepthBuffer { get => JSRef!.Get<bool>("logarithmicDepthBuffer"); set => JSRef!.Set("logarithmicDepthBuffer", value); }
        /// <summary>
        /// onDeviceLost: (info: DeviceLostInfo) => void;
        /// </summary>
        public Callback OnDeviceLost { get => JSRef!.Get<Callback>("onDeviceLost"); set => JSRef!.Set("onDeviceLost", value); }
        /// <summary>
        /// opaque: boolean;
        /// </summary>
        public bool Opaque { get => JSRef!.Get<bool>("opaque"); set => JSRef!.Set("opaque", value); }
        /// <summary>
        /// outputColorSpace: string;
        /// </summary>
        public string OutputColorSpace { get => JSRef!.Get<string>("outputColorSpace"); set => JSRef!.Set("outputColorSpace", value); }
        /// <summary>
        /// samples: number;
        /// </summary>
        public float Samples { get => JSRef!.Get<float>("samples"); set => JSRef!.Set("samples", value); }
        /// <summary>
        /// shadowMap: {
        ///         enabled: boolean;
        ///         type: ShadowMapType | null;
        ///     };
        /// </summary>
        public object ShadowMap { get => JSRef!.Get<object>("shadowMap"); set => JSRef!.Set("shadowMap", value); }
        /// <summary>
        /// sortObjects: boolean;
        /// </summary>
        public bool SortObjects { get => JSRef!.Get<bool>("sortObjects"); set => JSRef!.Set("sortObjects", value); }
        /// <summary>
        /// stencil: boolean;
        /// </summary>
        public bool Stencil { get => JSRef!.Get<bool>("stencil"); set => JSRef!.Set("stencil", value); }
        /// <summary>
        /// toneMapping: ToneMapping;
        /// </summary>
        public ToneMapping ToneMapping { get => JSRef!.Get<ToneMapping>("toneMapping"); set => JSRef!.Set("toneMapping", value); }
        /// <summary>
        /// toneMappingExposure: number;
        /// </summary>
        public float ToneMappingExposure { get => JSRef!.Get<float>("toneMappingExposure"); set => JSRef!.Set("toneMappingExposure", value); }
        /// <summary>
        /// transparent: boolean;
        /// </summary>
        public bool Transparent { get => JSRef!.Get<bool>("transparent"); set => JSRef!.Set("transparent", value); }
        /// <summary>
        /// TypedArray>;
        /// </summary>
        public TypedArray TypedArray { get => JSRef!.Get<TypedArray>("TypedArray"); set => JSRef!.Set("TypedArray", value); }
        /// <summary>
        /// xr: XRManager;
        /// </summary>
        public XRManager Xr { get => JSRef!.Get<XRManager>("xr"); set => JSRef!.Set("xr", value); }
        #endregion

        #region Methods
        /// <summary>
        /// waitForGPU(): Promise<void>;
        /// </summary>
        public Task WaitForGPU()
        {
            return JSRef!.CallVoidAsync("waitForGPU");
        }
        /// <summary>
        /// setViewport(x: Vector4): void;
        /// </summary>
        public void SetViewport(Vector4 x)
        {
            JSRef!.CallVoid("setViewport", x);
        }
        /// <summary>
        /// setViewport(x: number, y: number, width: number, height: number, minDepth?: number, maxDepth?: number): void;
        /// </summary>
        public void SetViewport(float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            JSRef!.CallVoid("setViewport", x, y, width, height, minDepth, maxDepth);
        }
        /// <summary>
        /// setTransparentSort(method: ((a: RenderItem, b: RenderItem) => number) | null): void;
        /// </summary>
        public void SetTransparentSort(Callback method, RenderItem a, RenderItem b)
        {
            JSRef!.CallVoid("setTransparentSort", method, a, b);
        }
        /// <summary>
        /// setSize(width: number, height: number, updateStyle?: boolean): void;
        /// </summary>
        public void SetSize(float width, float height, bool updateStyle)
        {
            JSRef!.CallVoid("setSize", width, height, updateStyle);
        }
        /// <summary>
        /// setScissorTest(boolean: boolean): void;
        /// </summary>
        public void SetScissorTest(bool boolean)
        {
            JSRef!.CallVoid("setScissorTest", boolean);
        }
        /// <summary>
        /// setScissor(x: Vector4): void;
        /// </summary>
        public void SetScissor(Vector4 x)
        {
            JSRef!.CallVoid("setScissor", x);
        }
        /// <summary>
        /// setScissor(x: number, y: number, width: number, height: number): void;
        /// </summary>
        public void SetScissor(float x, float y, float width, float height)
        {
            JSRef!.CallVoid("setScissor", x, y, width, height);
        }
        /// <summary>
        /// setRenderTarget(renderTarget: RenderTarget | null, activeCubeFace?: number, activeMipmapLevel?: number): void;
        /// </summary>
        public void SetRenderTarget(RenderTarget renderTarget, float activeCubeFace, float activeMipmapLevel)
        {
            JSRef!.CallVoid("setRenderTarget", renderTarget, activeCubeFace, activeMipmapLevel);
        }
        /// <summary>
        /// setRenderObjectFunction(
        ///         renderObjectFunction:
        ///             | ((
        ///                 object: Object3D,
        ///                 scene: Scene,
        ///                 camera: Camera,
        ///                 geometry: BufferGeometry,
        ///                 material: Material,
        ///                 group: GeometryGroup,
        ///                 lightsNode: LightsNode,
        ///             ) => void)
        ///             | null,
        ///     ): void;
        /// </summary>
        public void SetRenderObjectFunction(Callback renderObjectFunction, Object3D obj, Scene scene, Camera camera, BufferGeometry geometry, Material material, GeometryGroup group, LightsNode lightsNode)
        {
            JSRef!.CallVoid("setRenderObjectFunction", renderObjectFunction, obj, scene, camera, geometry, material, group, lightsNode);
        }
        /// <summary>
        /// setPixelRatio(value?: number): void;
        /// </summary>
        public void SetPixelRatio(float value)
        {
            JSRef!.CallVoid("setPixelRatio", value);
        }
        /// <summary>
        /// setOutputRenderTarget(renderTarget: RenderTarget | null): void;
        /// </summary>
        public void SetOutputRenderTarget(RenderTarget renderTarget)
        {
            JSRef!.CallVoid("setOutputRenderTarget", renderTarget);
        }
        /// <summary>
        /// setOpaqueSort(method: ((a: RenderItem, b: RenderItem) => number) | null): void;
        /// </summary>
        public void SetOpaqueSort(Callback method, RenderItem a, RenderItem b)
        {
            JSRef!.CallVoid("setOpaqueSort", method, a, b);
        }
        /// <summary>
        /// setMRT(mrt: MRTNode | null): this;
        /// </summary>
        public Renderer SetMRT(MRTNode mrt)
        {
            return JSRef!.Call<Renderer>("setMRT", mrt);
        }
        /// <summary>
        /// setDrawingBufferSize(width: number, height: number, pixelRatio: number): void;
        /// </summary>
        public void SetDrawingBufferSize(float width, float height, float pixelRatio)
        {
            JSRef!.CallVoid("setDrawingBufferSize", width, height, pixelRatio);
        }
        /// <summary>
        /// setClearStencil(stencil: number): void;
        /// </summary>
        public void SetClearStencil(float stencil)
        {
            JSRef!.CallVoid("setClearStencil", stencil);
        }
        /// <summary>
        /// setClearDepth(depth: number): void;
        /// </summary>
        public void SetClearDepth(float depth)
        {
            JSRef!.CallVoid("setClearDepth", depth);
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
        /// setAnimationLoop(callback: ((time: DOMHighResTimeStamp, frame?: XRFrame) => void) | null): Promise<void>;
        /// </summary>
        public Task SetAnimationLoop(Callback callback, DOMHighResTimeStamp time, XRFrame frame)
        {
            return JSRef!.CallVoidAsync("setAnimationLoop", callback, time, frame);
        }
        /// <summary>
        /// resolveTimestampsAsync(type?: TimestampQuery): Promise<number | undefined>;
        /// </summary>
        public Task<float> ResolveTimestampsAsync(TimestampQuery type)
        {
            return JSRef!.CallAsync<float>("resolveTimestampsAsync", type);
        }
        /// <summary>
        /// renderObject(
        ///         object: Object3D,
        ///         scene: Scene,
        ///         camera: Camera,
        ///         geometry: BufferGeometry,
        ///         material: Material,
        ///         group: GeometryGroup,
        ///         lightsNode: LightsNode,
        ///         clippingContext?: ClippingContext | null,
        ///         passId?: string | null,
        ///     ): void;
        /// </summary>
        public void RenderObject(Object3D obj, Scene scene, Camera camera, BufferGeometry geometry, Material material, GeometryGroup group, LightsNode lightsNode, ClippingContext clippingContext, string passId)
        {
            JSRef!.CallVoid("renderObject", obj, scene, camera, geometry, material, group, lightsNode, clippingContext, passId);
        }
        /// <summary>
        /// renderAsync(scene: Object3D, camera: Camera): Promise<void>;
        /// </summary>
        public Task RenderAsync(Object3D scene, Camera camera)
        {
            return JSRef!.CallVoidAsync("renderAsync", scene, camera);
        }
        /// <summary>
        /// render(scene: Object3D, camera: Camera): Promise<void> | undefined;
        /// </summary>
        public Task Render(Object3D scene, Camera camera)
        {
            return JSRef!.CallVoidAsync("render", scene, camera);
        }
        /// <summary>
        /// readRenderTargetPixelsAsync(
        ///         renderTarget: RenderTarget,
        ///         x: number,
        ///         y: number,
        ///         width: number,
        ///         height: number,
        ///         textureIndex?: number,
        ///         faceIndex?: number,
        ///     ): Promise<
        /// </summary>
        public object ReadRenderTargetPixelsAsync(RenderTarget renderTarget, float x, float y, float width, float height, float textureIndex, float faceIndex)
        {
            return JSRef!.Call<object>("readRenderTargetPixelsAsync", renderTarget, x, y, width, height, textureIndex, faceIndex);
        }
        /// <summary>
        /// isOccluded(object: Object3D): boolean | null;
        /// </summary>
        public bool IsOccluded(Object3D obj)
        {
            return JSRef!.Call<bool>("isOccluded", obj);
        }
        /// <summary>
        /// initTextureAsync(texture: Texture): Promise<void>;
        /// </summary>
        public Task InitTextureAsync(Texture texture)
        {
            return JSRef!.CallVoidAsync("initTextureAsync", texture);
        }
        /// <summary>
        /// initTexture(texture: Texture): void;
        /// </summary>
        public void InitTexture(Texture texture)
        {
            JSRef!.CallVoid("initTexture", texture);
        }
        /// <summary>
        /// init(): Promise<this>;
        /// </summary>
        public Task<Renderer> Init()
        {
            return JSRef!.CallAsync<Renderer>("init");
        }
        ///// <summary>
        ///// import(
        ///// </summary>
        //public object Import()
        //{
        //    return JSRef!.Call<object>("import");
        //}
        ///// <summary>
        ///// import(
        ///// </summary>
        //public object Import()
        //{
        //    return JSRef!.Call<object>("import");
        //}
        /// <summary>
        /// hasInitialized(): boolean;
        /// </summary>
        public bool HasInitialized()
        {
            return JSRef!.Call<bool>("hasInitialized");
        }
        /// <summary>
        /// hasFeatureAsync(name: string): Promise<void>;
        /// </summary>
        public Task HasFeatureAsync(string name)
        {
            return JSRef!.CallVoidAsync("hasFeatureAsync", name);
        }
        /// <summary>
        /// hasFeature(name: string): false | void;
        /// </summary>
        public bool HasFeature(string name)
        {
            return JSRef!.Call<bool>("hasFeature", name);
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
        /// getRenderTarget(): RenderTarget<Texture> | null;
        /// </summary>
        public RenderTarget<Texture> GetRenderTarget()
        {
            return JSRef!.Call<RenderTarget<Texture>>("getRenderTarget");
        }
        /// <summary>
        /// getRenderObjectFunction():
        ///         | ((
        ///             object: Object3D,
        ///             scene: Scene,
        ///             camera: Camera,
        ///             geometry: BufferGeometry,
        ///             material: Material,
        ///             group: GeometryGroup,
        ///             lightsNode: LightsNode,
        ///             clippingContext: ClippingContext | null,
        ///             passId: string | null,
        ///         ) => void)
        ///         | null;
        /// </summary>
        public Callback GetRenderObjectFunction(Object3D obj, Scene scene, Camera camera, BufferGeometry geometry, Material material, GeometryGroup group, LightsNode lightsNode, ClippingContext clippingContext, string passId)
        {
            return JSRef!.Call<Callback>("getRenderObjectFunction", obj, scene, camera, geometry, material, group, lightsNode, clippingContext, passId);
        }
        /// <summary>
        /// getPixelRatio(): number;
        /// </summary>
        public float GetPixelRatio()
        {
            return JSRef!.Call<float>("getPixelRatio");
        }
        /// <summary>
        /// getOutputRenderTarget(): RenderTarget<Texture> | null;
        /// </summary>
        public RenderTarget<Texture> GetOutputRenderTarget()
        {
            return JSRef!.Call<RenderTarget<Texture>>("getOutputRenderTarget");
        }
        /// <summary>
        /// getMRT(): MRTNode | null;
        /// </summary>
        public MRTNode GetMRT()
        {
            return JSRef!.Call<MRTNode>("getMRT");
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
        /// getContext(): void;
        /// </summary>
        public void GetContext()
        {
            JSRef!.CallVoid("getContext");
        }
        /// <summary>
        /// getColorBufferType(): TextureDataType;
        /// </summary>
        public TextureDataType GetColorBufferType()
        {
            return JSRef!.Call<TextureDataType>("getColorBufferType");
        }
        /// <summary>
        /// getClearStencil(): number;
        /// </summary>
        public float GetClearStencil()
        {
            return JSRef!.Call<float>("getClearStencil");
        }
        /// <summary>
        /// getClearDepth(): number;
        /// </summary>
        public float GetClearDepth()
        {
            return JSRef!.Call<float>("getClearDepth");
        }
        /// <summary>
        /// getClearColor(target: Color4): Color4;
        /// </summary>
        public Color4 GetClearColor(Color4 target)
        {
            return JSRef!.Call<Color4>("getClearColor", target);
        }
        /// <summary>
        /// getClearAlpha(): number;
        /// </summary>
        public float GetClearAlpha()
        {
            return JSRef!.Call<float>("getClearAlpha");
        }
        /// <summary>
        /// getArrayBufferAsync(attribute: BufferAttribute): Promise<ArrayBuffer>;
        /// </summary>
        public Task<ArrayBuffer> GetArrayBufferAsync(BufferAttribute attribute)
        {
            return JSRef!.CallAsync<ArrayBuffer>("getArrayBufferAsync", attribute);
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
        /// copyFramebufferToTexture(framebufferTexture: FramebufferTexture, rectangle?: Rectangle | null): void;
        /// </summary>
        public void CopyFramebufferToTexture(FramebufferTexture framebufferTexture, Rectangle rectangle)
        {
            JSRef!.CallVoid("copyFramebufferToTexture", framebufferTexture, rectangle);
        }
        /// <summary>
        /// computeAsync(
        ///         computeNodes: ComputeNode | ComputeNode[],
        ///         dispatchSizeOrCount?: number[] | number | null,
        ///     ): Promise<void>;
        /// </summary>
        public Task ComputeAsync(Union<ComputeNode, Array<ComputeNode>> computeNodes, Union<Array<float>, float> dispatchSizeOrCount)
        {
            return JSRef!.CallVoidAsync("computeAsync", computeNodes, dispatchSizeOrCount);
        }
        /// <summary>
        /// compute(
        ///         computeNodes: ComputeNode | ComputeNode[],
        ///         dispatchSizeOrCount?: number[] | number | null,
        ///     ): Promise<void> | undefined;
        /// </summary>
        public Task Compute(Union<ComputeNode, Array<ComputeNode>> computeNodes, Union<Array<float>, float> dispatchSizeOrCount)
        {
            return JSRef!.CallVoidAsync("compute", computeNodes, dispatchSizeOrCount);
        }
        /// <summary>
        /// compileAsync(scene: Object3D, camera: Camera, targetScene?: Scene | null): Promise<void>;
        /// </summary>
        public Task CompileAsync(Object3D scene, Camera camera, Scene targetScene)
        {
            return JSRef!.CallVoidAsync("compileAsync", scene, camera, targetScene);
        }
        /// <summary>
        /// clearStencilAsync(): Promise<void>;
        /// </summary>
        public Task ClearStencilAsync()
        {
            return JSRef!.CallVoidAsync("clearStencilAsync");
        }
        /// <summary>
        /// clearStencil(): Promise<void> | undefined;
        /// </summary>
        public Task ClearStencil()
        {
            return JSRef!.CallVoidAsync("clearStencil");
        }
        /// <summary>
        /// clearDepthAsync(): Promise<void>;
        /// </summary>
        public Task ClearDepthAsync()
        {
            return JSRef!.CallVoidAsync("clearDepthAsync");
        }
        /// <summary>
        /// clearDepth(): Promise<void> | undefined;
        /// </summary>
        public Task ClearDepth()
        {
            return JSRef!.CallVoidAsync("clearDepth");
        }
        /// <summary>
        /// clearColorAsync(): Promise<void>;
        /// </summary>
        public Task ClearColorAsync()
        {
            return JSRef!.CallVoidAsync("clearColorAsync");
        }
        /// <summary>
        /// clearColor(): Promise<void> | undefined;
        /// </summary>
        public Task ClearColor()
        {
            return JSRef!.CallVoidAsync("clearColor");
        }
        /// <summary>
        /// clearAsync(color?: boolean, depth?: boolean, stencil?: boolean): Promise<void>;
        /// </summary>
        public Task ClearAsync(bool color, bool depth, bool stencil)
        {
            return JSRef!.CallVoidAsync("clearAsync", color, depth, stencil);
        }
        /// <summary>
        /// clear(color?: boolean, depth?: boolean, stencil?: boolean): Promise<void> | undefined;
        /// </summary>
        public Task Clear(bool color, bool depth, bool stencil)
        {
            return JSRef!.CallVoidAsync("clear", color, depth, stencil);
        }
        #endregion
    }
}
