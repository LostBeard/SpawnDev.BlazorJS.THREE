
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Ray : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Ray(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(origin?: Vector3, direction?: Vector3);
        /// </summary>
        public Ray(Vector3 origin, Vector3 direction) : base(JS.New("THREE.Ray", origin, direction)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// direction: Vector3;
        /// </summary>
        public Vector3 Direction { get => JSRef!.Get<Vector3>("direction"); set => JSRef!.Set("direction", value); }
        /// <summary>
        /// origin: Vector3;
        /// </summary>
        public Vector3 Origin { get => JSRef!.Get<Vector3>("origin"); set => JSRef!.Set("origin", value); }
        #endregion

        #region Methods
        /// <summary>
        /// set(origin: Vector3, direction: Vector3): Ray;
        /// </summary>
        public Ray Set(Vector3 origin, Vector3 direction)
        {
            return JSRef!.Call<Ray>("set", origin, direction);
        }
        /// <summary>
        /// recast(t: number): Ray;
        /// </summary>
        public Ray Recast(float t)
        {
            return JSRef!.Call<Ray>("recast", t);
        }
        /// <summary>
        /// lookAt(v: Vector3): Ray;
        /// </summary>
        public Ray LookAt(Vector3 v)
        {
            return JSRef!.Call<Ray>("lookAt", v);
        }
        /// <summary>
        /// isIntersectionSphere(s: any): any;
        /// </summary>
        public object IsIntersectionSphere(object s)
        {
            return JSRef!.Call<object>("isIntersectionSphere", s);
        }
        /// <summary>
        /// isIntersectionPlane(p: any): any;
        /// </summary>
        public object IsIntersectionPlane(object p)
        {
            return JSRef!.Call<object>("isIntersectionPlane", p);
        }
        /// <summary>
        /// isIntersectionBox(b: any): any;
        /// </summary>
        public object IsIntersectionBox(object b)
        {
            return JSRef!.Call<object>("isIntersectionBox", b);
        }
        /// <summary>
        /// intersectTriangle(a: Vector3, b: Vector3, c: Vector3, backfaceCulling: boolean, target: Vector3): Vector3 | null;
        /// </summary>
        public Vector3 IntersectTriangle(Vector3 a, Vector3 b, Vector3 c, bool backfaceCulling, Vector3 target)
        {
            return JSRef!.Call<Vector3>("intersectTriangle", a, b, c, backfaceCulling, target);
        }
        /// <summary>
        /// intersectsSphere(sphere: Sphere): boolean;
        /// </summary>
        public bool IntersectsSphere(Sphere sphere)
        {
            return JSRef!.Call<bool>("intersectsSphere", sphere);
        }
        /// <summary>
        /// intersectsPlane(plane: Plane): boolean;
        /// </summary>
        public bool IntersectsPlane(Plane plane)
        {
            return JSRef!.Call<bool>("intersectsPlane", plane);
        }
        /// <summary>
        /// intersectSphere(sphere: Sphere, target: Vector3): Vector3 | null;
        /// </summary>
        public Vector3 IntersectSphere(Sphere sphere, Vector3 target)
        {
            return JSRef!.Call<Vector3>("intersectSphere", sphere, target);
        }
        /// <summary>
        /// intersectsBox(box: Box3): boolean;
        /// </summary>
        public bool IntersectsBox(Box3 box)
        {
            return JSRef!.Call<bool>("intersectsBox", box);
        }
        /// <summary>
        /// intersectPlane(plane: Plane, target: Vector3): Vector3 | null;
        /// </summary>
        public Vector3 IntersectPlane(Plane plane, Vector3 target)
        {
            return JSRef!.Call<Vector3>("intersectPlane", plane, target);
        }
        /// <summary>
        /// intersectBox(box: Box3, target: Vector3): Vector3 | null;
        /// </summary>
        public Vector3 IntersectBox(Box3 box, Vector3 target)
        {
            return JSRef!.Call<Vector3>("intersectBox", box, target);
        }
        /// <summary>
        /// equals(ray: Ray): boolean;
        /// </summary>
        public bool Equals(Ray ray)
        {
            return JSRef!.Call<bool>("equals", ray);
        }
        /// <summary>
        /// distanceToPoint(point: Vector3): number;
        /// </summary>
        public float DistanceToPoint(Vector3 point)
        {
            return JSRef!.Call<float>("distanceToPoint", point);
        }
        /// <summary>
        /// distanceToPlane(plane: Plane): number;
        /// </summary>
        public float DistanceToPlane(Plane plane)
        {
            return JSRef!.Call<float>("distanceToPlane", plane);
        }
        /// <summary>
        /// distanceSqToSegment(
        ///         v0: Vector3,
        ///         v1: Vector3,
        ///         optionalPointOnRay?: Vector3,
        ///         optionalPointOnSegment?: Vector3,
        ///     ): number;
        /// </summary>
        public float DistanceSqToSegment(Vector3 v0, Vector3 v1, Vector3 optionalPointOnRay, Vector3 optionalPointOnSegment)
        {
            return JSRef!.Call<float>("distanceSqToSegment", v0, v1, optionalPointOnRay, optionalPointOnSegment);
        }
        /// <summary>
        /// distanceSqToPoint(point: Vector3): number;
        /// </summary>
        public float DistanceSqToPoint(Vector3 point)
        {
            return JSRef!.Call<float>("distanceSqToPoint", point);
        }
        /// <summary>
        /// copy(ray: Ray): this;
        /// </summary>
        public Ray Copy(Ray ray)
        {
            return JSRef!.Call<Ray>("copy", ray);
        }
        /// <summary>
        /// closestPointToPoint(point: Vector3, target: Vector3): Vector3;
        /// </summary>
        public Vector3 ClosestPointToPoint(Vector3 point, Vector3 target)
        {
            return JSRef!.Call<Vector3>("closestPointToPoint", point, target);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Ray Clone()
        {
            return JSRef!.Call<Ray>("clone");
        }
        /// <summary>
        /// at(t: number, target: Vector3): Vector3;
        /// </summary>
        public Vector3 At(float t, Vector3 target)
        {
            return JSRef!.Call<Vector3>("at", t, target);
        }
        /// <summary>
        /// applyMatrix4(matrix4: Matrix4): Ray;
        /// </summary>
        public Ray ApplyMatrix4(Matrix4 matrix4)
        {
            return JSRef!.Call<Ray>("applyMatrix4", matrix4);
        }
        #endregion
    }
}
