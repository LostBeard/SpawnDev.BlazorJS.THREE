
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShapePath : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public ShapePath(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public ShapePath() : base(JS.New("THREE.ShapePath")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// color: Color;
        /// </summary>
        public Color Color { get => JSRef!.Get<Color>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// readonly currentPath: Path | null;
        /// </summary>
        public Path CurrentPath { get => JSRef!.Get<Path>("currentPath"); }
        /// <summary>
        /// subPaths: Path[];
        /// </summary>
        public Array<Path> SubPaths { get => JSRef!.Get<Array<Path>>("subPaths"); set => JSRef!.Set("subPaths", value); }
        /// <summary>
        /// readonly type: "ShapePath";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// toShapes(isCCW: boolean): Shape[];
        /// </summary>
        public Array<Shape> ToShapes(bool isCCW)
        {
            return JSRef!.Call<Array<Shape>>("toShapes", isCCW);
        }
        /// <summary>
        /// splineThru(pts: Vector2[]): this;
        /// </summary>
        public ShapePath SplineThru(Array<Vector2> pts)
        {
            return JSRef!.Call<ShapePath>("splineThru", pts);
        }
        /// <summary>
        /// quadraticCurveTo(aCPx: number, aCPy: number, aX: number, aY: number): this;
        /// </summary>
        public ShapePath QuadraticCurveTo(float aCPx, float aCPy, float aX, float aY)
        {
            return JSRef!.Call<ShapePath>("quadraticCurveTo", aCPx, aCPy, aX, aY);
        }
        /// <summary>
        /// moveTo(x: number, y: number): this;
        /// </summary>
        public ShapePath MoveTo(float x, float y)
        {
            return JSRef!.Call<ShapePath>("moveTo", x, y);
        }
        /// <summary>
        /// lineTo(x: number, y: number): this;
        /// </summary>
        public ShapePath LineTo(float x, float y)
        {
            return JSRef!.Call<ShapePath>("lineTo", x, y);
        }
        /// <summary>
        /// bezierCurveTo(aCP1x: number, aCP1y: number, aCP2x: number, aCP2y: number, aX: number, aY: number): this;
        /// </summary>
        public ShapePath BezierCurveTo(float aCP1x, float aCP1y, float aCP2x, float aCP2y, float aX, float aY)
        {
            return JSRef!.Call<ShapePath>("bezierCurveTo", aCP1x, aCP1y, aCP2x, aCP2y, aX, aY);
        }
        #endregion
    }
}
