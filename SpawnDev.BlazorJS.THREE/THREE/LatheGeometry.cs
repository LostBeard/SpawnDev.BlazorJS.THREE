
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LatheGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public LatheGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(points?: Vector2[], segments?: number, phiStart?: number, phiLength?: number);
        /// </summary>
        public LatheGeometry(Array<Vector2> points, float segments, float phiStart, float phiLength) : base(JS.New("THREE.LatheGeometry", points, segments, phiStart, phiLength)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly points: Vector2[];
                ///         readonly segments: number;
                ///         readonly phiStart: number;
                ///         readonly phiLength: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "LatheGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): LatheGeometry;
        /// </summary>
        public LatheGeometry FromJSON(object data)
        {
            return JSRef!.Call<LatheGeometry>("fromJSON", data);
        }
        #endregion
    }
}
