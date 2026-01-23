using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Intersection<TIntersected> : Intersection
    {
        /// <inheritdoc/>
        public Intersection(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// The intersected object
        /// </summary>
        public new TIntersected Object => JSRef!.Get<TIntersected>("object");
    }
    
    public class Intersection : JSObject
    {
        /// <inheritdoc/>
        public Intersection(IJSInProcessObjectReference _ref) : base(_ref) { }

        #region Properties
        /// <summary>
        /// barycoord?: Vector3 | null;
        /// </summary>
        public Vector3? Barycoord => JSRef!.Get<Vector3?>("barycoord");
        /// <summary>
        /// batchId?: number;
        /// </summary>
        public float? BatchId => JSRef!.Get<float?>("batchId");
        /// <summary>
        /// distance: number;
        /// </summary>
        public float Distance => JSRef!.Get<float>("distance");
        /// <summary>
        /// distanceToRay?: number | undefined;
        /// </summary>
        public float? DistanceToRay => JSRef!.Get<float?>("distanceToRay");
        /// <summary>
        /// face?: Face | null | undefined;
        /// </summary>
        public Face? Face => JSRef!.Get<Face?>("face");
        /// <summary>
        /// faceIndex?: number | null | undefined;
        /// </summary>
        public int? FaceIndex => JSRef!.Get<int?>("faceIndex");
        /// <summary>
        /// index?: number | undefined;
        /// </summary>
        public int? Index => JSRef!.Get<int?>("index");
        /// <summary>
        /// instanceId?: number | undefined;
        /// </summary>
        public int? InstanceId => JSRef!.Get<int?>("instanceId");
        /// <summary>
        /// normal?: Vector3;
        /// </summary>
        public Vector3? Normal => JSRef!.Get<Vector3?>("normal");
        /// <summary>
        /// object: Object3D - The intersected object
        /// </summary>
        public Object3D Object => JSRef!.Get<Object3D>("object");
        /// <summary>
        /// point: Vector3;
        /// </summary>
        public Vector3 Point => JSRef!.Get<Vector3>("point");
        /// <summary>
        /// pointOnLine?: Vector3;
        /// </summary>
        public Vector3? PointOnLine => JSRef!.Get<Vector3?>("pointOnLine");
        /// <summary>
        /// uv?: Vector2 | undefined;
        /// </summary>
        public Vector2? Uv => JSRef!.Get<Vector2?>("uv");
        /// <summary>
        /// uv1?: Vector2 | undefined;
        /// </summary>
        public Vector2? Uv1 => JSRef!.Get<Vector2?>("uv1");
        #endregion
    }
}
