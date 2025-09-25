
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Triangle : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Triangle(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(a?: Vector3, b?: Vector3, c?: Vector3);
        /// </summary>
        public Triangle(Vector3 a, Vector3 b, Vector3 c) : base(JS.New("THREE.Triangle", a, b, c)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// a: Vector3;
        /// </summary>
        public Vector3 A { get => JSRef!.Get<Vector3>("a"); set => JSRef!.Set("a", value); }
        /// <summary>
        /// b: Vector3;
        /// </summary>
        public Vector3 B { get => JSRef!.Get<Vector3>("b"); set => JSRef!.Set("b", value); }
        /// <summary>
        /// c: Vector3;
        /// </summary>
        public Vector3 C { get => JSRef!.Get<Vector3>("c"); set => JSRef!.Set("c", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setFromPointsAndIndices(points: Vector3[], i0: number, i1: number, i2: number): this;
        /// </summary>
        public Triangle SetFromPointsAndIndices(Array<Vector3> points, float i0, float i1, float i2)
        {
            return JSRef!.Call<Triangle>("setFromPointsAndIndices", points, i0, i1, i2);
        }
        /// <summary>
        /// setFromAttributeAndIndices(
        ///         attribute: BufferAttribute | InterleavedBufferAttribute,
        ///         i0: number,
        ///         i1: number,
        ///         i2: number,
        ///     ): this;
        /// </summary>
        public Triangle SetFromAttributeAndIndices(Union<BufferAttribute, InterleavedBufferAttribute> attribute, float i0, float i1, float i2)
        {
            return JSRef!.Call<Triangle>("setFromAttributeAndIndices", attribute, i0, i1, i2);
        }
        /// <summary>
        /// set(a: Vector3, b: Vector3, c: Vector3): Triangle;
        /// </summary>
        public Triangle Set(Vector3 a, Vector3 b, Vector3 c)
        {
            return JSRef!.Call<Triangle>("set", a, b, c);
        }
        /// <summary>
        /// isFrontFacing(direction: Vector3): boolean;
        /// </summary>
        public bool IsFrontFacing(Vector3 direction)
        {
            return JSRef!.Call<bool>("isFrontFacing", direction);
        }
        /// <summary>
        /// static isFrontFacing(a: Vector3, b: Vector3, c: Vector3, direction: Vector3): boolean;
        /// </summary>
        public bool IsFrontFacing(Vector3 a, Vector3 b, Vector3 c, Vector3 direction)
        {
            return JSRef!.Call<bool>("isFrontFacing", a, b, c, direction);
        }
        /// <summary>
        /// intersectsBox(box: Box3): boolean;
        /// </summary>
        public bool IntersectsBox(Box3 box)
        {
            return JSRef!.Call<bool>("intersectsBox", box);
        }
        /// <summary>
        /// getPlane(target: Plane): Plane;
        /// </summary>
        public Plane GetPlane(Plane target)
        {
            return JSRef!.Call<Plane>("getPlane", target);
        }
        /// <summary>
        /// getNormal(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetNormal(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getNormal", target);
        }
        /// <summary>
        /// static getNormal(a: Vector3, b: Vector3, c: Vector3, target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetNormal(Vector3 a, Vector3 b, Vector3 c, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getNormal", a, b, c, target);
        }
        /// <summary>
        /// getMidpoint(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetMidpoint(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getMidpoint", target);
        }
        /// <summary>
        /// getInterpolation(point: Vector3, v1: Vector2, v2: Vector2, v3: Vector2, target: Vector2): Vector2 | null;
        /// </summary>
        public Vector2 GetInterpolation(Vector3 point, Vector2 v1, Vector2 v2, Vector2 v3, Vector2 target)
        {
            return JSRef!.Call<Vector2>("getInterpolation", point, v1, v2, v3, target);
        }
        /// <summary>
        /// getInterpolation(point: Vector3, v1: Vector3, v2: Vector3, v3: Vector3, target: Vector3): Vector3 | null;
        /// </summary>
        public Vector3 GetInterpolation(Vector3 point, Vector3 v1, Vector3 v2, Vector3 v3, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getInterpolation", point, v1, v2, v3, target);
        }
        /// <summary>
        /// getInterpolation(point: Vector3, v1: Vector4, v2: Vector4, v3: Vector4, target: Vector4): Vector4 | null;
        /// </summary>
        public Vector4 GetInterpolation(Vector3 point, Vector4 v1, Vector4 v2, Vector4 v3, Vector4 target)
        {
            return JSRef!.Call<Vector4>("getInterpolation", point, v1, v2, v3, target);
        }
        /// <summary>
        /// static getInterpolation(
        ///         point: Vector3,
        ///         p1: Vector3,
        ///         p2: Vector3,
        ///         p3: Vector3,
        ///         v1: Vector2,
        ///         v2: Vector2,
        ///         v3: Vector2,
        ///         target: Vector2,
        ///     ): Vector2 | null;
        /// </summary>
        public Vector2 GetInterpolation(Vector3 point, Vector3 p1, Vector3 p2, Vector3 p3, Vector2 v1, Vector2 v2, Vector2 v3, Vector2 target)
        {
            return JSRef!.Call<Vector2>("getInterpolation", point, p1, p2, p3, v1, v2, v3, target);
        }
        /// <summary>
        /// static getInterpolation(
        ///         point: Vector3,
        ///         p1: Vector3,
        ///         p2: Vector3,
        ///         p3: Vector3,
        ///         v1: Vector3,
        ///         v2: Vector3,
        ///         v3: Vector3,
        ///         target: Vector3,
        ///     ): Vector3 | null;
        /// </summary>
        public Vector3 GetInterpolation(Vector3 point, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 v1, Vector3 v2, Vector3 v3, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getInterpolation", point, p1, p2, p3, v1, v2, v3, target);
        }
        /// <summary>
        /// static getInterpolation(
        ///         point: Vector3,
        ///         p1: Vector3,
        ///         p2: Vector3,
        ///         p3: Vector3,
        ///         v1: Vector4,
        ///         v2: Vector4,
        ///         v3: Vector4,
        ///         target: Vector4,
        ///     ): Vector4 | null;
        /// </summary>
        public Vector4 GetInterpolation(Vector3 point, Vector3 p1, Vector3 p2, Vector3 p3, Vector4 v1, Vector4 v2, Vector4 v3, Vector4 target)
        {
            return JSRef!.Call<Vector4>("getInterpolation", point, p1, p2, p3, v1, v2, v3, target);
        }
        /// <summary>
        /// static getInterpolatedAttribute(
        ///         attr: BufferAttribute | InterleavedBufferAttribute,
        ///         i1: number,
        ///         i2: number,
        ///         i3: number,
        ///         barycoord: Vector3,
        ///         target: Vector2,
        ///     ): Vector2;
        /// </summary>
        public Vector2 GetInterpolatedAttribute(Union<BufferAttribute, InterleavedBufferAttribute> attr, float i1, float i2, float i3, Vector3 barycoord, Vector2 target)
        {
            return JSRef!.Call<Vector2>("getInterpolatedAttribute", attr, i1, i2, i3, barycoord, target);
        }
        /// <summary>
        /// static getInterpolatedAttribute(
        ///         attr: BufferAttribute | InterleavedBufferAttribute,
        ///         i1: number,
        ///         i2: number,
        ///         i3: number,
        ///         barycoord: Vector3,
        ///         target: Vector3,
        ///     ): Vector3;
        /// </summary>
        public Vector3 GetInterpolatedAttribute(Union<BufferAttribute, InterleavedBufferAttribute> attr, float i1, float i2, float i3, Vector3 barycoord, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getInterpolatedAttribute", attr, i1, i2, i3, barycoord, target);
        }
        /// <summary>
        /// static getInterpolatedAttribute(
        ///         attr: BufferAttribute | InterleavedBufferAttribute,
        ///         i1: number,
        ///         i2: number,
        ///         i3: number,
        ///         barycoord: Vector3,
        ///         target: Vector4,
        ///     ): Vector4;
        /// </summary>
        public Vector4 GetInterpolatedAttribute(Union<BufferAttribute, InterleavedBufferAttribute> attr, float i1, float i2, float i3, Vector3 barycoord, Vector4 target)
        {
            return JSRef!.Call<Vector4>("getInterpolatedAttribute", attr, i1, i2, i3, barycoord, target);
        }
        /// <summary>
        /// getBarycoord(point: Vector3, target: Vector3): Vector3 | null;
        /// </summary>
        public Vector3 GetBarycoord(Vector3 point, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getBarycoord", point, target);
        }
        /// <summary>
        /// static getBarycoord(point: Vector3, a: Vector3, b: Vector3, c: Vector3, target: Vector3): Vector3 | null;
        /// </summary>
        public Vector3 GetBarycoord(Vector3 point, Vector3 a, Vector3 b, Vector3 c, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getBarycoord", point, a, b, c, target);
        }
        /// <summary>
        /// getArea(): number;
        /// </summary>
        public float GetArea()
        {
            return JSRef!.Call<float>("getArea");
        }
        /// <summary>
        /// equals(triangle: Triangle): boolean;
        /// </summary>
        public bool Equals(Triangle triangle)
        {
            return JSRef!.Call<bool>("equals", triangle);
        }
        /// <summary>
        /// copy(triangle: Triangle): this;
        /// </summary>
        public Triangle Copy(Triangle triangle)
        {
            return JSRef!.Call<Triangle>("copy", triangle);
        }
        /// <summary>
        /// containsPoint(point: Vector3): boolean;
        /// </summary>
        public bool ContainsPoint(Vector3 point)
        {
            return JSRef!.Call<bool>("containsPoint", point);
        }
        /// <summary>
        /// static containsPoint(point: Vector3, a: Vector3, b: Vector3, c: Vector3): boolean;
        /// </summary>
        public bool ContainsPoint(Vector3 point, Vector3 a, Vector3 b, Vector3 c)
        {
            return JSRef!.Call<bool>("containsPoint", point, a, b, c);
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
        public Triangle Clone()
        {
            return JSRef!.Call<Triangle>("clone");
        }
        #endregion
    }
}
