
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Quaternion : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Quaternion(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(x?: number, y?: number, z?: number, w?: number);
        /// </summary>
        public Quaternion(float x, float y, float z, float w) : base(JS.New("THREE.Quaternion", x, y, z, w)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isQuaternion: true;
        /// </summary>
        public bool IsQuaternion { get => JSRef!.Get<bool>("isQuaternion"); }
        /// <summary>
        /// w: number;
        /// </summary>
        public float W { get => JSRef!.Get<float>("w"); set => JSRef!.Set("w", value); }
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
        /// toJSON(): [number, number, number, number];
        /// </summary>
        public (float, float, float, float) ToJSON()
        {
            return JSRef!.Call<(float, float, float, float)>("toJSON");
        }
        /// <summary>
        /// toArray(array?: number[], offset?: number): number[];
        /// </summary>
        public Array<float> ToArray(Array<float> array, float offset)
        {
            return JSRef!.Call<Array<float>>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(array?: QuaternionTuple, offset?: 0): QuaternionTuple;
        /// </summary>
        public QuaternionTuple ToArray(QuaternionTuple array, float offset)
        {
            return JSRef!.Call<QuaternionTuple>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(array: ArrayLike<number>, offset?: number): ArrayLike<number>;
        /// </summary>
        public ArrayLikeFloat ToArray(ArrayLikeFloat array, float offset)
        {
            return JSRef!.Call<ArrayLikeFloat>("toArray", array, offset);
        }
        /// <summary>
        /// slerpQuaternions(qa: Quaternion, qb: Quaternion, t: number): this;
        /// </summary>
        public Quaternion SlerpQuaternions(Quaternion qa, Quaternion qb, float t)
        {
            return JSRef!.Call<Quaternion>("slerpQuaternions", qa, qb, t);
        }
        /// <summary>
        /// static slerpFlat(
        ///         dst: number[],
        ///         dstOffset: number,
        ///         src0: number[],
        ///         srcOffset: number,
        ///         src1: number[],
        ///         stcOffset1: number,
        ///         t: number,
        ///     ): void;
        /// </summary>
        public void SlerpFlat(Array<float> dst, float dstOffset, Array<float> src0, float srcOffset, Array<float> src1, float stcOffset1, float t)
        {
            JSRef!.CallVoid("slerpFlat", dst, dstOffset, src0, srcOffset, src1, stcOffset1, t);
        }
        /// <summary>
        /// slerp(qb: Quaternion, t: number): this;
        /// </summary>
        public Quaternion Slerp(Quaternion qb, float t)
        {
            return JSRef!.Call<Quaternion>("slerp", qb, t);
        }
        /// <summary>
        /// setFromUnitVectors(vFrom: Vector3, vTo: Vector3Like): this;
        /// </summary>
        public Quaternion SetFromUnitVectors(Vector3 vFrom, Vector3Like vTo)
        {
            return JSRef!.Call<Quaternion>("setFromUnitVectors", vFrom, vTo);
        }
        /// <summary>
        /// setFromRotationMatrix(m: Matrix4): this;
        /// </summary>
        public Quaternion SetFromRotationMatrix(Matrix4 m)
        {
            return JSRef!.Call<Quaternion>("setFromRotationMatrix", m);
        }
        /// <summary>
        /// setFromEuler(euler: Euler, update?: boolean): this;
        /// </summary>
        public Quaternion SetFromEuler(Euler euler, bool update)
        {
            return JSRef!.Call<Quaternion>("setFromEuler", euler, update);
        }
        /// <summary>
        /// setFromAxisAngle(axis: Vector3Like, angle: number): this;
        /// </summary>
        public Quaternion SetFromAxisAngle(Vector3Like axis, float angle)
        {
            return JSRef!.Call<Quaternion>("setFromAxisAngle", axis, angle);
        }
        /// <summary>
        /// set(x: number, y: number, z: number, w: number): this;
        /// </summary>
        public Quaternion Set(float x, float y, float z, float w)
        {
            return JSRef!.Call<Quaternion>("set", x, y, z, w);
        }
        /// <summary>
        /// rotateTowards(q: Quaternion, step: number): this;
        /// </summary>
        public Quaternion RotateTowards(Quaternion q, float step)
        {
            return JSRef!.Call<Quaternion>("rotateTowards", q, step);
        }
        /// <summary>
        /// random(): this;
        /// </summary>
        public Quaternion Random()
        {
            return JSRef!.Call<Quaternion>("random");
        }
        /// <summary>
        /// premultiply(q: Quaternion): this;
        /// </summary>
        public Quaternion Premultiply(Quaternion q)
        {
            return JSRef!.Call<Quaternion>("premultiply", q);
        }
        /// <summary>
        /// normalize(): this;
        /// </summary>
        public Quaternion Normalize()
        {
            return JSRef!.Call<Quaternion>("normalize");
        }
        /// <summary>
        /// static multiplyQuaternionsFlat(
        ///         dst: number[],
        ///         dstOffset: number,
        ///         src0: number[],
        ///         srcOffset: number,
        ///         src1: number[],
        ///         stcOffset1: number,
        ///     ): number[];
        /// </summary>
        public Array<float> MultiplyQuaternionsFlat(Array<float> dst, float dstOffset, Array<float> src0, float srcOffset, Array<float> src1, float stcOffset1)
        {
            return JSRef!.Call<Array<float>>("multiplyQuaternionsFlat", dst, dstOffset, src0, srcOffset, src1, stcOffset1);
        }
        /// <summary>
        /// multiplyQuaternions(a: Quaternion, b: Quaternion): this;
        /// </summary>
        public Quaternion MultiplyQuaternions(Quaternion a, Quaternion b)
        {
            return JSRef!.Call<Quaternion>("multiplyQuaternions", a, b);
        }
        /// <summary>
        /// multiply(q: Quaternion): this;
        /// </summary>
        public Quaternion Multiply(Quaternion q)
        {
            return JSRef!.Call<Quaternion>("multiply", q);
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
        /// invert(): this;
        /// </summary>
        public Quaternion Invert()
        {
            return JSRef!.Call<Quaternion>("invert");
        }
        /// <summary>
        /// identity(): this;
        /// </summary>
        public Quaternion Identity()
        {
            return JSRef!.Call<Quaternion>("identity");
        }
        /// <summary>
        /// fromBufferAttribute(attribute: BufferAttribute | InterleavedBufferAttribute, index: number): this;
        /// </summary>
        public Quaternion FromBufferAttribute(Union<BufferAttribute, InterleavedBufferAttribute> attribute, float index)
        {
            return JSRef!.Call<Quaternion>("fromBufferAttribute", attribute, index);
        }
        /// <summary>
        /// fromArray(array: number[] | ArrayLike<number>, offset?: number): this;
        /// </summary>
        public Quaternion FromArray(Union<Array<float>, ArrayLikeFloat> array, float offset)
        {
            return JSRef!.Call<Quaternion>("fromArray", array, offset);
        }
        /// <summary>
        /// equals(v: Quaternion): boolean;
        /// </summary>
        public bool Equals(Quaternion v)
        {
            return JSRef!.Call<bool>("equals", v);
        }
        /// <summary>
        /// dot(v: Quaternion): number;
        /// </summary>
        public float Dot(Quaternion v)
        {
            return JSRef!.Call<float>("dot", v);
        }
        /// <summary>
        /// copy(q: QuaternionLike): this;
        /// </summary>
        public Quaternion Copy(QuaternionLike q)
        {
            return JSRef!.Call<Quaternion>("copy", q);
        }
        /// <summary>
        /// conjugate(): this;
        /// </summary>
        public Quaternion Conjugate()
        {
            return JSRef!.Call<Quaternion>("conjugate");
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Quaternion Clone()
        {
            return JSRef!.Call<Quaternion>("clone");
        }
        /// <summary>
        /// angleTo(q: Quaternion): number;
        /// </summary>
        public float AngleTo(Quaternion q)
        {
            return JSRef!.Call<float>("angleTo", q);
        }
        #endregion
    }
}
