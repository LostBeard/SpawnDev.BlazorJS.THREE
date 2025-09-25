
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class QuadraticBezierCurve3 : Curve<Vector3>
    {
        #region Constructors
        /// <inheritdoc/>
        public QuadraticBezierCurve3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(v0?: Vector3, v1?: Vector3, v2?: Vector3);
        /// </summary>
        public QuadraticBezierCurve3(Vector3 v0, Vector3 v1, Vector3 v2) : base(JS.New("THREE.QuadraticBezierCurve3", v0, v1, v2)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isQuadraticBezierCurve3 = true;
        /// </summary>
        public bool IsQuadraticBezierCurve3 { get => JSRef!.Get<bool>("isQuadraticBezierCurve3"); }
        /// <summary>
        /// override readonly type: string | "QuadraticBezierCurve3";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// v0: Vector3;
        /// </summary>
        public Vector3 V0 { get => JSRef!.Get<Vector3>("v0"); set => JSRef!.Set("v0", value); }
        /// <summary>
        /// v1: Vector3;
        /// </summary>
        public Vector3 V1 { get => JSRef!.Get<Vector3>("v1"); set => JSRef!.Set("v1", value); }
        /// <summary>
        /// v2: Vector3;
        /// </summary>
        public Vector3 V2 { get => JSRef!.Get<Vector3>("v2"); set => JSRef!.Set("v2", value); }
        #endregion

        #region Methods

        #endregion
    }
}
