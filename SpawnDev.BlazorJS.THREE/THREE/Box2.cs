
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Box2 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Box2(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(min?: Vector2, max?: Vector2);
        /// </summary>
        public Box2(Vector2 min, Vector2 max) : base(JS.New("THREE.Box2", min, max)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// max: Vector2;
        /// </summary>
        public Vector2 Max { get => JSRef!.Get<Vector2>("max"); set => JSRef!.Set("max", value); }
        /// <summary>
        /// min: Vector2;
        /// </summary>
        public Vector2 Min { get => JSRef!.Get<Vector2>("min"); set => JSRef!.Set("min", value); }
        #endregion

        #region Methods
        /// <summary>
        /// union(box: Box2): Box2;
        /// </summary>
        public Box2 Union(Box2 box)
        {
            return JSRef!.Call<Box2>("union", box);
        }
        /// <summary>
        /// translate(offset: Vector2): Box2;
        /// </summary>
        public Box2 Translate(Vector2 offset)
        {
            return JSRef!.Call<Box2>("translate", offset);
        }
        /// <summary>
        /// setFromPoints(points: Vector2[]): Box2;
        /// </summary>
        public Box2 SetFromPoints(Array<Vector2> points)
        {
            return JSRef!.Call<Box2>("setFromPoints", points);
        }
        /// <summary>
        /// setFromCenterAndSize(center: Vector2, size: Vector2): Box2;
        /// </summary>
        public Box2 SetFromCenterAndSize(Vector2 center, Vector2 size)
        {
            return JSRef!.Call<Box2>("setFromCenterAndSize", center, size);
        }
        /// <summary>
        /// set(min: Vector2, max: Vector2): Box2;
        /// </summary>
        public Box2 Set(Vector2 min, Vector2 max)
        {
            return JSRef!.Call<Box2>("set", min, max);
        }
        /// <summary>
        /// makeEmpty(): Box2;
        /// </summary>
        public Box2 MakeEmpty()
        {
            return JSRef!.Call<Box2>("makeEmpty");
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
        /// intersectsBox(box: Box2): boolean;
        /// </summary>
        public bool IntersectsBox(Box2 box)
        {
            return JSRef!.Call<bool>("intersectsBox", box);
        }
        /// <summary>
        /// intersect(box: Box2): Box2;
        /// </summary>
        public Box2 Intersect(Box2 box)
        {
            return JSRef!.Call<Box2>("intersect", box);
        }
        /// <summary>
        /// getSize(target: Vector2): Vector2;
        /// </summary>
        public Vector2 GetSize(Vector2 target)
        {
            return JSRef!.Call<Vector2>("getSize", target);
        }
        /// <summary>
        /// getParameter(point: Vector2, target: Vector2): Vector2;
        /// </summary>
        public Vector2 GetParameter(Vector2 point, Vector2 target)
        {
            return JSRef!.Call<Vector2>("getParameter", point, target);
        }
        /// <summary>
        /// getCenter(target: Vector2): Vector2;
        /// </summary>
        public Vector2 GetCenter(Vector2 target)
        {
            return JSRef!.Call<Vector2>("getCenter", target);
        }
        /// <summary>
        /// expandByVector(vector: Vector2): Box2;
        /// </summary>
        public Box2 ExpandByVector(Vector2 vector)
        {
            return JSRef!.Call<Box2>("expandByVector", vector);
        }
        /// <summary>
        /// expandByScalar(scalar: number): Box2;
        /// </summary>
        public Box2 ExpandByScalar(float scalar)
        {
            return JSRef!.Call<Box2>("expandByScalar", scalar);
        }
        /// <summary>
        /// expandByPoint(point: Vector2): Box2;
        /// </summary>
        public Box2 ExpandByPoint(Vector2 point)
        {
            return JSRef!.Call<Box2>("expandByPoint", point);
        }
        /// <summary>
        /// equals(box: Box2): boolean;
        /// </summary>
        public bool Equals(Box2 box)
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
        /// distanceToPoint(point: Vector2): number;
        /// </summary>
        public float DistanceToPoint(Vector2 point)
        {
            return JSRef!.Call<float>("distanceToPoint", point);
        }
        /// <summary>
        /// copy(box: Box2): this;
        /// </summary>
        public Box2 Copy(Box2 box)
        {
            return JSRef!.Call<Box2>("copy", box);
        }
        /// <summary>
        /// containsPoint(point: Vector2): boolean;
        /// </summary>
        public bool ContainsPoint(Vector2 point)
        {
            return JSRef!.Call<bool>("containsPoint", point);
        }
        /// <summary>
        /// containsBox(box: Box2): boolean;
        /// </summary>
        public bool ContainsBox(Box2 box)
        {
            return JSRef!.Call<bool>("containsBox", box);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Box2 Clone()
        {
            return JSRef!.Call<Box2>("clone");
        }
        /// <summary>
        /// clampPoint(point: Vector2, target: Vector2): Vector2;
        /// </summary>
        public Vector2 ClampPoint(Vector2 point, Vector2 target)
        {
            return JSRef!.Call<Vector2>("clampPoint", point, target);
        }
        #endregion
    }
}
