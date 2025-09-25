
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RingGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public RingGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         innerRadius?: number,
        ///         outerRadius?: number,
        ///         thetaSegments?: number,
        ///         phiSegments?: number,
        ///         thetaStart?: number,
        ///         thetaLength?: number,
        ///     );
        /// </summary>
        public RingGeometry(float innerRadius, float outerRadius, float thetaSegments, float phiSegments, float thetaStart, float thetaLength) : base(JS.New("THREE.RingGeometry", innerRadius, outerRadius, thetaSegments, phiSegments, thetaStart, thetaLength)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly innerRadius: number;
                ///         readonly outerRadius: number;
                ///         readonly thetaSegments: number;
                ///         readonly phiSegments: number;
                ///         readonly thetaStart: number;
                ///         readonly thetaLength: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "RingGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): RingGeometry;
        /// </summary>
        public RingGeometry FromJSON(object data)
        {
            return JSRef!.Call<RingGeometry>("fromJSON", data);
        }
        #endregion
    }
}
