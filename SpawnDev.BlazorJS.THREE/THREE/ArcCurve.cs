
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ArcCurve : EllipseCurve
    {
        #region Constructors
        /// <inheritdoc/>
        public ArcCurve(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         aX?: number,
        ///         aY?: number,
        ///         aRadius?: number,
        ///         aStartAngle?: number,
        ///         aEndAngle?: number,
        ///         aClockwise?: boolean,
        ///     );
        /// </summary>
        public ArcCurve(float aX, float aY, float aRadius, float aStartAngle, float aEndAngle, bool aClockwise) : base(JS.New("THREE.ArcCurve", aX, aY, aRadius, aStartAngle, aEndAngle, aClockwise)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isArcCurve = true;
        /// </summary>
        public bool IsArcCurve { get => JSRef!.Get<bool>("isArcCurve"); }
        /// <summary>
        /// override readonly type: string | "ArcCurve";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
