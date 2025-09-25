
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector4 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector4(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(x?: number, y?: number, z?: number, w?: number);
        /// </summary>
        public Vector4(float x, float y, float z, float w) : base(JS.New("THREE.Vector4", x, y, z, w)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// height: number;
        /// </summary>
        public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
        /// <summary>
        /// readonly isVector4: true;
        /// </summary>
        public bool IsVector4 { get => JSRef!.Get<bool>("isVector4"); }
        /// <summary>
        /// w: number;
        /// </summary>
        public float W { get => JSRef!.Get<float>("w"); set => JSRef!.Set("w", value); }
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
        /// <summary>
        /// z: number;
        /// </summary>
        public float Z { get => JSRef!.Get<float>("z"); set => JSRef!.Set("z", value); }
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
        /// toArray(array?: Vector4Tuple, offset?: 0): Vector4Tuple;
        /// </summary>
        public Vector4Tuple ToArray(Vector4Tuple array, float offset)
        {
            return JSRef!.Call<Vector4Tuple>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(array: ArrayLike<number>, offset?: number): ArrayLike<number>;
        /// </summary>
        public ArrayLikeFloat ToArray(ArrayLikeFloat array, float offset)
        {
            return JSRef!.Call<ArrayLikeFloat>("toArray", array, offset);
        }
        /// <summary>
        /// subVectors(a: Vector4Like, b: Vector4Like): this;
        /// </summary>
        public Vector4 SubVectors(Vector4Like a, Vector4Like b)
        {
            return JSRef!.Call<Vector4>("subVectors", a, b);
        }
        /// <summary>
        /// subScalar(s: number): this;
        /// </summary>
        public Vector4 SubScalar(float s)
        {
            return JSRef!.Call<Vector4>("subScalar", s);
        }
        /// <summary>
        /// sub(v: Vector4Like): this;
        /// </summary>
        public Vector4 Sub(Vector4Like v)
        {
            return JSRef!.Call<Vector4>("sub", v);
        }
        /// <summary>
        /// setZ(z: number): this;
        /// </summary>
        public Vector4 SetZ(float z)
        {
            return JSRef!.Call<Vector4>("setZ", z);
        }
        /// <summary>
        /// setY(y: number): this;
        /// </summary>
        public Vector4 SetY(float y)
        {
            return JSRef!.Call<Vector4>("setY", y);
        }
        /// <summary>
        /// setX(x: number): this;
        /// </summary>
        public Vector4 SetX(float x)
        {
            return JSRef!.Call<Vector4>("setX", x);
        }
        /// <summary>
        /// setW(w: number): this;
        /// </summary>
        public Vector4 SetW(float w)
        {
            return JSRef!.Call<Vector4>("setW", w);
        }
        /// <summary>
        /// setScalar(scalar: number): this;
        /// </summary>
        public Vector4 SetScalar(float scalar)
        {
            return JSRef!.Call<Vector4>("setScalar", scalar);
        }
        /// <summary>
        /// setLength(length: number): this;
        /// </summary>
        public Vector4 SetLength(float length)
        {
            return JSRef!.Call<Vector4>("setLength", length);
        }
        /// <summary>
        /// setFromMatrixPosition(m: Matrix4): this;
        /// </summary>
        public Vector4 SetFromMatrixPosition(Matrix4 m)
        {
            return JSRef!.Call<Vector4>("setFromMatrixPosition", m);
        }
        /// <summary>
        /// setComponent(index: number, value: number): this;
        /// </summary>
        public Vector4 SetComponent(float index, float value)
        {
            return JSRef!.Call<Vector4>("setComponent", index, value);
        }
        /// <summary>
        /// setAxisAngleFromRotationMatrix(m: Matrix4): this;
        /// </summary>
        public Vector4 SetAxisAngleFromRotationMatrix(Matrix4 m)
        {
            return JSRef!.Call<Vector4>("setAxisAngleFromRotationMatrix", m);
        }
        /// <summary>
        /// setAxisAngleFromQuaternion(q: QuaternionLike): this;
        /// </summary>
        public Vector4 SetAxisAngleFromQuaternion(QuaternionLike q)
        {
            return JSRef!.Call<Vector4>("setAxisAngleFromQuaternion", q);
        }
        /// <summary>
        /// set(x: number, y: number, z: number, w: number): this;
        /// </summary>
        public Vector4 Set(float x, float y, float z, float w)
        {
            return JSRef!.Call<Vector4>("set", x, y, z, w);
        }
        /// <summary>
        /// roundToZero(): this;
        /// </summary>
        public Vector4 RoundToZero()
        {
            return JSRef!.Call<Vector4>("roundToZero");
        }
        /// <summary>
        /// round(): this;
        /// </summary>
        public Vector4 Round()
        {
            return JSRef!.Call<Vector4>("round");
        }
        /// <summary>
        /// random(): this;
        /// </summary>
        public Vector4 Random()
        {
            return JSRef!.Call<Vector4>("random");
        }
        /// <summary>
        /// normalize(): this;
        /// </summary>
        public Vector4 Normalize()
        {
            return JSRef!.Call<Vector4>("normalize");
        }
        /// <summary>
        /// negate(): this;
        /// </summary>
        public Vector4 Negate()
        {
            return JSRef!.Call<Vector4>("negate");
        }
        /// <summary>
        /// multiplyScalar(s: number): this;
        /// </summary>
        public Vector4 MultiplyScalar(float s)
        {
            return JSRef!.Call<Vector4>("multiplyScalar", s);
        }
        /// <summary>
        /// multiply(v: Vector4Like): this;
        /// </summary>
        public Vector4 Multiply(Vector4Like v)
        {
            return JSRef!.Call<Vector4>("multiply", v);
        }
        /// <summary>
        /// min(v: Vector4Like): this;
        /// </summary>
        public Vector4 Min(Vector4Like v)
        {
            return JSRef!.Call<Vector4>("min", v);
        }
        /// <summary>
        /// max(v: Vector4Like): this;
        /// </summary>
        public Vector4 Max(Vector4Like v)
        {
            return JSRef!.Call<Vector4>("max", v);
        }
        /// <summary>
        /// manhattanLength(): number;
        /// </summary>
        public float ManhattanLength()
        {
            return JSRef!.Call<float>("manhattanLength");
        }
        /// <summary>
        /// lerpVectors(v1: Vector4Like, v2: Vector4Like, alpha: number): this;
        /// </summary>
        public Vector4 LerpVectors(Vector4Like v1, Vector4Like v2, float alpha)
        {
            return JSRef!.Call<Vector4>("lerpVectors", v1, v2, alpha);
        }
        /// <summary>
        /// lerp(v: Vector4Like, alpha: number): this;
        /// </summary>
        public Vector4 Lerp(Vector4Like v, float alpha)
        {
            return JSRef!.Call<Vector4>("lerp", v, alpha);
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
        public Vector4 FromBufferAttribute(BufferAttribute attribute, float index)
        {
            return JSRef!.Call<Vector4>("fromBufferAttribute", attribute, index);
        }
        /// <summary>
        /// fromArray(array: number[] | ArrayLike<number>, offset?: number): this;
        /// </summary>
        public Vector4 FromArray(Union<Array<float>, ArrayLikeFloat> array, float offset)
        {
            return JSRef!.Call<Vector4>("fromArray", array, offset);
        }
        /// <summary>
        /// floor(): this;
        /// </summary>
        public Vector4 Floor()
        {
            return JSRef!.Call<Vector4>("floor");
        }
        /// <summary>
        /// equals(v: Vector4Like): boolean;
        /// </summary>
        public bool Equals(Vector4Like v)
        {
            return JSRef!.Call<bool>("equals", v);
        }
        /// <summary>
        /// dot(v: Vector4Like): number;
        /// </summary>
        public float Dot(Vector4Like v)
        {
            return JSRef!.Call<float>("dot", v);
        }
        /// <summary>
        /// divideScalar(s: number): this;
        /// </summary>
        public Vector4 DivideScalar(float s)
        {
            return JSRef!.Call<Vector4>("divideScalar", s);
        }
        /// <summary>
        /// divide(v: Vector4Like): this;
        /// </summary>
        public Vector4 Divide(Vector4Like v)
        {
            return JSRef!.Call<Vector4>("divide", v);
        }
        /// <summary>
        /// copy(v: Vector4Like): this;
        /// </summary>
        public Vector4 Copy(Vector4Like v)
        {
            return JSRef!.Call<Vector4>("copy", v);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Vector4 Clone()
        {
            return JSRef!.Call<Vector4>("clone");
        }
        /// <summary>
        /// clampScalar(min: number, max: number): this;
        /// </summary>
        public Vector4 ClampScalar(float min, float max)
        {
            return JSRef!.Call<Vector4>("clampScalar", min, max);
        }
        /// <summary>
        /// clamp(min: Vector4Like, max: Vector4Like): this;
        /// </summary>
        public Vector4 Clamp(Vector4Like min, Vector4Like max)
        {
            return JSRef!.Call<Vector4>("clamp", min, max);
        }
        /// <summary>
        /// ceil(): this;
        /// </summary>
        public Vector4 Ceil()
        {
            return JSRef!.Call<Vector4>("ceil");
        }
        /// <summary>
        /// applyMatrix4(m: Matrix4): this;
        /// </summary>
        public Vector4 ApplyMatrix4(Matrix4 m)
        {
            return JSRef!.Call<Vector4>("applyMatrix4", m);
        }
        /// <summary>
        /// addVectors(a: Vector4Like, b: Vector4Like): this;
        /// </summary>
        public Vector4 AddVectors(Vector4Like a, Vector4Like b)
        {
            return JSRef!.Call<Vector4>("addVectors", a, b);
        }
        /// <summary>
        /// addScaledVector(v: Vector4Like, s: number): this;
        /// </summary>
        public Vector4 AddScaledVector(Vector4Like v, float s)
        {
            return JSRef!.Call<Vector4>("addScaledVector", v, s);
        }
        /// <summary>
        /// addScalar(scalar: number): this;
        /// </summary>
        public Vector4 AddScalar(float scalar)
        {
            return JSRef!.Call<Vector4>("addScalar", scalar);
        }
        /// <summary>
        /// add(v: Vector4Like): this;
        /// </summary>
        public Vector4 Add(Vector4Like v)
        {
            return JSRef!.Call<Vector4>("add", v);
        }
        #endregion
    }
}
