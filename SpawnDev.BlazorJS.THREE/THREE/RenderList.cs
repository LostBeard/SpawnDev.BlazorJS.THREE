
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderList : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderList(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(lighting: Lighting, scene: Object3D, camera: Camera);
        /// </summary>
        public RenderList(Lighting lighting, Object3D scene, Camera camera) : base(JS.New("THREE.RenderList", lighting, scene, camera)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bundles: Bundle[];
        /// </summary>
        public Array<Bundle> Bundles { get => JSRef!.Get<Array<Bundle>>("bundles"); set => JSRef!.Set("bundles", value); }
        /// <summary>
        /// camera: Camera;
        /// </summary>
        public Camera Camera { get => JSRef!.Get<Camera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// lightsArray: Light[];
        /// </summary>
        public Array<Light> LightsArray { get => JSRef!.Get<Array<Light>>("lightsArray"); set => JSRef!.Set("lightsArray", value); }
        /// <summary>
        /// lightsNode: LightsNode;
        /// </summary>
        public LightsNode LightsNode { get => JSRef!.Get<LightsNode>("lightsNode"); set => JSRef!.Set("lightsNode", value); }
        /// <summary>
        /// occlusionQueryCount: number;
        /// </summary>
        public float OcclusionQueryCount { get => JSRef!.Get<float>("occlusionQueryCount"); set => JSRef!.Set("occlusionQueryCount", value); }
        /// <summary>
        /// opaque: RenderItem[];
        /// </summary>
        public Array<RenderItem> Opaque { get => JSRef!.Get<Array<RenderItem>>("opaque"); set => JSRef!.Set("opaque", value); }
        /// <summary>
        /// renderItems: RenderItem[];
        /// </summary>
        public Array<RenderItem> RenderItems { get => JSRef!.Get<Array<RenderItem>>("renderItems"); set => JSRef!.Set("renderItems", value); }
        /// <summary>
        /// renderItemsIndex: number;
        /// </summary>
        public float RenderItemsIndex { get => JSRef!.Get<float>("renderItemsIndex"); set => JSRef!.Set("renderItemsIndex", value); }
        /// <summary>
        /// scene: Object3D;
        /// </summary>
        public Object3D Scene { get => JSRef!.Get<Object3D>("scene"); set => JSRef!.Set("scene", value); }
        /// <summary>
        /// transparent: RenderItem[];
        /// </summary>
        public Array<RenderItem> Transparent { get => JSRef!.Get<Array<RenderItem>>("transparent"); set => JSRef!.Set("transparent", value); }
        /// <summary>
        /// transparentDoublePass: RenderItem[];
        /// </summary>
        public Array<RenderItem> TransparentDoublePass { get => JSRef!.Get<Array<RenderItem>>("transparentDoublePass"); set => JSRef!.Set("transparentDoublePass", value); }
        #endregion

        #region Methods
        /// <summary>
        /// unshift(
        ///         object: Object3D,
        ///         geometry: BufferGeometry,
        ///         material: Material,
        ///         groupOrder: number,
        ///         z: number,
        ///         group: GeometryGroup | null,
        ///         clippingContext: ClippingContext | null,
        ///     ): void;
        /// </summary>
        public void Unshift(Object3D obj, BufferGeometry geometry, Material material, float groupOrder, float z, GeometryGroup group, ClippingContext clippingContext)
        {
            JSRef!.CallVoid("unshift", obj, geometry, material, groupOrder, z, group, clippingContext);
        }
        /// <summary>
        /// sort(
        ///         customOpaqueSort: ((a: RenderItem, b: RenderItem) => number) | null,
        ///         customTransparentSort: ((a: RenderItem, b: RenderItem) => number) | null,
        ///     ): void;
        /// </summary>
        public void Sort(ActionCallback<RenderItem, RenderItem> customOpaqueSort, ActionCallback<RenderItem, RenderItem> customTransparentSort)
        {
            JSRef!.CallVoid("sort", customOpaqueSort, customTransparentSort);
        }
        /// <summary>
        /// pushLight(light: Light): void;
        /// </summary>
        public void PushLight(Light light)
        {
            JSRef!.CallVoid("pushLight", light);
        }
        /// <summary>
        /// pushBundle(group: Bundle): void;
        /// </summary>
        public void PushBundle(Bundle group)
        {
            JSRef!.CallVoid("pushBundle", group);
        }
        /// <summary>
        /// push(
        ///         object: Object3D,
        ///         geometry: BufferGeometry,
        ///         material: Material,
        ///         groupOrder: number,
        ///         z: number,
        ///         group: GeometryGroup | null,
        ///         clippingContext: ClippingContext | null,
        ///     ): void;
        /// </summary>
        public void Push(Object3D obj, BufferGeometry geometry, Material material, float groupOrder, float z, GeometryGroup group, ClippingContext clippingContext)
        {
            JSRef!.CallVoid("push", obj, geometry, material, groupOrder, z, group, clippingContext);
        }
        /// <summary>
        /// getNextRenderItem(
        ///         object: Object3D,
        ///         geometry: BufferGeometry,
        ///         material: Material,
        ///         groupOrder: number,
        ///         z: number,
        ///         group: GeometryGroup | null,
        ///         clippingContext: ClippingContext | null,
        ///     ): RenderItem;
        /// </summary>
        public RenderItem GetNextRenderItem(Object3D obj, BufferGeometry geometry, Material material, float groupOrder, float z, GeometryGroup group, ClippingContext clippingContext)
        {
            return JSRef!.Call<RenderItem>("getNextRenderItem", obj, geometry, material, groupOrder, z, group, clippingContext);
        }
        /// <summary>
        /// finish(): void;
        /// </summary>
        public void Finish()
        {
            JSRef!.CallVoid("finish");
        }
        /// <summary>
        /// begin(): this;
        /// </summary>
        public RenderList Begin()
        {
            return JSRef!.Call<RenderList>("begin");
        }
        #endregion
    }
}
