
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderObject : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderObject(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(
        ///         nodes: Nodes,
        ///         geometries: Geometries,
        ///         renderer: Renderer,
        ///         object: Object3D,
        ///         material: Material,
        ///         scene: Scene,
        ///         camera: Camera,
        ///         lightsNode: LightsNode,
        ///         renderContext: RenderContext,
        ///         clippingContext: ClippingContext | null,
        ///     );
        /// </summary>
        public RenderObject(Nodes nodes, Geometries geometries, Renderer renderer, Object3D obj, Material material, Scene scene, Camera camera, LightsNode lightsNode, RenderContext renderContext, ClippingContext clippingContext) : base(JS.New("THREE.RenderObject", nodes, geometries, renderer, obj, material, scene, camera, lightsNode, renderContext, clippingContext)) { }

        #endregion

        #region Properties
        /// <summary>
        /// attributes: Array<BufferAttribute | InterleavedBufferAttribute> | null;
        /// </summary>
        public Array<Union<BufferAttribute, InterleavedBufferAttribute>> Attributes { get => JSRef!.Get<Array<Union<BufferAttribute, InterleavedBufferAttribute>>>("attributes"); set => JSRef!.Set("attributes", value); }
        /// <summary>
        /// attributesId: {
        ///         [attributeName: string]: number;
        ///     } | null;
        /// </summary>
        public object AttributesId { get => JSRef!.Get<object>("attributesId"); set => JSRef!.Set("attributesId", value); }
        /// <summary>
        /// bundle: BundleGroup | null;
        /// </summary>
        public BundleGroup Bundle { get => JSRef!.Get<BundleGroup>("bundle"); set => JSRef!.Set("bundle", value); }
        /// <summary>
        /// camera: Camera;
        /// </summary>
        public Camera Camera { get => JSRef!.Get<Camera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// clippingContext: ClippingContext | null;
        /// </summary>
        public ClippingContext ClippingContext { get => JSRef!.Get<ClippingContext>("clippingContext"); set => JSRef!.Set("clippingContext", value); }
        /// <summary>
        /// clippingContextCacheKey: string;
        /// </summary>
        public string ClippingContextCacheKey { get => JSRef!.Get<string>("clippingContextCacheKey"); set => JSRef!.Set("clippingContextCacheKey", value); }
        /// <summary>
        /// get clippingNeedsUpdate(): boolean;
        /// </summary>
        public bool ClippingNeedsUpdate { get => JSRef!.Get<bool>("clippingNeedsUpdate"); }
        /// <summary>
        /// context: RenderContext;
        /// </summary>
        public RenderContext Context { get => JSRef!.Get<RenderContext>("context"); set => JSRef!.Set("context", value); }
        /// <summary>
        /// drawParams: {
        ///         vertexCount: number;
        ///         firstVertex: number;
        ///         instanceCount: number;
        ///         firstInstance: number;
        ///     } | null;
        /// </summary>
        public object DrawParams { get => JSRef!.Get<object>("drawParams"); set => JSRef!.Set("drawParams", value); }
        /// <summary>
        /// drawRange: {
        ///         start: number;
        ///         count: number;
        ///     } | null;
        /// </summary>
        public object DrawRange { get => JSRef!.Get<object>("drawRange"); set => JSRef!.Set("drawRange", value); }
        /// <summary>
        /// geometry: BufferGeometry;
        /// </summary>
        public BufferGeometry Geometry { get => JSRef!.Get<BufferGeometry>("geometry"); set => JSRef!.Set("geometry", value); }
        /// <summary>
        /// group: {
        ///         start: number;
        ///         count: number;
        ///     } | null;
        /// </summary>
        public object Group { get => JSRef!.Get<object>("group"); set => JSRef!.Set("group", value); }
        /// <summary>
        /// get hardwareClippingPlanes(): number;
        /// </summary>
        public float HardwareClippingPlanes { get => JSRef!.Get<float>("hardwareClippingPlanes"); }
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// initialCacheKey: number;
        /// </summary>
        public float InitialCacheKey { get => JSRef!.Get<float>("initialCacheKey"); set => JSRef!.Set("initialCacheKey", value); }
        /// <summary>
        /// initialNodesCacheKey: number;
        /// </summary>
        public float InitialNodesCacheKey { get => JSRef!.Get<float>("initialNodesCacheKey"); set => JSRef!.Set("initialNodesCacheKey", value); }
        /// <summary>
        /// readonly isRenderObject: true;
        /// </summary>
        public bool IsRenderObject { get => JSRef!.Get<bool>("isRenderObject"); }
        /// <summary>
        /// lightsNode: LightsNode;
        /// </summary>
        public LightsNode LightsNode { get => JSRef!.Get<LightsNode>("lightsNode"); set => JSRef!.Set("lightsNode", value); }
        /// <summary>
        /// material: Material;
        /// </summary>
        public Material Material { get => JSRef!.Get<Material>("material"); set => JSRef!.Set("material", value); }
        /// <summary>
        /// object: Object3D;
        /// </summary>
        public Object3D Object { get => JSRef!.Get<Object3D>("object"); set => JSRef!.Set("object", value); }
        /// <summary>
        /// onDispose: (() => void) | null;
        /// </summary>
        public Callback OnDispose { get => JSRef!.Get<Callback>("onDispose"); set => JSRef!.Set("onDispose", value); }
        /// <summary>
        /// onGeometryDispose: () => void;
        /// </summary>
        public Callback OnGeometryDispose { get => JSRef!.Get<Callback>("onGeometryDispose"); set => JSRef!.Set("onGeometryDispose", value); }
        /// <summary>
        /// onMaterialDispose: () => void;
        /// </summary>
        public Callback OnMaterialDispose { get => JSRef!.Get<Callback>("onMaterialDispose"); set => JSRef!.Set("onMaterialDispose", value); }
        /// <summary>
        /// pipeline: RenderPipeline | null;
        /// </summary>
        public RenderPipeline Pipeline { get => JSRef!.Get<RenderPipeline>("pipeline"); set => JSRef!.Set("pipeline", value); }
        /// <summary>
        /// renderer: Renderer;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        /// <summary>
        /// scene: Scene;
        /// </summary>
        public Scene Scene { get => JSRef!.Get<Scene>("scene"); set => JSRef!.Set("scene", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        /// <summary>
        /// vertexBuffers: Array<BufferAttribute | InterleavedBuffer> | null;
        /// </summary>
        public Array<Union<BufferAttribute, InterleavedBuffer>> VertexBuffers { get => JSRef!.Get<Array<Union<BufferAttribute, InterleavedBuffer>>>("vertexBuffers"); set => JSRef!.Set("vertexBuffers", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateClipping(context: ClippingContext): void;
        /// </summary>
        public void UpdateClipping(ClippingContext context)
        {
            JSRef!.CallVoid("updateClipping", context);
        }
        /// <summary>
        /// import(
        /// </summary>
        public object Import()
        {
            return JSRef!.Call<object>("import");
        }
        /// <summary>
        /// getNodeBuilderState(): NodeBuilderState;
        /// </summary>
        public NodeBuilderState GetNodeBuilderState()
        {
            return JSRef!.Call<NodeBuilderState>("getNodeBuilderState");
        }
        /// <summary>
        /// getMonitor(): NodeMaterialObserver;
        /// </summary>
        public NodeMaterialObserver GetMonitor()
        {
            return JSRef!.Call<NodeMaterialObserver>("getMonitor");
        }
        /// <summary>
        /// getIndirect():
        /// </summary>
        public object GetIndirect()
        {
            return JSRef!.Call<object>("getIndirect");
        }
        /// <summary>
        /// getIndex(): BufferAttribute | null;
        /// </summary>
        public BufferAttribute GetIndex()
        {
            return JSRef!.Call<BufferAttribute>("getIndex");
        }
        /// <summary>
        /// getBindings(): BindGroup[];
        /// </summary>
        public Array<BindGroup> GetBindings()
        {
            return JSRef!.Call<Array<BindGroup>>("getBindings");
        }
        /// <summary>
        /// getBindingGroup(name: string): BindGroup | undefined;
        /// </summary>
        public BindGroup GetBindingGroup(string name)
        {
            return JSRef!.Call<BindGroup>("getBindingGroup", name);
        }
        #endregion
    }
}
