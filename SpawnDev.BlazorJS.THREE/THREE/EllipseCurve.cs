
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class EllipseCurve : Curve<Vector2>
    {
        #region Constructors
        /// <inheritdoc/>
        public EllipseCurve(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         aX?: number,
        ///         aY?: number,
        ///         xRadius?: number,
        ///         yRadius?: number,
        ///         aStartAngle?: number,
        ///         aEndAngle?: number,
        ///         aClockwise?: boolean,
        ///         aRotation?: number,
        ///     );
        /// </summary>
        public EllipseCurve(float aX, float aY, float xRadius, float yRadius, float aStartAngle, float aEndAngle, bool aClockwise, float aRotation) : base(JS.New("THREE.EllipseCurve", aX, aY, xRadius, yRadius, aStartAngle, aEndAngle, aClockwise, aRotation)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// aClockwise: boolean;
        /// </summary>
        public bool AClockwise { get => JSRef!.Get<bool>("aClockwise"); set => JSRef!.Set("aClockwise", value); }
        /// <summary>
        /// aEndAngle: number;
        /// </summary>
        public float AEndAngle { get => JSRef!.Get<float>("aEndAngle"); set => JSRef!.Set("aEndAngle", value); }
        /// <summary>
        /// aRotation: number;
        /// </summary>
        public float ARotation { get => JSRef!.Get<float>("aRotation"); set => JSRef!.Set("aRotation", value); }
        /// <summary>
        /// aStartAngle: number;
        /// </summary>
        public float AStartAngle { get => JSRef!.Get<float>("aStartAngle"); set => JSRef!.Set("aStartAngle", value); }
        /// <summary>
        /// aX: number;
        /// </summary>
        public float AX { get => JSRef!.Get<float>("aX"); set => JSRef!.Set("aX", value); }
        /// <summary>
        /// aY: number;
        /// </summary>
        public float AY { get => JSRef!.Get<float>("aY"); set => JSRef!.Set("aY", value); }
        /// <summary>
        /// readonly isEllipseCurve = true;
        /// </summary>
        public bool IsEllipseCurve { get => JSRef!.Get<bool>("isEllipseCurve"); }
        /// <summary>
        /// override readonly type: string | "EllipseCurve";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// xRadius: number;
        /// </summary>
        public float XRadius { get => JSRef!.Get<float>("xRadius"); set => JSRef!.Set("xRadius", value); }
        /// <summary>
        /// yRadius: number;
        /// </summary>
        public float YRadius { get => JSRef!.Get<float>("yRadius"); set => JSRef!.Set("yRadius", value); }
        #endregion

        #region Methods

        #endregion
    }
}
