
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Path : CurvePath<Vector2>
    {
        #region Constructors
        /// <inheritdoc/>
        public Path(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(points?: Vector2[]);
        /// </summary>
        public Path(Array<Vector2> points) : base(JS.New("THREE.Path", points)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// currentPoint: Vector2;
        /// </summary>
        public Vector2 CurrentPoint { get => JSRef!.Get<Vector2>("currentPoint"); set => JSRef!.Set("currentPoint", value); }
        /// <summary>
        /// override readonly type: string | "Path";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(): PathJSON;
        /// </summary>
        public PathJSON ToJSON()
        {
            return JSRef!.Call<PathJSON>("toJSON");
        }
        /// <summary>
        /// splineThru(pts: Vector2[]): this;
        /// </summary>
        public Path SplineThru(Array<Vector2> pts)
        {
            return JSRef!.Call<Path>("splineThru", pts);
        }
        /// <summary>
        /// setFromPoints(vectors: Vector2[]): this;
        /// </summary>
        public Path SetFromPoints(Array<Vector2> vectors)
        {
            return JSRef!.Call<Path>("setFromPoints", vectors);
        }
        /// <summary>
        /// quadraticCurveTo(aCPx: number, aCPy: number, aX: number, aY: number): this;
        /// </summary>
        public Path QuadraticCurveTo(float aCPx, float aCPy, float aX, float aY)
        {
            return JSRef!.Call<Path>("quadraticCurveTo", aCPx, aCPy, aX, aY);
        }
        /// <summary>
        /// moveTo(x: number, y: number): this;
        /// </summary>
        public Path MoveTo(float x, float y)
        {
            return JSRef!.Call<Path>("moveTo", x, y);
        }
        /// <summary>
        /// lineTo(x: number, y: number): this;
        /// </summary>
        public Path LineTo(float x, float y)
        {
            return JSRef!.Call<Path>("lineTo", x, y);
        }
        /// <summary>
        /// fromJSON(json: PathJSON): this;
        /// </summary>
        public Path FromJSON(PathJSON json)
        {
            return JSRef!.Call<Path>("fromJSON", json);
        }
        /// <summary>
        /// ellipse(
        ///         aX: number,
        ///         aY: number,
        ///         xRadius: number,
        ///         yRadius: number,
        ///         aStartAngle: number,
        ///         aEndAngle: number,
        ///         aClockwise?: boolean,
        ///         aRotation?: number,
        ///     ): this;
        /// </summary>
        public Path Ellipse(float aX, float aY, float xRadius, float yRadius, float aStartAngle, float aEndAngle, bool aClockwise, float aRotation)
        {
            return JSRef!.Call<Path>("ellipse", aX, aY, xRadius, yRadius, aStartAngle, aEndAngle, aClockwise, aRotation);
        }
        /// <summary>
        /// bezierCurveTo(aCP1x: number, aCP1y: number, aCP2x: number, aCP2y: number, aX: number, aY: number): this;
        /// </summary>
        public Path BezierCurveTo(float aCP1x, float aCP1y, float aCP2x, float aCP2y, float aX, float aY)
        {
            return JSRef!.Call<Path>("bezierCurveTo", aCP1x, aCP1y, aCP2x, aCP2y, aX, aY);
        }
        /// <summary>
        /// arc(aX: number, aY: number, aRadius: number, aStartAngle: number, aEndAngle: number, aClockwise?: boolean): this;
        /// </summary>
        public Path Arc(float aX, float aY, float aRadius, float aStartAngle, float aEndAngle, bool aClockwise)
        {
            return JSRef!.Call<Path>("arc", aX, aY, aRadius, aStartAngle, aEndAngle, aClockwise);
        }
        /// <summary>
        /// absellipse(
        ///         aX: number,
        ///         aY: number,
        ///         xRadius: number,
        ///         yRadius: number,
        ///         aStartAngle: number,
        ///         aEndAngle: number,
        ///         aClockwise?: boolean,
        ///         aRotation?: number,
        ///     ): this;
        /// </summary>
        public Path Absellipse(float aX, float aY, float xRadius, float yRadius, float aStartAngle, float aEndAngle, bool aClockwise, float aRotation)
        {
            return JSRef!.Call<Path>("absellipse", aX, aY, xRadius, yRadius, aStartAngle, aEndAngle, aClockwise, aRotation);
        }
        /// <summary>
        /// absarc(aX: number, aY: number, aRadius: number, aStartAngle: number, aEndAngle: number, aClockwise?: boolean): this;
        /// </summary>
        public Path Absarc(float aX, float aY, float aRadius, float aStartAngle, float aEndAngle, bool aClockwise)
        {
            return JSRef!.Call<Path>("absarc", aX, aY, aRadius, aStartAngle, aEndAngle, aClockwise);
        }
        #endregion
    }
}
