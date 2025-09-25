
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class QuadraticBezierCurve : Curve<Vector2>
    {
        #region Constructors
        /// <inheritdoc/>
        public QuadraticBezierCurve(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(v0?: Vector2, v1?: Vector2, v2?: Vector2);
        /// </summary>
        public QuadraticBezierCurve(Vector2 v0, Vector2 v1, Vector2 v2) : base(JS.New("THREE.QuadraticBezierCurve", v0, v1, v2)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isQuadraticBezierCurve = true;
        /// </summary>
        public bool IsQuadraticBezierCurve { get => JSRef!.Get<bool>("isQuadraticBezierCurve"); }
        /// <summary>
        /// override readonly type: string | "QuadraticBezierCurve";
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
        #endregion

        #region Methods

        #endregion
    }
}
