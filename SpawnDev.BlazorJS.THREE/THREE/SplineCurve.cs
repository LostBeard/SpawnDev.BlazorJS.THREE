
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SplineCurve : Curve<Vector2>
    {
        #region Constructors
        /// <inheritdoc/>
        public SplineCurve(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(points?: Vector2[]);
        /// </summary>
        public SplineCurve(Array<Vector2> points) : base(JS.New("THREE.SplineCurve", points)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isSplineCurve = true;
        /// </summary>
        public bool IsSplineCurve { get => JSRef!.Get<bool>("isSplineCurve"); }
        /// <summary>
        /// points: Vector2[];
        /// </summary>
        public Array<Vector2> Points { get => JSRef!.Get<Array<Vector2>>("points"); set => JSRef!.Set("points", value); }
        /// <summary>
        /// override readonly type: string | "SplineCurve";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
