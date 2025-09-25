
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LineCurve : Curve<Vector2>
    {
        #region Constructors
        /// <inheritdoc/>
        public LineCurve(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(v1?: Vector2, v2?: Vector2);
        /// </summary>
        public LineCurve(Vector2 v1, Vector2 v2) : base(JS.New("THREE.LineCurve", v1, v2)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLineCurve = true;
        /// </summary>
        public bool IsLineCurve { get => JSRef!.Get<bool>("isLineCurve"); }
        /// <summary>
        /// override readonly type: string | "LineCurve";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
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
