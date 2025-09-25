
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeMaterialObserver : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeMaterialObserver(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(builder: NodeBuilder);
        /// </summary>
        public NodeMaterialObserver(NodeBuilder builder) : base(JS.New("THREE.NodeMaterialObserver", builder)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// hasAnimation: boolean;
        /// </summary>
        public bool HasAnimation { get => JSRef!.Get<bool>("hasAnimation"); set => JSRef!.Set("hasAnimation", value); }
        /// <summary>
        /// hasNode: boolean;
        /// </summary>
        public bool HasNode { get => JSRef!.Get<bool>("hasNode"); set => JSRef!.Set("hasNode", value); }
        /// <summary>
        /// refreshUniforms: readonlyRefreshUniform[];
        /// </summary>
        public Array<RefreshUniform> RefreshUniforms { get => JSRef!.Get<Array<RefreshUniform>>("refreshUniforms"); set => JSRef!.Set("refreshUniforms", value); }
        /// <summary>
        /// renderId: number;
        /// </summary>
        public float RenderId { get => JSRef!.Get<float>("renderId"); set => JSRef!.Set("renderId", value); }
        /// <summary>
        /// renderObjects: WeakMap<RenderObject, RenderObjectData>;
        /// </summary>
        public WeakMap<RenderObject, RenderObjectData> RenderObjects { get => JSRef!.Get<WeakMap<RenderObject, RenderObjectData>>("renderObjects"); set => JSRef!.Set("renderObjects", value); }
        #endregion

        #region Methods
        /// <summary>
        /// needsVelocity(renderer: Renderer): boolean;
        /// </summary>
        public bool NeedsVelocity(Renderer renderer)
        {
            return JSRef!.Call<bool>("needsVelocity", renderer);
        }
        /// <summary>
        /// needsRefresh(renderObject: RenderObject, nodeFrame: NodeFrame): boolean;
        /// </summary>
        public bool NeedsRefresh(RenderObject renderObject, NodeFrame nodeFrame)
        {
            return JSRef!.Call<bool>("needsRefresh", renderObject, nodeFrame);
        }
        /// <summary>
        /// getRenderObjectData(renderObject: RenderObject): RenderObjectData;
        /// </summary>
        public RenderObjectData GetRenderObjectData(RenderObject renderObject)
        {
            return JSRef!.Call<RenderObjectData>("getRenderObjectData", renderObject);
        }
        /// <summary>
        /// getMaterialData(material: Material): MaterialData;
        /// </summary>
        public MaterialData GetMaterialData(Material material)
        {
            return JSRef!.Call<MaterialData>("getMaterialData", material);
        }
        /// <summary>
        /// getLightsData(materialLights: Light[]): LightData[];
        /// </summary>
        public Array<LightData> GetLightsData(Array<Light> materialLights)
        {
            return JSRef!.Call<Array<LightData>>("getLightsData", materialLights);
        }
        /// <summary>
        /// getLights(lightsNode: LightsNode, renderId: number): LightData[];
        /// </summary>
        public Array<LightData> GetLights(LightsNode lightsNode, float renderId)
        {
            return JSRef!.Call<Array<LightData>>("getLights", lightsNode, renderId);
        }
        /// <summary>
        /// getAttributesData(attributes: Record<string, BufferAttribute>): AttributesData;
        /// </summary>
        public AttributesData GetAttributesData(Record<string, BufferAttribute> attributes)
        {
            return JSRef!.Call<AttributesData>("getAttributesData", attributes);
        }
        /// <summary>
        /// firstInitialization(renderObject: RenderObject): boolean;
        /// </summary>
        public bool FirstInitialization(RenderObject renderObject)
        {
            return JSRef!.Call<bool>("firstInitialization", renderObject);
        }
        /// <summary>
        /// equals(renderObject: RenderObject, lightsData: Light[]): boolean;
        /// </summary>
        public bool Equals(RenderObject renderObject, Array<Light> lightsData)
        {
            return JSRef!.Call<bool>("equals", renderObject, lightsData);
        }
        /// <summary>
        /// containsNode(builder: NodeBuilder): boolean;
        /// </summary>
        public bool ContainsNode(NodeBuilder builder)
        {
            return JSRef!.Call<bool>("containsNode", builder);
        }
        #endregion
    }
}
