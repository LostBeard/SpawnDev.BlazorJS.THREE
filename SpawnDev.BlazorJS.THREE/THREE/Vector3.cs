
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector3 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(x?: number, y?: number, z?: number);
        /// </summary>
        public Vector3(float x, float y, float z) : base(JS.New("THREE.Vector3", x, y, z)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isVector3: true;
        /// </summary>
        public bool IsVector3 { get => JSRef!.Get<bool>("isVector3"); }
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
        /// unproject(camera: Camera): this;
        /// </summary>
        public Vector3 Unproject(Camera camera)
        {
            return JSRef!.Call<Vector3>("unproject", camera);
        }
        /// <summary>
        /// transformDirection(m: Matrix4): this;
        /// </summary>
        public Vector3 TransformDirection(Matrix4 m)
        {
            return JSRef!.Call<Vector3>("transformDirection", m);
        }
        /// <summary>
        /// toArray(array?: number[], offset?: number): number[];
        /// </summary>
        public Array<float> ToArray(Array<float> array, float offset)
        {
            return JSRef!.Call<Array<float>>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(array?: Vector3Tuple, offset?: 0): Vector3Tuple;
        /// </summary>
        public Vector3Tuple ToArray(Vector3Tuple array, float offset)
        {
            return JSRef!.Call<Vector3Tuple>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(array: ArrayLike<number>, offset?: number): ArrayLike<number>;
        /// </summary>
        public ArrayLikeFloat ToArray(ArrayLikeFloat array, float offset)
        {
            return JSRef!.Call<ArrayLikeFloat>("toArray", array, offset);
        }
        /// <summary>
        /// subVectors(a: Vector3Like, b: Vector3Like): this;
        /// </summary>
        public Vector3 SubVectors(Vector3Like a, Vector3Like b)
        {
            return JSRef!.Call<Vector3>("subVectors", a, b);
        }
        /// <summary>
        /// subScalar(s: number): this;
        /// </summary>
        public Vector3 SubScalar(float s)
        {
            return JSRef!.Call<Vector3>("subScalar", s);
        }
        /// <summary>
        /// sub(a: Vector3Like): this;
        /// </summary>
        public Vector3 Sub(Vector3Like a)
        {
            return JSRef!.Call<Vector3>("sub", a);
        }
        /// <summary>
        /// setZ(z: number): this;
        /// </summary>
        public Vector3 SetZ(float z)
        {
            return JSRef!.Call<Vector3>("setZ", z);
        }
        /// <summary>
        /// setY(y: number): this;
        /// </summary>
        public Vector3 SetY(float y)
        {
            return JSRef!.Call<Vector3>("setY", y);
        }
        /// <summary>
        /// setX(x: number): this;
        /// </summary>
        public Vector3 SetX(float x)
        {
            return JSRef!.Call<Vector3>("setX", x);
        }
        /// <summary>
        /// setScalar(scalar: number): this;
        /// </summary>
        public Vector3 SetScalar(float scalar)
        {
            return JSRef!.Call<Vector3>("setScalar", scalar);
        }
        /// <summary>
        /// setLength(l: number): this;
        /// </summary>
        public Vector3 SetLength(float l)
        {
            return JSRef!.Call<Vector3>("setLength", l);
        }
        /// <summary>
        /// setFromSphericalCoords(r: number, phi: number, theta: number): this;
        /// </summary>
        public Vector3 SetFromSphericalCoords(float r, float phi, float theta)
        {
            return JSRef!.Call<Vector3>("setFromSphericalCoords", r, phi, theta);
        }
        /// <summary>
        /// setFromSpherical(s: Spherical): this;
        /// </summary>
        public Vector3 SetFromSpherical(Spherical s)
        {
            return JSRef!.Call<Vector3>("setFromSpherical", s);
        }
        /// <summary>
        /// setFromMatrixScale(m: Matrix4): this;
        /// </summary>
        public Vector3 SetFromMatrixScale(Matrix4 m)
        {
            return JSRef!.Call<Vector3>("setFromMatrixScale", m);
        }
        /// <summary>
        /// setFromMatrixPosition(m: Matrix4): this;
        /// </summary>
        public Vector3 SetFromMatrixPosition(Matrix4 m)
        {
            return JSRef!.Call<Vector3>("setFromMatrixPosition", m);
        }
        /// <summary>
        /// setFromMatrixColumn(matrix: Matrix4, index: number): this;
        /// </summary>
        public Vector3 SetFromMatrixColumn(Matrix4 matrix, float index)
        {
            return JSRef!.Call<Vector3>("setFromMatrixColumn", matrix, index);
        }
        /// <summary>
        /// setFromMatrix3Column(matrix: Matrix3, index: number): this;
        /// </summary>
        public Vector3 SetFromMatrix3Column(Matrix3 matrix, float index)
        {
            return JSRef!.Call<Vector3>("setFromMatrix3Column", matrix, index);
        }
        /// <summary>
        /// setFromEuler(e: Euler): this;
        /// </summary>
        public Vector3 SetFromEuler(Euler e)
        {
            return JSRef!.Call<Vector3>("setFromEuler", e);
        }
        /// <summary>
        /// setFromCylindricalCoords(radius: number, theta: number, y: number): this;
        /// </summary>
        public Vector3 SetFromCylindricalCoords(float radius, float theta, float y)
        {
            return JSRef!.Call<Vector3>("setFromCylindricalCoords", radius, theta, y);
        }
        /// <summary>
        /// setFromCylindrical(s: Cylindrical): this;
        /// </summary>
        public Vector3 SetFromCylindrical(Cylindrical s)
        {
            return JSRef!.Call<Vector3>("setFromCylindrical", s);
        }
        /// <summary>
        /// setFromColor(color: RGB): this;
        /// </summary>
        public Vector3 SetFromColor(RGB color)
        {
            return JSRef!.Call<Vector3>("setFromColor", color);
        }
        /// <summary>
        /// setComponent(index: number, value: number): this;
        /// </summary>
        public Vector3 SetComponent(float index, float value)
        {
            return JSRef!.Call<Vector3>("setComponent", index, value);
        }
        /// <summary>
        /// set(x: number, y: number, z: number): this;
        /// </summary>
        public Vector3 Set(float x, float y, float z)
        {
            return JSRef!.Call<Vector3>("set", x, y, z);
        }
        /// <summary>
        /// roundToZero(): this;
        /// </summary>
        public Vector3 RoundToZero()
        {
            return JSRef!.Call<Vector3>("roundToZero");
        }
        /// <summary>
        /// round(): this;
        /// </summary>
        public Vector3 Round()
        {
            return JSRef!.Call<Vector3>("round");
        }
        /// <summary>
        /// reflect(vector: Vector3Like): this;
        /// </summary>
        public Vector3 Reflect(Vector3Like vector)
        {
            return JSRef!.Call<Vector3>("reflect", vector);
        }
        /// <summary>
        /// randomDirection(): this;
        /// </summary>
        public Vector3 RandomDirection()
        {
            return JSRef!.Call<Vector3>("randomDirection");
        }
        /// <summary>
        /// random(): this;
        /// </summary>
        public Vector3 Random()
        {
            return JSRef!.Call<Vector3>("random");
        }
        /// <summary>
        /// projectOnVector(v: Vector3): this;
        /// </summary>
        public Vector3 ProjectOnVector(Vector3 v)
        {
            return JSRef!.Call<Vector3>("projectOnVector", v);
        }
        /// <summary>
        /// projectOnPlane(planeNormal: Vector3): this;
        /// </summary>
        public Vector3 ProjectOnPlane(Vector3 planeNormal)
        {
            return JSRef!.Call<Vector3>("projectOnPlane", planeNormal);
        }
        /// <summary>
        /// project(camera: Camera): this;
        /// </summary>
        public Vector3 Project(Camera camera)
        {
            return JSRef!.Call<Vector3>("project", camera);
        }
        /// <summary>
        /// normalize(): this;
        /// </summary>
        public Vector3 Normalize()
        {
            return JSRef!.Call<Vector3>("normalize");
        }
        /// <summary>
        /// negate(): this;
        /// </summary>
        public Vector3 Negate()
        {
            return JSRef!.Call<Vector3>("negate");
        }
        /// <summary>
        /// multiplyVectors(a: Vector3Like, b: Vector3Like): this;
        /// </summary>
        public Vector3 MultiplyVectors(Vector3Like a, Vector3Like b)
        {
            return JSRef!.Call<Vector3>("multiplyVectors", a, b);
        }
        /// <summary>
        /// multiplyScalar(s: number): this;
        /// </summary>
        public Vector3 MultiplyScalar(float s)
        {
            return JSRef!.Call<Vector3>("multiplyScalar", s);
        }
        /// <summary>
        /// multiply(v: Vector3Like): this;
        /// </summary>
        public Vector3 Multiply(Vector3Like v)
        {
            return JSRef!.Call<Vector3>("multiply", v);
        }
        /// <summary>
        /// min(v: Vector3Like): this;
        /// </summary>
        public Vector3 Min(Vector3Like v)
        {
            return JSRef!.Call<Vector3>("min", v);
        }
        /// <summary>
        /// max(v: Vector3Like): this;
        /// </summary>
        public Vector3 Max(Vector3Like v)
        {
            return JSRef!.Call<Vector3>("max", v);
        }
        /// <summary>
        /// manhattanLength(): number;
        /// </summary>
        public float ManhattanLength()
        {
            return JSRef!.Call<float>("manhattanLength");
        }
        /// <summary>
        /// manhattanDistanceTo(v: Vector3Like): number;
        /// </summary>
        public float ManhattanDistanceTo(Vector3Like v)
        {
            return JSRef!.Call<float>("manhattanDistanceTo", v);
        }
        /// <summary>
        /// lerpVectors(v1: Vector3Like, v2: Vector3Like, alpha: number): this;
        /// </summary>
        public Vector3 LerpVectors(Vector3Like v1, Vector3Like v2, float alpha)
        {
            return JSRef!.Call<Vector3>("lerpVectors", v1, v2, alpha);
        }
        /// <summary>
        /// lerp(v: Vector3Like, alpha: number): this;
        /// </summary>
        public Vector3 Lerp(Vector3Like v, float alpha)
        {
            return JSRef!.Call<Vector3>("lerp", v, alpha);
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
        /// fromBufferAttribute(attribute: BufferAttribute | InterleavedBufferAttribute, index: number): this;
        /// </summary>
        public Vector3 FromBufferAttribute(Union<BufferAttribute, InterleavedBufferAttribute> attribute, float index)
        {
            return JSRef!.Call<Vector3>("fromBufferAttribute", attribute, index);
        }
        /// <summary>
        /// fromArray(array: number[] | ArrayLike<number>, offset?: number): this;
        /// </summary>
        public Vector3 FromArray(Union<Array<float>, ArrayLikeFloat> array, float offset)
        {
            return JSRef!.Call<Vector3>("fromArray", array, offset);
        }
        /// <summary>
        /// floor(): this;
        /// </summary>
        public Vector3 Floor()
        {
            return JSRef!.Call<Vector3>("floor");
        }
        /// <summary>
        /// equals(v: Vector3Like): boolean;
        /// </summary>
        public bool Equals(Vector3Like v)
        {
            return JSRef!.Call<bool>("equals", v);
        }
        /// <summary>
        /// dot(v: Vector3Like): number;
        /// </summary>
        public float Dot(Vector3Like v)
        {
            return JSRef!.Call<float>("dot", v);
        }
        /// <summary>
        /// divideScalar(s: number): this;
        /// </summary>
        public Vector3 DivideScalar(float s)
        {
            return JSRef!.Call<Vector3>("divideScalar", s);
        }
        /// <summary>
        /// divide(v: Vector3Like): this;
        /// </summary>
        public Vector3 Divide(Vector3Like v)
        {
            return JSRef!.Call<Vector3>("divide", v);
        }
        /// <summary>
        /// distanceToSquared(v: Vector3Like): number;
        /// </summary>
        public float DistanceToSquared(Vector3Like v)
        {
            return JSRef!.Call<float>("distanceToSquared", v);
        }
        /// <summary>
        /// distanceTo(v: Vector3Like): number;
        /// </summary>
        public float DistanceTo(Vector3Like v)
        {
            return JSRef!.Call<float>("distanceTo", v);
        }
        /// <summary>
        /// crossVectors(a: Vector3Like, b: Vector3Like): this;
        /// </summary>
        public Vector3 CrossVectors(Vector3Like a, Vector3Like b)
        {
            return JSRef!.Call<Vector3>("crossVectors", a, b);
        }
        /// <summary>
        /// cross(a: Vector3Like): this;
        /// </summary>
        public Vector3 Cross(Vector3Like a)
        {
            return JSRef!.Call<Vector3>("cross", a);
        }
        /// <summary>
        /// copy(v: Vector3Like): this;
        /// </summary>
        public Vector3 Copy(Vector3Like v)
        {
            return JSRef!.Call<Vector3>("copy", v);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Vector3 Clone()
        {
            return JSRef!.Call<Vector3>("clone");
        }
        /// <summary>
        /// clampScalar(min: number, max: number): this;
        /// </summary>
        public Vector3 ClampScalar(float min, float max)
        {
            return JSRef!.Call<Vector3>("clampScalar", min, max);
        }
        /// <summary>
        /// clampLength(min: number, max: number): this;
        /// </summary>
        public Vector3 ClampLength(float min, float max)
        {
            return JSRef!.Call<Vector3>("clampLength", min, max);
        }
        /// <summary>
        /// clamp(min: Vector3Like, max: Vector3Like): this;
        /// </summary>
        public Vector3 Clamp(Vector3Like min, Vector3Like max)
        {
            return JSRef!.Call<Vector3>("clamp", min, max);
        }
        /// <summary>
        /// ceil(): this;
        /// </summary>
        public Vector3 Ceil()
        {
            return JSRef!.Call<Vector3>("ceil");
        }
        /// <summary>
        /// applyQuaternion(q: QuaternionLike): this;
        /// </summary>
        public Vector3 ApplyQuaternion(QuaternionLike q)
        {
            return JSRef!.Call<Vector3>("applyQuaternion", q);
        }
        /// <summary>
        /// applyNormalMatrix(m: Matrix3): this;
        /// </summary>
        public Vector3 ApplyNormalMatrix(Matrix3 m)
        {
            return JSRef!.Call<Vector3>("applyNormalMatrix", m);
        }
        /// <summary>
        /// applyMatrix4(m: Matrix4): this;
        /// </summary>
        public Vector3 ApplyMatrix4(Matrix4 m)
        {
            return JSRef!.Call<Vector3>("applyMatrix4", m);
        }
        /// <summary>
        /// applyMatrix3(m: Matrix3): this;
        /// </summary>
        public Vector3 ApplyMatrix3(Matrix3 m)
        {
            return JSRef!.Call<Vector3>("applyMatrix3", m);
        }
        /// <summary>
        /// applyEuler(euler: Euler): this;
        /// </summary>
        public Vector3 ApplyEuler(Euler euler)
        {
            return JSRef!.Call<Vector3>("applyEuler", euler);
        }
        /// <summary>
        /// applyAxisAngle(axis: Vector3, angle: number): this;
        /// </summary>
        public Vector3 ApplyAxisAngle(Vector3 axis, float angle)
        {
            return JSRef!.Call<Vector3>("applyAxisAngle", axis, angle);
        }
        /// <summary>
        /// angleTo(v: Vector3): number;
        /// </summary>
        public float AngleTo(Vector3 v)
        {
            return JSRef!.Call<float>("angleTo", v);
        }
        /// <summary>
        /// addVectors(a: Vector3Like, b: Vector3Like): this;
        /// </summary>
        public Vector3 AddVectors(Vector3Like a, Vector3Like b)
        {
            return JSRef!.Call<Vector3>("addVectors", a, b);
        }
        /// <summary>
        /// addScaledVector(v: Vector3, s: number): this;
        /// </summary>
        public Vector3 AddScaledVector(Vector3 v, float s)
        {
            return JSRef!.Call<Vector3>("addScaledVector", v, s);
        }
        /// <summary>
        /// addScalar(s: number): this;
        /// </summary>
        public Vector3 AddScalar(float s)
        {
            return JSRef!.Call<Vector3>("addScalar", s);
        }
        /// <summary>
        /// add(v: Vector3Like): this;
        /// </summary>
        public Vector3 Add(Vector3Like v)
        {
            return JSRef!.Call<Vector3>("add", v);
        }
        #endregion
    }
}
