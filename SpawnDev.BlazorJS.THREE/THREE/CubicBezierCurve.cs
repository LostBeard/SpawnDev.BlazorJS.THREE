
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CubicBezierCurve : Curve<Vector2>
    {
        #region Constructors
        /// <inheritdoc/>
        public CubicBezierCurve(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(v0?: Vector2, v1?: Vector2, v2?: Vector2, v3?: Vector2);
        /// </summary>
        public CubicBezierCurve(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3) : base(JS.New("THREE.CubicBezierCurve", v0, v1, v2, v3)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isCubicBezierCurve = true;
        /// </summary>
        public bool IsCubicBezierCurve { get => JSRef!.Get<bool>("isCubicBezierCurve"); }
        /// <summary>
        /// override readonly type: string | "CubicBezierCurve";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// v0: Vector2;
        /// </summary>
        public Vector2 V0 { get => JSRef!.Get<Vector2>("v0"); set => JSRef!.Set("v0", value); }
        /// <summary>
        /// v1: Vector2;
        /// </summary>
        public Vector2 V1 { get => JSRef!.Get<Vector2>("v1"); set => JSRef!.Set("v1", value); }
        /// <summary>
        /// v2: Vector2;
        /// </summary>
        public Vector2 V2 { get => JSRef!.Get<Vector2>("v2"); set => JSRef!.Set("v2", value); }
        /// <summary>
        /// v3: Vector2;
        /// </summary>
        public Vector2 V3 { get => JSRef!.Get<Vector2>("v3"); set => JSRef!.Set("v3", value); }
        #endregion

        #region Methods

        #endregion
    }
}
