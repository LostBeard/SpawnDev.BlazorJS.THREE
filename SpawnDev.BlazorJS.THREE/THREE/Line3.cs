
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Line3 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Line3(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(start?: Vector3, end?: Vector3);
        /// </summary>
        public Line3(Vector3 start, Vector3 end) : base(JS.New("THREE.Line3", start, end)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// end: Vector3;
        /// </summary>
        public Vector3 End { get => JSRef!.Get<Vector3>("end"); set => JSRef!.Set("end", value); }
        /// <summary>
        /// start: Vector3;
        /// </summary>
        public Vector3 Start { get => JSRef!.Get<Vector3>("start"); set => JSRef!.Set("start", value); }
        #endregion

        #region Methods
        /// <summary>
        /// set(start?: Vector3, end?: Vector3): Line3;
        /// </summary>
        public Line3 Set(Vector3 start, Vector3 end)
        {
            return JSRef!.Call<Line3>("set", start, end);
        }
        /// <summary>
        /// getCenter(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetCenter(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getCenter", target);
        }
        /// <summary>
        /// equals(line: Line3): boolean;
        /// </summary>
        public bool Equals(Line3 line)
        {
            return JSRef!.Call<bool>("equals", line);
        }
        /// <summary>
        /// distanceSqToLine3(line: Line3, c1?: Vector3, c2?: Vector3): number;
        /// </summary>
        public float DistanceSqToLine3(Line3 line, Vector3 c1, Vector3 c2)
        {
            return JSRef!.Call<float>("distanceSqToLine3", line, c1, c2);
        }
        /// <summary>
        /// distanceSq(): number;
        /// </summary>
        public float DistanceSq()
        {
            return JSRef!.Call<float>("distanceSq");
        }
        /// <summary>
        /// distance(): number;
        /// </summary>
        public float Distance()
        {
            return JSRef!.Call<float>("distance");
        }
        /// <summary>
        /// delta(target: Vector3): Vector3;
        /// </summary>
        public Vector3 Delta(Vector3 target)
        {
            return JSRef!.Call<Vector3>("delta", target);
        }
        /// <summary>
        /// copy(line: Line3): this;
        /// </summary>
        public Line3 Copy(Line3 line)
        {
            return JSRef!.Call<Line3>("copy", line);
        }
        /// <summary>
        /// closestPointToPointParameter(point: Vector3, clampToLine?: boolean): number;
        /// </summary>
        public float ClosestPointToPointParameter(Vector3 point, bool clampToLine)
        {
            return JSRef!.Call<float>("closestPointToPointParameter", point, clampToLine);
        }
        /// <summary>
        /// closestPointToPoint(point: Vector3, clampToLine: boolean, target: Vector3): Vector3;
        /// </summary>
        public Vector3 ClosestPointToPoint(Vector3 point, bool clampToLine, Vector3 target)
        {
            return JSRef!.Call<Vector3>("closestPointToPoint", point, clampToLine, target);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Line3 Clone()
        {
            return JSRef!.Call<Line3>("clone");
        }
        /// <summary>
        /// at(t: number, target: Vector3): Vector3;
        /// </summary>
        public Vector3 At(float t, Vector3 target)
        {
            return JSRef!.Call<Vector3>("at", t, target);
        }
        /// <summary>
        /// applyMatrix4(matrix: Matrix4): Line3;
        /// </summary>
        public Line3 ApplyMatrix4(Matrix4 matrix)
        {
            return JSRef!.Call<Line3>("applyMatrix4", matrix);
        }
        #endregion
    }
}
