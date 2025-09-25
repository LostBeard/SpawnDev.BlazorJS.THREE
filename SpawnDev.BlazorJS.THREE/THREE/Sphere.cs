
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Sphere : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Sphere(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(center?: Vector3, radius?: number);
        /// </summary>
        public Sphere(Vector3 center, float radius) : base(JS.New("THREE.Sphere", center, radius)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// center: Vector3;
        /// </summary>
        public Vector3 Center { get => JSRef!.Get<Vector3>("center"); set => JSRef!.Set("center", value); }
        /// <summary>
        /// readonly isSphere: true;
        /// </summary>
        public bool IsSphere { get => JSRef!.Get<bool>("isSphere"); }
        /// <summary>
        /// radius: number;
        /// </summary>
        public float Radius { get => JSRef!.Get<float>("radius"); set => JSRef!.Set("radius", value); }
        #endregion

        #region Methods
        /// <summary>
        /// union(sphere: Sphere): this;
        /// </summary>
        public Sphere Union(Sphere sphere)
        {
            return JSRef!.Call<Sphere>("union", sphere);
        }
        /// <summary>
        /// translate(offset: Vector3): Sphere;
        /// </summary>
        public Sphere Translate(Vector3 offset)
        {
            return JSRef!.Call<Sphere>("translate", offset);
        }
        /// <summary>
        /// toJSON(): SphereJSON;
        /// </summary>
        public SphereJSON ToJSON()
        {
            return JSRef!.Call<SphereJSON>("toJSON");
        }
        /// <summary>
        /// setFromPoints(points: Vector3[], optionalCenter?: Vector3): Sphere;
        /// </summary>
        public Sphere SetFromPoints(Array<Vector3> points, Vector3 optionalCenter)
        {
            return JSRef!.Call<Sphere>("setFromPoints", points, optionalCenter);
        }
        /// <summary>
        /// set(center: Vector3, radius: number): Sphere;
        /// </summary>
        public Sphere Set(Vector3 center, float radius)
        {
            return JSRef!.Call<Sphere>("set", center, radius);
        }
        /// <summary>
        /// makeEmpty(): this;
        /// </summary>
        public Sphere MakeEmpty()
        {
            return JSRef!.Call<Sphere>("makeEmpty");
        }
        /// <summary>
        /// isEmpty(): boolean;
        /// </summary>
        public bool IsEmpty()
        {
            return JSRef!.Call<bool>("isEmpty");
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
        /// intersectsBox(box: Box3): boolean;
        /// </summary>
        public bool IntersectsBox(Box3 box)
        {
            return JSRef!.Call<bool>("intersectsBox", box);
        }
        /// <summary>
        /// getBoundingBox(target: Box3): Box3;
        /// </summary>
        public Box3 GetBoundingBox(Box3 target)
        {
            return JSRef!.Call<Box3>("getBoundingBox", target);
        }
        /// <summary>
        /// fromJSON(json: SphereJSON): this;
        /// </summary>
        public Sphere FromJSON(SphereJSON json)
        {
            return JSRef!.Call<Sphere>("fromJSON", json);
        }
        /// <summary>
        /// expandByPoint(point: Vector3): this;
        /// </summary>
        public Sphere ExpandByPoint(Vector3 point)
        {
            return JSRef!.Call<Sphere>("expandByPoint", point);
        }
        /// <summary>
        /// equals(sphere: Sphere): boolean;
        /// </summary>
        public bool Equals(Sphere sphere)
        {
            return JSRef!.Call<bool>("equals", sphere);
        }
        /// <summary>
        /// empty(): any;
        /// </summary>
        public object Empty()
        {
            return JSRef!.Call<object>("empty");
        }
        /// <summary>
        /// distanceToPoint(point: Vector3): number;
        /// </summary>
        public float DistanceToPoint(Vector3 point)
        {
            return JSRef!.Call<float>("distanceToPoint", point);
        }
        /// <summary>
        /// copy(sphere: Sphere): this;
        /// </summary>
        public Sphere Copy(Sphere sphere)
        {
            return JSRef!.Call<Sphere>("copy", sphere);
        }
        /// <summary>
        /// containsPoint(point: Vector3): boolean;
        /// </summary>
        public bool ContainsPoint(Vector3 point)
        {
            return JSRef!.Call<bool>("containsPoint", point);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Sphere Clone()
        {
            return JSRef!.Call<Sphere>("clone");
        }
        /// <summary>
        /// clampPoint(point: Vector3, target: Vector3): Vector3;
        /// </summary>
        public Vector3 ClampPoint(Vector3 point, Vector3 target)
        {
            return JSRef!.Call<Vector3>("clampPoint", point, target);
        }
        /// <summary>
        /// applyMatrix4(matrix: Matrix4): Sphere;
        /// </summary>
        public Sphere ApplyMatrix4(Matrix4 matrix)
        {
            return JSRef!.Call<Sphere>("applyMatrix4", matrix);
        }
        #endregion
    }
}
