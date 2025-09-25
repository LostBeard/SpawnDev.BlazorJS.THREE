
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix3 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Matrix3() : base(JS.New("THREE.Matrix3")) { }
        
        
        /// <summary>
        /// constructor(
        ///         n11: number,
        ///         n12: number,
        ///         n13: number,
        ///         n21: number,
        ///         n22: number,
        ///         n23: number,
        ///         n31: number,
        ///         n32: number,
        ///         n33: number,
        ///     );
        /// </summary>
        public Matrix3(float n11, float n12, float n13, float n21, float n22, float n23, float n31, float n32, float n33) : base(JS.New("THREE.Matrix3", n11, n12, n13, n21, n22, n23, n31, n32, n33)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// elements: Matrix3Tuple;
        /// </summary>
        public Matrix3Tuple Elements { get => JSRef!.Get<Matrix3Tuple>("elements"); set => JSRef!.Set("elements", value); }
        /// <summary>
        /// readonly isMatrix3: true;
        /// </summary>
        public bool IsMatrix3 { get => JSRef!.Get<bool>("isMatrix3"); }
        #endregion

        #region Methods
        /// <summary>
        /// transposeIntoArray(r: number[]): this;
        /// </summary>
        public Matrix3 TransposeIntoArray(Array<float> r)
        {
            return JSRef!.Call<Matrix3>("transposeIntoArray", r);
        }
        /// <summary>
        /// transpose(): this;
        /// </summary>
        public Matrix3 Transpose()
        {
            return JSRef!.Call<Matrix3>("transpose");
        }
        /// <summary>
        /// translate(tx: number, ty: number): this;
        /// </summary>
        public Matrix3 Translate(float tx, float ty)
        {
            return JSRef!.Call<Matrix3>("translate", tx, ty);
        }
        /// <summary>
        /// toArray(): Matrix3Tuple;
        /// </summary>
        public Matrix3Tuple ToArray()
        {
            return JSRef!.Call<Matrix3Tuple>("toArray");
        }
        /// <summary>
        /// toArray<TArray extends ArrayLike<number>>(array: TArray, offset?: number): TArray;
        /// </summary>
        public TArray ToArray<TArray>(TArray array, float offset)
        {
            return JSRef!.Call<TArray>("toArray", array, offset);
        }
        /// <summary>
        /// setUvTransform(tx: number, ty: number, sx: number, sy: number, rotation: number, cx: number, cy: number): this;
        /// </summary>
        public Matrix3 SetUvTransform(float tx, float ty, float sx, float sy, float rotation, float cx, float cy)
        {
            return JSRef!.Call<Matrix3>("setUvTransform", tx, ty, sx, sy, rotation, cx, cy);
        }
        /// <summary>
        /// setFromMatrix4(m: Matrix4): Matrix3;
        /// </summary>
        public Matrix3 SetFromMatrix4(Matrix4 m)
        {
            return JSRef!.Call<Matrix3>("setFromMatrix4", m);
        }
        /// <summary>
        /// set(
        ///         n11: number,
        ///         n12: number,
        ///         n13: number,
        ///         n21: number,
        ///         n22: number,
        ///         n23: number,
        ///         n31: number,
        ///         n32: number,
        ///         n33: number,
        ///     ): Matrix3;
        /// </summary>
        public Matrix3 Set(float n11, float n12, float n13, float n21, float n22, float n23, float n31, float n32, float n33)
        {
            return JSRef!.Call<Matrix3>("set", n11, n12, n13, n21, n22, n23, n31, n32, n33);
        }
        /// <summary>
        /// scale(sx: number, sy: number): this;
        /// </summary>
        public Matrix3 Scale(float sx, float sy)
        {
            return JSRef!.Call<Matrix3>("scale", sx, sy);
        }
        /// <summary>
        /// rotate(theta: number): this;
        /// </summary>
        public Matrix3 Rotate(float theta)
        {
            return JSRef!.Call<Matrix3>("rotate", theta);
        }
        /// <summary>
        /// premultiply(m: Matrix3): this;
        /// </summary>
        public Matrix3 Premultiply(Matrix3 m)
        {
            return JSRef!.Call<Matrix3>("premultiply", m);
        }
        /// <summary>
        /// multiplyScalar(s: number): this;
        /// </summary>
        public Matrix3 MultiplyScalar(float s)
        {
            return JSRef!.Call<Matrix3>("multiplyScalar", s);
        }
        /// <summary>
        /// multiplyMatrices(a: Matrix3, b: Matrix3): this;
        /// </summary>
        public Matrix3 MultiplyMatrices(Matrix3 a, Matrix3 b)
        {
            return JSRef!.Call<Matrix3>("multiplyMatrices", a, b);
        }
        /// <summary>
        /// multiply(m: Matrix3): this;
        /// </summary>
        public Matrix3 Multiply(Matrix3 m)
        {
            return JSRef!.Call<Matrix3>("multiply", m);
        }
        /// <summary>
        /// makeTranslation(v: Vector2): this;
        /// </summary>
        public Matrix3 MakeTranslation(Vector2 v)
        {
            return JSRef!.Call<Matrix3>("makeTranslation", v);
        }
        /// <summary>
        /// makeTranslation(x: number, y: number): this;
        /// </summary>
        public Matrix3 MakeTranslation(float x, float y)
        {
            return JSRef!.Call<Matrix3>("makeTranslation", x, y);
        }
        /// <summary>
        /// makeScale(x: number, y: number): this;
        /// </summary>
        public Matrix3 MakeScale(float x, float y)
        {
            return JSRef!.Call<Matrix3>("makeScale", x, y);
        }
        /// <summary>
        /// makeRotation(theta: number): this;
        /// </summary>
        public Matrix3 MakeRotation(float theta)
        {
            return JSRef!.Call<Matrix3>("makeRotation", theta);
        }
        /// <summary>
        /// invert(): this;
        /// </summary>
        public Matrix3 Invert()
        {
            return JSRef!.Call<Matrix3>("invert");
        }
        /// <summary>
        /// identity(): this;
        /// </summary>
        public Matrix3 Identity()
        {
            return JSRef!.Call<Matrix3>("identity");
        }
        /// <summary>
        /// getNormalMatrix(matrix4: Matrix4): this;
        /// </summary>
        public Matrix3 GetNormalMatrix(Matrix4 matrix4)
        {
            return JSRef!.Call<Matrix3>("getNormalMatrix", matrix4);
        }
        /// <summary>
        /// fromArray(array: ArrayLike<number>, offset?: number): this;
        /// </summary>
        public Matrix3 FromArray(ArrayLikeFloat array, float offset)
        {
            return JSRef!.Call<Matrix3>("fromArray", array, offset);
        }
        /// <summary>
        /// extractBasis(xAxis: Vector3, yAxis: Vector3, zAxis: Vector3): this;
        /// </summary>
        public Matrix3 ExtractBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis)
        {
            return JSRef!.Call<Matrix3>("extractBasis", xAxis, yAxis, zAxis);
        }
        /// <summary>
        /// equals(matrix: Matrix3): boolean;
        /// </summary>
        public bool Equals(Matrix3 matrix)
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
        /// copy(m: Matrix3): this;
        /// </summary>
        public Matrix3 Copy(Matrix3 m)
        {
            return JSRef!.Call<Matrix3>("copy", m);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Matrix3 Clone()
        {
            return JSRef!.Call<Matrix3>("clone");
        }
        #endregion
    }
}
