
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CurvePath<TVector> : Curve<TVector>
    {
        #region Constructors
        /// <inheritdoc/>
        public CurvePath(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public CurvePath() : base(JS.New("THREE.CurvePath")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// autoClose: boolean;
        /// </summary>
        public bool AutoClose { get => JSRef!.Get<bool>("autoClose"); set => JSRef!.Set("autoClose", value); }
        /// <summary>
        /// curves: Array<Curve<TVector>>;
        /// </summary>
        public Array<Curve<TVector>> Curves { get => JSRef!.Get<Array<Curve<TVector>>>("curves"); set => JSRef!.Set("curves", value); }
        /// <summary>
        /// override readonly type: string | "CurvePath";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(): CurvePathJSON;
        /// </summary>
        public CurvePathJSON ToJSON()
        {
            return JSRef!.Call<CurvePathJSON>("toJSON");
        }
        /// <summary>
        /// override getSpacedPoints(divisions?: number): TVector[];
        /// </summary>
        public Array<TVector> GetSpacedPoints(float divisions)
        {
            return JSRef!.Call<Array<TVector>>("getSpacedPoints", divisions);
        }
        /// <summary>
        /// override getPoints(divisions?: number): TVector[];
        /// </summary>
        public Array<TVector> GetPoints(float divisions)
        {
            return JSRef!.Call<Array<TVector>>("getPoints", divisions);
        }
        /// <summary>
        /// getPoint(t: number, optionalTarget?: TVector): TVector;
        /// </summary>
        public TVector GetPoint(float t, TVector optionalTarget)
        {
            return JSRef!.Call<TVector>("getPoint", t, optionalTarget);
        }
        /// <summary>
        /// getCurveLengths(): number[];
        /// </summary>
        public Array<float> GetCurveLengths()
        {
            return JSRef!.Call<Array<float>>("getCurveLengths");
        }
        /// <summary>
        /// fromJSON(json: CurvePathJSON): this;
        /// </summary>
        public CurvePath<TVector> FromJSON(CurvePathJSON json)
        {
            return JSRef!.Call<CurvePath<TVector>>("fromJSON", json);
        }
        /// <summary>
        /// closePath(): this;
        /// </summary>
        public CurvePath<TVector> ClosePath()
        {
            return JSRef!.Call<CurvePath<TVector>>("closePath");
        }
        /// <summary>
        /// add(curve: Curve<TVector>): void;
        /// </summary>
        public void Add(Curve<TVector> curve)
        {
            JSRef!.CallVoid("add", curve);
        }
        #endregion
    }
}
