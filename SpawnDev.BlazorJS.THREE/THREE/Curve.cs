
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Curve<TVector> : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Curve(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// protected constructor();
        /// </summary>
        public Curve() : base(JS.New("THREE.Curve")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// arcLengthDivisions: number;
        /// </summary>
        public float ArcLengthDivisions { get => JSRef!.Get<float>("arcLengthDivisions"); set => JSRef!.Set("arcLengthDivisions", value); }
        /// <summary>
        /// readonly type: string | "Curve";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// updateArcLengths(): void;
        /// </summary>
        public void UpdateArcLengths()
        {
            JSRef!.CallVoid("updateArcLengths");
        }
        /// <summary>
        /// toJSON(): CurveJSON;
        /// </summary>
        public CurveJSON ToJSON()
        {
            return JSRef!.Call<CurveJSON>("toJSON");
        }
        /// <summary>
        /// getUtoTmapping(u: number, distance: number): number;
        /// </summary>
        public float GetUtoTmapping(float u, float distance)
        {
            return JSRef!.Call<float>("getUtoTmapping", u, distance);
        }
        /// <summary>
        /// getTangentAt(u: number, optionalTarget?: TVector): TVector;
        /// </summary>
        public TVector GetTangentAt(float u, TVector optionalTarget)
        {
            return JSRef!.Call<TVector>("getTangentAt", u, optionalTarget);
        }
        /// <summary>
        /// getTangent(t: number, optionalTarget?: TVector): TVector;
        /// </summary>
        public TVector GetTangent(float t, TVector optionalTarget)
        {
            return JSRef!.Call<TVector>("getTangent", t, optionalTarget);
        }
        /// <summary>
        /// getSpacedPoints(divisions?: number): TVector[];
        /// </summary>
        public Array<TVector> GetSpacedPoints(float divisions)
        {
            return JSRef!.Call<Array<TVector>>("getSpacedPoints", divisions);
        }
        /// <summary>
        /// getPoints(divisions?: number): TVector[];
        /// </summary>
        public Array<TVector> GetPoints(float divisions)
        {
            return JSRef!.Call<Array<TVector>>("getPoints", divisions);
        }
        /// <summary>
        /// getPointAt(u: number, optionalTarget?: TVector): TVector;
        /// </summary>
        public TVector GetPointAt(float u, TVector optionalTarget)
        {
            return JSRef!.Call<TVector>("getPointAt", u, optionalTarget);
        }
        /// <summary>
        /// getPoint(t: number, optionalTarget?: TVector): TVector;
        /// </summary>
        public TVector GetPoint(float t, TVector optionalTarget)
        {
            return JSRef!.Call<TVector>("getPoint", t, optionalTarget);
        }
        /// <summary>
        /// getLengths(divisions?: number): number[];
        /// </summary>
        public Array<float> GetLengths(float divisions)
        {
            return JSRef!.Call<Array<float>>("getLengths", divisions);
        }
        /// <summary>
        /// getLength(): number;
        /// </summary>
        public float GetLength()
        {
            return JSRef!.Call<float>("getLength");
        }
        /// <summary>
        /// fromJSON(json: CurveJSON): this;
        /// </summary>
        public Curve<TVector> FromJSON(CurveJSON json)
        {
            return JSRef!.Call<Curve<TVector>>("fromJSON", json);
        }
        /// <summary>
        /// copy(source: Curve<TVector>): this;
        /// </summary>
        public Curve<TVector> Copy(Curve<TVector> source)
        {
            return JSRef!.Call<Curve<TVector>>("copy", source);
        }
        /// <summary>
        /// computeFrenetFrames(
        ///         segments: number,
        ///         closed?: boolean,
        ///     ): {
        ///         tangents: Vector3[];
        ///         normals: Vector3[];
        ///         binormals: Vector3[];
        ///     };
        /// </summary>
        public object ComputeFrenetFrames(float segments, bool closed)
        {
            return JSRef!.Call<object>("computeFrenetFrames", segments, closed);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Curve<TVector> Clone()
        {
            return JSRef!.Call<Curve<TVector>>("clone");
        }
        #endregion
    }
}
