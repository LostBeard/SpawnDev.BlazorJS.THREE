
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ConeGeometry : CylinderGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public ConeGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         radius?: number,
        ///         height?: number,
        ///         radialSegments?: number,
        ///         heightSegments?: number,
        ///         openEnded?: boolean,
        ///         thetaStart?: number,
        ///         thetaLength?: number,
        ///     );
        /// </summary>
        public ConeGeometry(float radius, float height, float radialSegments, float heightSegments, bool openEnded, float thetaStart, float thetaLength) : base(JS.New("THREE.ConeGeometry", radius, height, radialSegments, heightSegments, openEnded, thetaStart, thetaLength)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly parameters: {
                ///         readonly radius: number;
                ///         readonly radiusTop: number;
                ///         readonly radiusBottom: number;
                ///         readonly height: number;
                ///         readonly radialSegments: number;
                ///         readonly heightSegments: number;
                ///         readonly openEnded: boolean;
                ///         readonly thetaStart: number;
                ///         readonly thetaLength: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "ConeGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): ConeGeometry;
        /// </summary>
        public ConeGeometry FromJSON(object data)
        {
            return JSRef!.Call<ConeGeometry>("fromJSON", data);
        }
        #endregion
    }
}
