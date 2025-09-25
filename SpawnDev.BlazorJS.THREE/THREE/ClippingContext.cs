
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ClippingContext : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public ClippingContext(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parentContext?: ClippingContext | null);
        /// </summary>
        public ClippingContext(ClippingContext parentContext) : base(JS.New("THREE.ClippingContext", parentContext)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// cacheKey: string;
        /// </summary>
        public string CacheKey { get => JSRef!.Get<string>("cacheKey"); set => JSRef!.Set("cacheKey", value); }
        /// <summary>
        /// clipIntersection: boolean | null;
        /// </summary>
        public bool ClipIntersection { get => JSRef!.Get<bool>("clipIntersection"); set => JSRef!.Set("clipIntersection", value); }
        /// <summary>
        /// clippingGroupContexts: WeakMap<ClippingGroup, ClippingContext>;
        /// </summary>
        public WeakMap<ClippingGroup, ClippingContext> ClippingGroupContexts { get => JSRef!.Get<WeakMap<ClippingGroup, ClippingContext>>("clippingGroupContexts"); set => JSRef!.Set("clippingGroupContexts", value); }
        /// <summary>
        /// intersectionPlanes?: Plane[];
        /// </summary>
        public Array<Plane> IntersectionPlanes { get => JSRef!.Get<Array<Plane>>("intersectionPlanes"); set => JSRef!.Set("intersectionPlanes", value); }
        /// <summary>
        /// parentVersion: number | null;
        /// </summary>
        public float ParentVersion { get => JSRef!.Get<float>("parentVersion"); set => JSRef!.Set("parentVersion", value); }
        /// <summary>
        /// shadowPass: boolean;
        /// </summary>
        public bool ShadowPass { get => JSRef!.Get<bool>("shadowPass"); set => JSRef!.Set("shadowPass", value); }
        /// <summary>
        /// get unionClippingCount(): number;
        /// </summary>
        public float UnionClippingCount { get => JSRef!.Get<float>("unionClippingCount"); }
        /// <summary>
        /// unionPlanes?: Plane[];
        /// </summary>
        public Array<Plane> UnionPlanes { get => JSRef!.Get<Array<Plane>>("unionPlanes"); set => JSRef!.Set("unionPlanes", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        /// <summary>
        /// viewMatrix?: Matrix4;
        /// </summary>
        public Matrix4 ViewMatrix { get => JSRef!.Get<Matrix4>("viewMatrix"); set => JSRef!.Set("viewMatrix", value); }
        /// <summary>
        /// viewNormalMatrix: Matrix3;
        /// </summary>
        public Matrix3 ViewNormalMatrix { get => JSRef!.Get<Matrix3>("viewNormalMatrix"); set => JSRef!.Set("viewNormalMatrix", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateGlobal(scene: Scene, camera: Camera): void;
        /// </summary>
        public void UpdateGlobal(Scene scene, Camera camera)
        {
            JSRef!.CallVoid("updateGlobal", scene, camera);
        }
        /// <summary>
        /// update(parentContext: ClippingContext, clippingGroup: ClippingGroup): void;
        /// </summary>
        public void Update(ClippingContext parentContext, ClippingGroup clippingGroup)
        {
            JSRef!.CallVoid("update", parentContext, clippingGroup);
        }
        /// <summary>
        /// projectPlanes(source: readonlyPlane[], destination: readonlyVector4[], offset: number): void;
        /// </summary>
        public void ProjectPlanes(Array<Plane> source, Array<Vector4> destination, float offset)
        {
            JSRef!.CallVoid("projectPlanes", source, destination, offset);
        }
        /// <summary>
        /// getGroupContext(clippingGroup: ClippingGroup): ClippingContext;
        /// </summary>
        public ClippingContext GetGroupContext(ClippingGroup clippingGroup)
        {
            return JSRef!.Call<ClippingContext>("getGroupContext", clippingGroup);
        }
        #endregion
    }
}
