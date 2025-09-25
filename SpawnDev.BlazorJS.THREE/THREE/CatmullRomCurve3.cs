
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CatmullRomCurve3 : Curve<Vector3>
    {
        #region Constructors
        /// <inheritdoc/>
        public CatmullRomCurve3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(points?: Vector3[], closed?: boolean, curveType?: CurveType, tension?: number);
        /// </summary>
        public CatmullRomCurve3(Array<Vector3> points, bool closed, CurveType curveType, float tension) : base(JS.New("THREE.CatmullRomCurve3", points, closed, curveType, tension)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// closed: boolean;
        /// </summary>
        public bool Closed { get => JSRef!.Get<bool>("closed"); set => JSRef!.Set("closed", value); }
        /// <summary>
        /// curveType: CurveType;
        /// </summary>
        public CurveType CurveType { get => JSRef!.Get<CurveType>("curveType"); set => JSRef!.Set("curveType", value); }
        /// <summary>
        /// readonly isCatmullRomCurve3 = true;
        /// </summary>
        public bool IsCatmullRomCurve3 { get => JSRef!.Get<bool>("isCatmullRomCurve3"); }
        /// <summary>
        /// points: Vector3[];
        /// </summary>
        public Array<Vector3> Points { get => JSRef!.Get<Array<Vector3>>("points"); set => JSRef!.Set("points", value); }
        /// <summary>
        /// tension: number;
        /// </summary>
        public float Tension { get => JSRef!.Get<float>("tension"); set => JSRef!.Set("tension", value); }
        /// <summary>
        /// override readonly type: string | "CatmullRomCurve3";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
