
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SphereGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public SphereGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         radius?: number,
        ///         widthSegments?: number,
        ///         heightSegments?: number,
        ///         phiStart?: number,
        ///         phiLength?: number,
        ///         thetaStart?: number,
        ///         thetaLength?: number,
        ///     );
        /// </summary>
        public SphereGeometry(float radius, float widthSegments, float heightSegments, float phiStart, float phiLength, float thetaStart, float thetaLength) : base(JS.New("THREE.SphereGeometry", radius, widthSegments, heightSegments, phiStart, phiLength, thetaStart, thetaLength)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly radius: number;
                ///         readonly widthSegments: number;
                ///         readonly heightSegments: number;
                ///         readonly phiStart: number;
                ///         readonly phiLength: number;
                ///         readonly thetaStart: number;
                ///         readonly thetaLength: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "SphereGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): SphereGeometry;
        /// </summary>
        public SphereGeometry FromJSON(object data)
        {
            return JSRef!.Call<SphereGeometry>("fromJSON", data);
        }
        #endregion
    }
}
