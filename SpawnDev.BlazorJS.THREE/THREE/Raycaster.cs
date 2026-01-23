using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Raycaster : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Raycaster(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Creates a new Raycaster with default values
        /// </summary>
        public Raycaster() : base(JS.New("THREE.Raycaster")) { }

        /// <summary>
        /// constructor(origin?: Vector3, direction?: Vector3, near?: number, far?: number);
        /// </summary>
        public Raycaster(Vector3 origin, Vector3 direction, float near, float far) : base(JS.New("THREE.Raycaster", origin, direction, near, far)) { }

        #endregion

        #region Properties
        /// <summary>
        /// camera: Camera;
        /// </summary>
        public Camera Camera { get => JSRef!.Get<Camera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// far: number;
        /// </summary>
        public float Far { get => JSRef!.Get<float>("far"); set => JSRef!.Set("far", value); }
        /// <summary>
        /// layers: Layers;
        /// </summary>
        public Layers Layers { get => JSRef!.Get<Layers>("layers"); set => JSRef!.Set("layers", value); }
        /// <summary>
        /// near: number;
        /// </summary>
        public float Near { get => JSRef!.Get<float>("near"); set => JSRef!.Set("near", value); }
        /// <summary>
        /// params: RaycasterParameters;
        /// </summary>
        public RaycasterParameters Params { get => JSRef!.Get<RaycasterParameters>("params"); set => JSRef!.Set("params", value); }
        /// <summary>
        /// ray: Ray;
        /// </summary>
        public Ray Ray { get => JSRef!.Get<Ray>("ray"); set => JSRef!.Set("ray", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setFromXRController(controller: XRTargetRaySpace): this;
        /// </summary>
        public Raycaster SetFromXRController(XRTargetRaySpace controller)
        {
            return JSRef!.Call<Raycaster>("setFromXRController", controller);
        }
        /// <summary>
        /// setFromCamera(coords: Vector2, camera: Camera): void;
        /// </summary>
        public void SetFromCamera(Vector2 coords, Camera camera)
        {
            JSRef!.CallVoid("setFromCamera", coords, camera);
        }
        /// <summary>
        /// set(origin: Vector3, direction: Vector3): void;
        /// </summary>
        public void Set(Vector3 origin, Vector3 direction)
        {
            JSRef!.CallVoid("set", origin, direction);
        }
        /// <summary>
        /// intersectObjects&lt;TIntersected extends Object3D&gt;(
        ///         objects: Object3D[],
        ///         recursive?: boolean,
        ///         optionalTarget?: Array&lt;Intersection&lt;TIntersected&gt;&gt;,
        ///     ): Array&lt;Intersection&lt;TIntersected&gt;&gt;;
        /// </summary>
        public Array<Intersection<TIntersected>> IntersectObjects<TIntersected>(Array<Object3D> objects, bool recursive, Array<Intersection<TIntersected>> optionalTarget)
        {
            return JSRef!.Call<Array<Intersection<TIntersected>>>("intersectObjects", objects, recursive, optionalTarget);
        }
        /// <summary>
        /// Simplified IntersectObjects without optionalTarget
        /// </summary>
        public Intersection[] IntersectObjects(Object3D[] objects, bool recursive = false)
        {
            return JSRef!.Call<Intersection[]>("intersectObjects", objects, recursive);
        }
        /// <summary>
        /// intersectObject&lt;TIntersected extends Object3D&gt;(
        ///         object: Object3D,
        ///         recursive?: boolean,
        ///         optionalTarget?: Array&lt;Intersection&lt;TIntersected&gt;&gt;,
        ///     ): Array&lt;Intersection&lt;TIntersected&gt;&gt;;
        /// </summary>
        public Array<Intersection<TIntersected>> IntersectObject<TIntersected>(Object3D obj, bool recursive, Array<Intersection<TIntersected>> optionalTarget)
        {
            return JSRef!.Call<Array<Intersection<TIntersected>>>("intersectObject", obj, recursive, optionalTarget);
        }
        /// <summary>
        /// Simplified IntersectObject without optionalTarget
        /// </summary>
        public Intersection[] IntersectObject(Object3D obj, bool recursive = false)
        {
            return JSRef!.Call<Intersection[]>("intersectObject", obj, recursive);
        }
        #endregion
    }
}
