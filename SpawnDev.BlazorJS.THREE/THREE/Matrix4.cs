
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix4 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix4(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Matrix4() : base(JS.New("THREE.Matrix4")) { }
        
        
        /// <summary>
        /// constructor(
        ///         n11: number,
        ///         n12: number,
        ///         n13: number,
        ///         n14: number,
        ///         n21: number,
        ///         n22: number,
        ///         n23: number,
        ///         n24: number,
        ///         n31: number,
        ///         n32: number,
        ///         n33: number,
        ///         n34: number,
        ///         n41: number,
        ///         n42: number,
        ///         n43: number,
        ///         n44: number,
        ///     );
        /// </summary>
        public Matrix4(float n11, float n12, float n13, float n14, float n21, float n22, float n23, float n24, float n31, float n32, float n33, float n34, float n41, float n42, float n43, float n44) : base(JS.NewApply("THREE.Matrix4", new object?[] { n11, n12, n13, n14, n21, n22, n23, n24, n31, n32, n33, n34, n41, n42, n43, n44 })) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// elements: Matrix4Tuple;
        /// </summary>
        public Matrix4Tuple Elements { get => JSRef!.Get<Matrix4Tuple>("elements"); set => JSRef!.Set("elements", value); }
        /// <summary>
        /// readonly isMatrix4: true;
        /// </summary>
        public bool IsMatrix4 { get => JSRef!.Get<bool>("isMatrix4"); }
        #endregion

        #region Methods
        /// <summary>
        /// transpose(): this;
        /// </summary>
        public Matrix4 Transpose()
        {
            return JSRef!.Call<Matrix4>("transpose");
        }
        /// <summary>
        /// toArray(): Matrix4Tuple;
        /// </summary>
        public Matrix4Tuple ToArray()
        {
            return JSRef!.Call<Matrix4Tuple>("toArray");
        }
        /// <summary>
        /// toArray<TArray extends ArrayLike<number>>(array: TArray, offset?: number): TArray;
        /// </summary>
        public TArray ToArray<TArray>(TArray array, float offset)
        {
            return JSRef!.Call<TArray>("toArray", array, offset);
        }
        /// <summary>
        /// setPosition(v: Vector3): this;
        /// </summary>
        public Matrix4 SetPosition(Vector3 v)
        {
            return JSRef!.Call<Matrix4>("setPosition", v);
        }
        /// <summary>
        /// setPosition(x: number, y: number, z: number): this;
        /// </summary>
        public Matrix4 SetPosition(float x, float y, float z)
        {
            return JSRef!.Call<Matrix4>("setPosition", x, y, z);
        }
        /// <summary>
        /// setFromMatrix3(m: Matrix3): this;
        /// </summary>
        public Matrix4 SetFromMatrix3(Matrix3 m)
        {
            return JSRef!.Call<Matrix4>("setFromMatrix3", m);
        }
        /// <summary>
        /// set(
        ///         n11: number,
        ///         n12: number,
        ///         n13: number,
        ///         n14: number,
        ///         n21: number,
        ///         n22: number,
        ///         n23: number,
        ///         n24: number,
        ///         n31: number,
        ///         n32: number,
        ///         n33: number,
        ///         n34: number,
        ///         n41: number,
        ///         n42: number,
        ///         n43: number,
        ///         n44: number,
        ///     ): this;
        /// </summary>
        public Matrix4 Set(float n11, float n12, float n13, float n14, float n21, float n22, float n23, float n24, float n31, float n32, float n33, float n34, float n41, float n42, float n43, float n44)
        {
            return JSRef!.CallApply<Matrix4>("set", new object?[] { n11, n12, n13, n14, n21, n22, n23, n24, n31, n32, n33, n34, n41, n42, n43, n44 });
        }
        /// <summary>
        /// scale(v: Vector3): this;
        /// </summary>
        public Matrix4 Scale(Vector3 v)
        {
            return JSRef!.Call<Matrix4>("scale", v);
        }
        /// <summary>
        /// premultiply(m: Matrix4): this;
        /// </summary>
        public Matrix4 Premultiply(Matrix4 m)
        {
            return JSRef!.Call<Matrix4>("premultiply", m);
        }
        /// <summary>
        /// multiplyScalar(s: number): this;
        /// </summary>
        public Matrix4 MultiplyScalar(float s)
        {
            return JSRef!.Call<Matrix4>("multiplyScalar", s);
        }
        /// <summary>
        /// multiplyMatrices(a: Matrix4, b: Matrix4): this;
        /// </summary>
        public Matrix4 MultiplyMatrices(Matrix4 a, Matrix4 b)
        {
            return JSRef!.Call<Matrix4>("multiplyMatrices", a, b);
        }
        /// <summary>
        /// multiply(m: Matrix4): this;
        /// </summary>
        public Matrix4 Multiply(Matrix4 m)
        {
            return JSRef!.Call<Matrix4>("multiply", m);
        }
        /// <summary>
        /// makeTranslation(v: Vector3): this;
        /// </summary>
        public Matrix4 MakeTranslation(Vector3 v)
        {
            return JSRef!.Call<Matrix4>("makeTranslation", v);
        }
        /// <summary>
        /// makeTranslation(x: number, y: number, z: number): this;
        /// </summary>
        public Matrix4 MakeTranslation(float x, float y, float z)
        {
            return JSRef!.Call<Matrix4>("makeTranslation", x, y, z);
        }
        /// <summary>
        /// makeShear(xy: number, xz: number, yx: number, yz: number, zx: number, zy: number): this;
        /// </summary>
        public Matrix4 MakeShear(float xy, float xz, float yx, float yz, float zx, float zy)
        {
            return JSRef!.Call<Matrix4>("makeShear", xy, xz, yx, yz, zx, zy);
        }
        /// <summary>
        /// makeScale(x: number, y: number, z: number): this;
        /// </summary>
        public Matrix4 MakeScale(float x, float y, float z)
        {
            return JSRef!.Call<Matrix4>("makeScale", x, y, z);
        }
        /// <summary>
        /// makeRotationZ(theta: number): this;
        /// </summary>
        public Matrix4 MakeRotationZ(float theta)
        {
            return JSRef!.Call<Matrix4>("makeRotationZ", theta);
        }
        /// <summary>
        /// makeRotationY(theta: number): this;
        /// </summary>
        public Matrix4 MakeRotationY(float theta)
        {
            return JSRef!.Call<Matrix4>("makeRotationY", theta);
        }
        /// <summary>
        /// makeRotationX(theta: number): this;
        /// </summary>
        public Matrix4 MakeRotationX(float theta)
        {
            return JSRef!.Call<Matrix4>("makeRotationX", theta);
        }
        /// <summary>
        /// makeRotationFromQuaternion(q: Quaternion): this;
        /// </summary>
        public Matrix4 MakeRotationFromQuaternion(Quaternion q)
        {
            return JSRef!.Call<Matrix4>("makeRotationFromQuaternion", q);
        }
        /// <summary>
        /// makeRotationFromEuler(euler: Euler): this;
        /// </summary>
        public Matrix4 MakeRotationFromEuler(Euler euler)
        {
            return JSRef!.Call<Matrix4>("makeRotationFromEuler", euler);
        }
        /// <summary>
        /// makeRotationAxis(axis: Vector3, angle: number): this;
        /// </summary>
        public Matrix4 MakeRotationAxis(Vector3 axis, float angle)
        {
            return JSRef!.Call<Matrix4>("makeRotationAxis", axis, angle);
        }
        /// <summary>
        /// makePerspective(
        ///         left: number,
        ///         right: number,
        ///         top: number,
        ///         bottom: number,
        ///         near: number,
        ///         far: number,
        ///         coordinateSystem?: CoordinateSystem,
        ///         reversedDepth?: boolean,
        ///     ): this;
        /// </summary>
        public Matrix4 MakePerspective(float left, float right, float top, float bottom, float near, float far, CoordinateSystem coordinateSystem, bool reversedDepth)
        {
            return JSRef!.Call<Matrix4>("makePerspective", left, right, top, bottom, near, far, coordinateSystem, reversedDepth);
        }
        /// <summary>
        /// makeOrthographic(
        ///         left: number,
        ///         right: number,
        ///         top: number,
        ///         bottom: number,
        ///         near: number,
        ///         far: number,
        ///         coordinateSystem?: CoordinateSystem,
        ///         reversedDepth?: boolean,
        ///     ): this;
        /// </summary>
        public Matrix4 MakeOrthographic(float left, float right, float top, float bottom, float near, float far, CoordinateSystem coordinateSystem, bool reversedDepth)
        {
            return JSRef!.Call<Matrix4>("makeOrthographic", left, right, top, bottom, near, far, coordinateSystem, reversedDepth);
        }
        /// <summary>
        /// makeBasis(xAxis: Vector3, yAxis: Vector3, zAxis: Vector3): this;
        /// </summary>
        public Matrix4 MakeBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis)
        {
            return JSRef!.Call<Matrix4>("makeBasis", xAxis, yAxis, zAxis);
        }
        /// <summary>
        /// lookAt(eye: Vector3, target: Vector3, up: Vector3): this;
        /// </summary>
        public Matrix4 LookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            return JSRef!.Call<Matrix4>("lookAt", eye, target, up);
        }
        /// <summary>
        /// invert(): this;
        /// </summary>
        public Matrix4 Invert()
        {
            return JSRef!.Call<Matrix4>("invert");
        }
        /// <summary>
        /// identity(): this;
        /// </summary>
        public Matrix4 Identity()
        {
            return JSRef!.Call<Matrix4>("identity");
        }
        /// <summary>
        /// getMaxScaleOnAxis(): number;
        /// </summary>
        public float GetMaxScaleOnAxis()
        {
            return JSRef!.Call<float>("getMaxScaleOnAxis");
        }
        /// <summary>
        /// fromArray(array: ArrayLike<number>, offset?: number): this;
        /// </summary>
        public Matrix4 FromArray(ArrayLikeFloat array, float offset = 0)
        {
            return JSRef!.Call<Matrix4>("fromArray", array, offset);
        }
        /// <summary>
        /// extractRotation(m: Matrix4): this;
        /// </summary>
        public Matrix4 ExtractRotation(Matrix4 m)
        {
            return JSRef!.Call<Matrix4>("extractRotation", m);
        }
        /// <summary>
        /// extractBasis(xAxis: Vector3, yAxis: Vector3, zAxis: Vector3): this;
        /// </summary>
        public Matrix4 ExtractBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis)
        {
            return JSRef!.Call<Matrix4>("extractBasis", xAxis, yAxis, zAxis);
        }
        /// <summary>
        /// equals(matrix: Matrix4): boolean;
        /// </summary>
        public bool Equals(Matrix4 matrix)
        {
            return JSRef!.Call<bool>("equals", matrix);
        }
        /// <summary>
        /// determinant(): number;
        /// </summary>
        public float Determinant()
        {
            return JSRef!.Call<float>("determinant");
        }
        /// <summary>
        /// decompose(position: Vector3, quaternion: Quaternion, scale: Vector3): this;
        /// </summary>
        public Matrix4 Decompose(Vector3 position, Quaternion quaternion, Vector3 scale)
        {
            return JSRef!.Call<Matrix4>("decompose", position, quaternion, scale);
        }
        /// <summary>
        /// copyPosition(m: Matrix4): this;
        /// </summary>
        public Matrix4 CopyPosition(Matrix4 m)
        {
            return JSRef!.Call<Matrix4>("copyPosition", m);
        }
        /// <summary>
        /// copy(m: Matrix4): this;
        /// </summary>
        public Matrix4 Copy(Matrix4 m)
        {
            return JSRef!.Call<Matrix4>("copy", m);
        }
        /// <summary>
        /// compose(position: Vector3, quaternion: Quaternion, scale: Vector3): this;
        /// </summary>
        public Matrix4 Compose(Vector3 position, Quaternion quaternion, Vector3 scale)
        {
            return JSRef!.Call<Matrix4>("compose", position, quaternion, scale);
        }
        /// <summary>
        /// clone(): Matrix4;
        /// </summary>
        public Matrix4 Clone()
        {
            return JSRef!.Call<Matrix4>("clone");
        }
        #endregion
    }
}
