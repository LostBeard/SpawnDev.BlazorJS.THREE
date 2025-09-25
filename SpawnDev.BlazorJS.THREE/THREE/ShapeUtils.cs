
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShapeUtils : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public ShapeUtils(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// static triangulateShape(contour: Vector2Like[], holes: Vector2Like[][]): number[][];
        /// </summary>
        public Array<Array<float>> TriangulateShape(Array<Vector2Like> contour, Array<Array<Vector2Like>> holes)
        {
            return JSRef!.Call<Array<Array<float>>>("triangulateShape", contour, holes);
        }
        /// <summary>
        /// static isClockWise(pts: Vector2Like[]): boolean;
        /// </summary>
        public bool IsClockWise(Array<Vector2Like> pts)
        {
            return JSRef!.Call<bool>("isClockWise", pts);
        }
        /// <summary>
        /// static area(contour: Vector2Like[]): number;
        /// </summary>
        public float Area(Array<Vector2Like> contour)
        {
            return JSRef!.Call<float>("area", contour);
        }
        #endregion
    }
}
