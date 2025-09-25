
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Box3 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Box3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(min?: Vector3, max?: Vector3);
        /// </summary>
        public Box3(Vector3 min, Vector3 max) : base(JS.New("THREE.Box3", min, max)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isBox3: true;
        /// </summary>
        public bool IsBox3 { get => JSRef!.Get<bool>("isBox3"); }
        /// <summary>
        /// max: Vector3;
        /// </summary>
        public Vector3 Max { get => JSRef!.Get<Vector3>("max"); set => JSRef!.Set("max", value); }
        /// <summary>
        /// min: Vector3;
        /// </summary>
        public Vector3 Min { get => JSRef!.Get<Vector3>("min"); set => JSRef!.Set("min", value); }
        #endregion

        #region Methods
        /// <summary>
        /// union(box: Box3): this;
        /// </summary>
        public Box3 Union(Box3 box)
        {
            return JSRef!.Call<Box3>("union", box);
        }
        /// <summary>
        /// translate(offset: Vector3): this;
        /// </summary>
        public Box3 Translate(Vector3 offset)
        {
            return JSRef!.Call<Box3>("translate", offset);
        }
        /// <summary>
        /// toJSON(): Box3JSON;
        /// </summary>
        public Box3JSON ToJSON()
        {
            return JSRef!.Call<Box3JSON>("toJSON");
        }
        /// <summary>
        /// setFromPoints(points: Vector3[]): this;
        /// </summary>
        public Box3 SetFromPoints(Array<Vector3> points)
        {
            return JSRef!.Call<Box3>("setFromPoints", points);
        }
        /// <summary>
        /// setFromObject(object: Object3D, precise?: boolean): this;
        /// </summary>
        public Box3 SetFromObject(Object3D obj, bool precise)
        {
            return JSRef!.Call<Box3>("setFromObject", obj, precise);
        }
        /// <summary>
        /// setFromCenterAndSize(center: Vector3, size: Vector3): this;
        /// </summary>
        public Box3 SetFromCenterAndSize(Vector3 center, Vector3 size)
        {
            return JSRef!.Call<Box3>("setFromCenterAndSize", center, size);
        }
        /// <summary>
        /// setFromBufferAttribute(bufferAttribute: BufferAttribute): this;
        /// </summary>
        public Box3 SetFromBufferAttribute(BufferAttribute bufferAttribute)
        {
            return JSRef!.Call<Box3>("setFromBufferAttribute", bufferAttribute);
        }
        /// <summary>
        /// setFromArray(array: ArrayLike<number>): this;
        /// </summary>
        public Box3 SetFromArray(ArrayLikeFloat array)
        {
            return JSRef!.Call<Box3>("setFromArray", array);
        }
        /// <summary>
        /// set(min: Vector3, max: Vector3): this;
        /// </summary>
        public Box3 Set(Vector3 min, Vector3 max)
        {
            return JSRef!.Call<Box3>("set", min, max);
        }
        /// <summary>
        /// makeEmpty(): this;
        /// </summary>
        public Box3 MakeEmpty()
        {
            return JSRef!.Call<Box3>("makeEmpty");
        }
        /// <summary>
        /// isIntersectionSphere(s: any): any;
        /// </summary>
        public object IsIntersectionSphere(object s)
        {
            return JSRef!.Call<object>("isIntersectionSphere", s);
        }
        /// <summary>
        /// isIntersectionBox(b: any): any;
        /// </summary>
        public object IsIntersectionBox(object b)
        {
            return JSRef!.Call<object>("isIntersectionBox", b);
        }
        /// <summary>
        /// isEmpty(): boolean;
        /// </summary>
        public bool IsEmpty()
        {
            return JSRef!.Call<bool>("isEmpty");
        }
        /// <summary>
        /// intersectsTriangle(triangle: Triangle): boolean;
        /// </summary>
        public bool IntersectsTriangle(Triangle triangle)
        {
            return JSRef!.Call<bool>("intersectsTriangle", triangle);
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
        /// intersect(box: Box3): this;
        /// </summary>
        public Box3 Intersect(Box3 box)
        {
            return JSRef!.Call<Box3>("intersect", box);
        }
        /// <summary>
        /// getSize(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetSize(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getSize", target);
        }
        /// <summary>
        /// getParameter(point: Vector3, target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetParameter(Vector3 point, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getParameter", point, target);
        }
        /// <summary>
        /// getCenter(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetCenter(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getCenter", target);
        }
        /// <summary>
        /// getBoundingSphere(target: Sphere): Sphere;
        /// </summary>
        public Sphere GetBoundingSphere(Sphere target)
        {
            return JSRef!.Call<Sphere>("getBoundingSphere", target);
        }
        /// <summary>
        /// fromJSON(json: Box3JSON): this;
        /// </summary>
        public Box3 FromJSON(Box3JSON json)
        {
            return JSRef!.Call<Box3>("fromJSON", json);
        }
        /// <summary>
        /// expandByVector(vector: Vector3): this;
        /// </summary>
        public Box3 ExpandByVector(Vector3 vector)
        {
            return JSRef!.Call<Box3>("expandByVector", vector);
        }
        /// <summary>
        /// expandByScalar(scalar: number): this;
        /// </summary>
        public Box3 ExpandByScalar(float scalar)
        {
            return JSRef!.Call<Box3>("expandByScalar", scalar);
        }
        /// <summary>
        /// expandByPoint(point: Vector3): this;
        /// </summary>
        public Box3 ExpandByPoint(Vector3 point)
        {
            return JSRef!.Call<Box3>("expandByPoint", point);
        }
        /// <summary>
        /// expandByObject(object: Object3D, precise?: boolean): this;
        /// </summary>
        public Box3 ExpandByObject(Object3D obj, bool precise)
        {
            return JSRef!.Call<Box3>("expandByObject", obj, precise);
        }
        /// <summary>
        /// equals(box: Box3): boolean;
        /// </summary>
        public bool Equals(Box3 box)
        {
            return JSRef!.Call<bool>("equals", box);
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
        /// copy(box: Box3): this;
        /// </summary>
        public Box3 Copy(Box3 box)
        {
            return JSRef!.Call<Box3>("copy", box);
        }
        /// <summary>
        /// containsPoint(point: Vector3): boolean;
        /// </summary>
        public bool ContainsPoint(Vector3 point)
        {
            return JSRef!.Call<bool>("containsPoint", point);
        }
        /// <summary>
        /// containsBox(box: Box3): boolean;
        /// </summary>
        public bool ContainsBox(Box3 box)
        {
            return JSRef!.Call<bool>("containsBox", box);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Box3 Clone()
        {
            return JSRef!.Call<Box3>("clone");
        }
        /// <summary>
        /// clampPoint(point: Vector3, target: Vector3): Vector3;
        /// </summary>
        public Vector3 ClampPoint(Vector3 point, Vector3 target)
        {
            return JSRef!.Call<Vector3>("clampPoint", point, target);
        }
        /// <summary>
        /// applyMatrix4(matrix: Matrix4): this;
        /// </summary>
        public Box3 ApplyMatrix4(Matrix4 matrix)
        {
            return JSRef!.Call<Box3>("applyMatrix4", matrix);
        }
        #endregion
    }
}
