
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector2 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector2(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(x?: number, y?: number);
        /// </summary>
        public Vector2(float x, float y) : base(JS.New("THREE.Vector2", x, y)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// height: number;
        /// </summary>
        public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
        /// <summary>
        /// readonly isVector2: true;
        /// </summary>
        public bool IsVector2 { get => JSRef!.Get<bool>("isVector2"); }
        /// <summary>
        /// width: number;
        /// </summary>
        public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
        /// <summary>
        /// x: number;
        /// </summary>
        public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
        /// <summary>
        /// y: number;
        /// </summary>
        public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toArray(array?: number[], offset?: number): number[];
        /// </summary>
        public Array<float> ToArray(Array<float> array, float offset)
        {
            return JSRef!.Call<Array<float>>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(array?: Vector2Tuple, offset?: 0): Vector2Tuple;
        /// </summary>
        public Vector2Tuple ToArray(Vector2Tuple array, float offset)
        {
            return JSRef!.Call<Vector2Tuple>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(array: ArrayLike<number>, offset?: number): ArrayLike<number>;
        /// </summary>
        public ArrayLikeFloat ToArray(ArrayLikeFloat array, float offset)
        {
            return JSRef!.Call<ArrayLikeFloat>("toArray", array, offset);
        }
        /// <summary>
        /// subVectors(a: Vector2Like, b: Vector2Like): this;
        /// </summary>
        public Vector2 SubVectors(Vector2Like a, Vector2Like b)
        {
            return JSRef!.Call<Vector2>("subVectors", a, b);
        }
        /// <summary>
        /// subScalar(s: number): this;
        /// </summary>
        public Vector2 SubScalar(float s)
        {
            return JSRef!.Call<Vector2>("subScalar", s);
        }
        /// <summary>
        /// sub(v: Vector2Like): this;
        /// </summary>
        public Vector2 Sub(Vector2Like v)
        {
            return JSRef!.Call<Vector2>("sub", v);
        }
        /// <summary>
        /// setY(y: number): this;
        /// </summary>
        public Vector2 SetY(float y)
        {
            return JSRef!.Call<Vector2>("setY", y);
        }
        /// <summary>
        /// setX(x: number): this;
        /// </summary>
        public Vector2 SetX(float x)
        {
            return JSRef!.Call<Vector2>("setX", x);
        }
        /// <summary>
        /// setScalar(scalar: number): this;
        /// </summary>
        public Vector2 SetScalar(float scalar)
        {
            return JSRef!.Call<Vector2>("setScalar", scalar);
        }
        /// <summary>
        /// setLength(length: number): this;
        /// </summary>
        public Vector2 SetLength(float length)
        {
            return JSRef!.Call<Vector2>("setLength", length);
        }
        /// <summary>
        /// setComponent(index: number, value: number): this;
        /// </summary>
        public Vector2 SetComponent(float index, float value)
        {
            return JSRef!.Call<Vector2>("setComponent", index, value);
        }
        /// <summary>
        /// set(x: number, y: number): this;
        /// </summary>
        public Vector2 Set(float x, float y)
        {
            return JSRef!.Call<Vector2>("set", x, y);
        }
        /// <summary>
        /// roundToZero(): this;
        /// </summary>
        public Vector2 RoundToZero()
        {
            return JSRef!.Call<Vector2>("roundToZero");
        }
        /// <summary>
        /// round(): this;
        /// </summary>
        public Vector2 Round()
        {
            return JSRef!.Call<Vector2>("round");
        }
        /// <summary>
        /// rotateAround(center: Vector2Like, angle: number): this;
        /// </summary>
        public Vector2 RotateAround(Vector2Like center, float angle)
        {
            return JSRef!.Call<Vector2>("rotateAround", center, angle);
        }
        /// <summary>
        /// random(): this;
        /// </summary>
        public Vector2 Random()
        {
            return JSRef!.Call<Vector2>("random");
        }
        /// <summary>
        /// normalize(): this;
        /// </summary>
        public Vector2 Normalize()
        {
            return JSRef!.Call<Vector2>("normalize");
        }
        /// <summary>
        /// negate(): this;
        /// </summary>
        public Vector2 Negate()
        {
            return JSRef!.Call<Vector2>("negate");
        }
        /// <summary>
        /// multiplyScalar(scalar: number): this;
        /// </summary>
        public Vector2 MultiplyScalar(float scalar)
        {
            return JSRef!.Call<Vector2>("multiplyScalar", scalar);
        }
        /// <summary>
        /// multiply(v: Vector2Like): this;
        /// </summary>
        public Vector2 Multiply(Vector2Like v)
        {
            return JSRef!.Call<Vector2>("multiply", v);
        }
        /// <summary>
        /// min(v: Vector2Like): this;
        /// </summary>
        public Vector2 Min(Vector2Like v)
        {
            return JSRef!.Call<Vector2>("min", v);
        }
        /// <summary>
        /// max(v: Vector2Like): this;
        /// </summary>
        public Vector2 Max(Vector2Like v)
        {
            return JSRef!.Call<Vector2>("max", v);
        }
        /// <summary>
        /// manhattanLength(): number;
        /// </summary>
        public float ManhattanLength()
        {
            return JSRef!.Call<float>("manhattanLength");
        }
        /// <summary>
        /// manhattanDistanceTo(v: Vector2Like): number;
        /// </summary>
        public float ManhattanDistanceTo(Vector2Like v)
        {
            return JSRef!.Call<float>("manhattanDistanceTo", v);
        }
        /// <summary>
        /// lerpVectors(v1: Vector2Like, v2: Vector2Like, alpha: number): this;
        /// </summary>
        public Vector2 LerpVectors(Vector2Like v1, Vector2Like v2, float alpha)
        {
            return JSRef!.Call<Vector2>("lerpVectors", v1, v2, alpha);
        }
        /// <summary>
        /// lerp(v: Vector2Like, alpha: number): this;
        /// </summary>
        public Vector2 Lerp(Vector2Like v, float alpha)
        {
            return JSRef!.Call<Vector2>("lerp", v, alpha);
        }
        /// <summary>
        /// lengthSq(): number;
        /// </summary>
        public float LengthSq()
        {
            return JSRef!.Call<float>("lengthSq");
        }
        /// <summary>
        /// length(): number;
        /// </summary>
        public float Length()
        {
            return JSRef!.Call<float>("length");
        }
        /// <summary>
        /// getComponent(index: number): number;
        /// </summary>
        public float GetComponent(float index)
        {
            return JSRef!.Call<float>("getComponent", index);
        }
        /// <summary>
        /// fromBufferAttribute(attribute: BufferAttribute, index: number): this;
        /// </summary>
        public Vector2 FromBufferAttribute(BufferAttribute attribute, float index)
        {
            return JSRef!.Call<Vector2>("fromBufferAttribute", attribute, index);
        }
        /// <summary>
        /// fromArray(array: number[] | ArrayLike<number>, offset?: number): this;
        /// </summary>
        public Vector2 FromArray(Union<Array<float>, ArrayLikeFloat> array, float offset)
        {
            return JSRef!.Call<Vector2>("fromArray", array, offset);
        }
        /// <summary>
        /// floor(): this;
        /// </summary>
        public Vector2 Floor()
        {
            return JSRef!.Call<Vector2>("floor");
        }
        /// <summary>
        /// equals(v: Vector2Like): boolean;
        /// </summary>
        public bool Equals(Vector2Like v)
        {
            return JSRef!.Call<bool>("equals", v);
        }
        /// <summary>
        /// dot(v: Vector2Like): number;
        /// </summary>
        public float Dot(Vector2Like v)
        {
            return JSRef!.Call<float>("dot", v);
        }
        /// <summary>
        /// divideScalar(s: number): this;
        /// </summary>
        public Vector2 DivideScalar(float s)
        {
            return JSRef!.Call<Vector2>("divideScalar", s);
        }
        /// <summary>
        /// divide(v: Vector2Like): this;
        /// </summary>
        public Vector2 Divide(Vector2Like v)
        {
            return JSRef!.Call<Vector2>("divide", v);
        }
        /// <summary>
        /// distanceToSquared(v: Vector2Like): number;
        /// </summary>
        public float DistanceToSquared(Vector2Like v)
        {
            return JSRef!.Call<float>("distanceToSquared", v);
        }
        /// <summary>
        /// distanceTo(v: Vector2Like): number;
        /// </summary>
        public float DistanceTo(Vector2Like v)
        {
            return JSRef!.Call<float>("distanceTo", v);
        }
        /// <summary>
        /// cross(v: Vector2Like): number;
        /// </summary>
        public float Cross(Vector2Like v)
        {
            return JSRef!.Call<float>("cross", v);
        }
        /// <summary>
        /// copy(v: Vector2Like): this;
        /// </summary>
        public Vector2 Copy(Vector2Like v)
        {
            return JSRef!.Call<Vector2>("copy", v);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Vector2 Clone()
        {
            return JSRef!.Call<Vector2>("clone");
        }
        /// <summary>
        /// clampScalar(min: number, max: number): this;
        /// </summary>
        public Vector2 ClampScalar(float min, float max)
        {
            return JSRef!.Call<Vector2>("clampScalar", min, max);
        }
        /// <summary>
        /// clampLength(min: number, max: number): this;
        /// </summary>
        public Vector2 ClampLength(float min, float max)
        {
            return JSRef!.Call<Vector2>("clampLength", min, max);
        }
        /// <summary>
        /// clamp(min: Vector2Like, max: Vector2Like): this;
        /// </summary>
        public Vector2 Clamp(Vector2Like min, Vector2Like max)
        {
            return JSRef!.Call<Vector2>("clamp", min, max);
        }
        /// <summary>
        /// ceil(): this;
        /// </summary>
        public Vector2 Ceil()
        {
            return JSRef!.Call<Vector2>("ceil");
        }
        /// <summary>
        /// applyMatrix3(m: Matrix3): this;
        /// </summary>
        public Vector2 ApplyMatrix3(Matrix3 m)
        {
            return JSRef!.Call<Vector2>("applyMatrix3", m);
        }
        /// <summary>
        /// angleTo(v: Vector2): number;
        /// </summary>
        public float AngleTo(Vector2 v)
        {
            return JSRef!.Call<float>("angleTo", v);
        }
        /// <summary>
        /// angle(): number;
        /// </summary>
        public float Angle()
        {
            return JSRef!.Call<float>("angle");
        }
        /// <summary>
        /// addVectors(a: Vector2Like, b: Vector2Like): this;
        /// </summary>
        public Vector2 AddVectors(Vector2Like a, Vector2Like b)
        {
            return JSRef!.Call<Vector2>("addVectors", a, b);
        }
        /// <summary>
        /// addScaledVector(v: Vector2Like, s: number): this;
        /// </summary>
        public Vector2 AddScaledVector(Vector2Like v, float s)
        {
            return JSRef!.Call<Vector2>("addScaledVector", v, s);
        }
        /// <summary>
        /// addScalar(s: number): this;
        /// </summary>
        public Vector2 AddScalar(float s)
        {
            return JSRef!.Call<Vector2>("addScalar", s);
        }
        /// <summary>
        /// add(v: Vector2Like): this;
        /// </summary>
        public Vector2 Add(Vector2Like v)
        {
            return JSRef!.Call<Vector2>("add", v);
        }
        #endregion
    }
}
