
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CylinderGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public CylinderGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         radiusTop?: number,
        ///         radiusBottom?: number,
        ///         height?: number,
        ///         radialSegments?: number,
        ///         heightSegments?: number,
        ///         openEnded?: boolean,
        ///         thetaStart?: number,
        ///         thetaLength?: number,
        ///     );
        /// </summary>
        public CylinderGeometry(float radiusTop, float radiusBottom, float height, float radialSegments, float heightSegments, bool openEnded, float thetaStart, float thetaLength) : base(JS.New("THREE.CylinderGeometry", radiusTop, radiusBottom, height, radialSegments, heightSegments, openEnded, thetaStart, thetaLength)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
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
        /// override readonly type: string | "CylinderGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: any): CylinderGeometry;
        /// </summary>
        public CylinderGeometry FromJSON(object data)
        {
            return JSRef!.Call<CylinderGeometry>("fromJSON", data);
        }
        #endregion
    }
}
