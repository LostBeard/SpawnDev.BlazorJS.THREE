
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SphericalHarmonics3 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public SphericalHarmonics3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public SphericalHarmonics3() : base(JS.New("THREE.SphericalHarmonics3")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// coefficients: Vector3[];
        /// </summary>
        public Array<Vector3> Coefficients { get => JSRef!.Get<Array<Vector3>>("coefficients"); set => JSRef!.Set("coefficients", value); }
        /// <summary>
        /// readonly isSphericalHarmonics3: true;
        /// </summary>
        public bool IsSphericalHarmonics3 { get => JSRef!.Get<bool>("isSphericalHarmonics3"); }
        #endregion

        #region Methods
        /// <summary>
        /// zero(): SphericalHarmonics3;
        /// </summary>
        public SphericalHarmonics3 Zero()
        {
            return JSRef!.Call<SphericalHarmonics3>("zero");
        }
        /// <summary>
        /// toArray(array?: number[], offset?: number): number[];
        /// </summary>
        public Array<float> ToArray(Array<float> array, float offset)
        {
            return JSRef!.Call<Array<float>>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(array: ArrayLike<number>, offset?: number): ArrayLike<number>;
        /// </summary>
        public ArrayLikeFloat ToArray(ArrayLikeFloat array, float offset)
        {
            return JSRef!.Call<ArrayLikeFloat>("toArray", array, offset);
        }
        /// <summary>
        /// set(coefficients: Vector3[]): SphericalHarmonics3;
        /// </summary>
        public SphericalHarmonics3 Set(Array<Vector3> coefficients)
        {
            return JSRef!.Call<SphericalHarmonics3>("set", coefficients);
        }
        /// <summary>
        /// scale(s: number): SphericalHarmonics3;
        /// </summary>
        public SphericalHarmonics3 Scale(float s)
        {
            return JSRef!.Call<SphericalHarmonics3>("scale", s);
        }
        /// <summary>
        /// lerp(sh: SphericalHarmonics3, alpha: number): SphericalHarmonics3;
        /// </summary>
        public SphericalHarmonics3 Lerp(SphericalHarmonics3 sh, float alpha)
        {
            return JSRef!.Call<SphericalHarmonics3>("lerp", sh, alpha);
        }
        /// <summary>
        /// getIrradianceAt(normal: Vector3, target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetIrradianceAt(Vector3 normal, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getIrradianceAt", normal, target);
        }
        /// <summary>
        /// static getBasisAt(normal: Vector3, shBasis: number[]): void;
        /// </summary>
        public void GetBasisAt(Vector3 normal, Array<float> shBasis)
        {
            JSRef!.CallVoid("getBasisAt", normal, shBasis);
        }
        /// <summary>
        /// getAt(normal: Vector3, target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetAt(Vector3 normal, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getAt", normal, target);
        }
        /// <summary>
        /// fromArray(array: number[] | ArrayLike<number>, offset?: number): this;
        /// </summary>
        public SphericalHarmonics3 FromArray(Union<Array<float>, ArrayLikeFloat> array, float offset)
        {
            return JSRef!.Call<SphericalHarmonics3>("fromArray", array, offset);
        }
        /// <summary>
        /// equals(sh: SphericalHarmonics3): boolean;
        /// </summary>
        public bool Equals(SphericalHarmonics3 sh)
        {
            return JSRef!.Call<bool>("equals", sh);
        }
        /// <summary>
        /// copy(sh: SphericalHarmonics3): SphericalHarmonics3;
        /// </summary>
        public SphericalHarmonics3 Copy(SphericalHarmonics3 sh)
        {
            return JSRef!.Call<SphericalHarmonics3>("copy", sh);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public SphericalHarmonics3 Clone()
        {
            return JSRef!.Call<SphericalHarmonics3>("clone");
        }
        /// <summary>
        /// addScaledSH(sh: SphericalHarmonics3, s: number): SphericalHarmonics3;
        /// </summary>
        public SphericalHarmonics3 AddScaledSH(SphericalHarmonics3 sh, float s)
        {
            return JSRef!.Call<SphericalHarmonics3>("addScaledSH", sh, s);
        }
        /// <summary>
        /// add(sh: SphericalHarmonics3): SphericalHarmonics3;
        /// </summary>
        public SphericalHarmonics3 Add(SphericalHarmonics3 sh)
        {
            return JSRef!.Call<SphericalHarmonics3>("add", sh);
        }
        #endregion
    }
}
