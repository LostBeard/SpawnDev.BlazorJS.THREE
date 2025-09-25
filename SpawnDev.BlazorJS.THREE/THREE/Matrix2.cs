
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix2 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix2(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Matrix2() : base(JS.New("THREE.Matrix2")) { }
        
        
        /// <summary>
        /// constructor(n11: number, n12: number, n21: number, n22: number);
        /// </summary>
        public Matrix2(float n11, float n12, float n21, float n22) : base(JS.New("THREE.Matrix2", n11, n12, n21, n22)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// elements: Matrix2Tuple;
        /// </summary>
        public Matrix2Tuple Elements { get => JSRef!.Get<Matrix2Tuple>("elements"); set => JSRef!.Set("elements", value); }
        /// <summary>
        /// readonly isMatrix2: true;
        /// </summary>
        public bool IsMatrix2 { get => JSRef!.Get<bool>("isMatrix2"); }
        #endregion

        #region Methods
        /// <summary>
        /// set(n11: number, n12: number, n21: number, n22: number): this;
        /// </summary>
        public Matrix2 Set(float n11, float n12, float n21, float n22)
        {
            return JSRef!.Call<Matrix2>("set", n11, n12, n21, n22);
        }
        /// <summary>
        /// identity(): this;
        /// </summary>
        public Matrix2 Identity()
        {
            return JSRef!.Call<Matrix2>("identity");
        }
        /// <summary>
        /// fromArray(array: ArrayLike<number>, offset?: number): this;
        /// </summary>
        public Matrix2 FromArray(ArrayLikeFloat array, float offset)
        {
            return JSRef!.Call<Matrix2>("fromArray", array, offset);
        }
        #endregion
    }
}
