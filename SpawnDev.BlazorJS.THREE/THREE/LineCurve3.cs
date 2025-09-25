
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LineCurve3 : Curve<Vector3>
    {
        #region Constructors
        /// <inheritdoc/>
        public LineCurve3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(v1?: Vector3, v2?: Vector3);
        /// </summary>
        public LineCurve3(Vector3 v1, Vector3 v2) : base(JS.New("THREE.LineCurve3", v1, v2)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLineCurve3 = true;
        /// </summary>
        public bool IsLineCurve3 { get => JSRef!.Get<bool>("isLineCurve3"); }
        /// <summary>
        /// override readonly type: string | "LineCurve3";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
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
