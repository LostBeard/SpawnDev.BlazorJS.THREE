
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CircleGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public CircleGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(radius?: number, segments?: number, thetaStart?: number, thetaLength?: number);
        /// </summary>
        public CircleGeometry(float radius, float segments, float thetaStart, float thetaLength) : base(JS.New("THREE.CircleGeometry", radius, segments, thetaStart, thetaLength)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly radius: number;
                ///         readonly segments: number;
                ///         readonly thetaStart: number;
                ///         readonly thetaLength: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "CircleGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): CircleGeometry;
        /// </summary>
        public CircleGeometry FromJSON(object data)
        {
            return JSRef!.Call<CircleGeometry>("fromJSON", data);
        }
        #endregion
    }
}
