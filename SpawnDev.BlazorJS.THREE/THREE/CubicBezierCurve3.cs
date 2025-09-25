
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CubicBezierCurve3 : Curve<Vector3>
    {
        #region Constructors
        /// <inheritdoc/>
        public CubicBezierCurve3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(v0?: Vector3, v1?: Vector3, v2?: Vector3, v3?: Vector3);
        /// </summary>
        public CubicBezierCurve3(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3) : base(JS.New("THREE.CubicBezierCurve3", v0, v1, v2, v3)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isCubicBezierCurve3 = true;
        /// </summary>
        public bool IsCubicBezierCurve3 { get => JSRef!.Get<bool>("isCubicBezierCurve3"); }
        /// <summary>
        /// override readonly type: string | "CubicBezierCurve3";
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
        /// <summary>
        /// v3: Vector3;
        /// </summary>
        public Vector3 V3 { get => JSRef!.Get<Vector3>("v3"); set => JSRef!.Set("v3", value); }
        #endregion

        #region Methods

        #endregion
    }
}
