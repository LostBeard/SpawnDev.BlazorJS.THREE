
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CapsuleGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public CapsuleGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         radius?: number,
        ///         height?: number,
        ///         capSegments?: number,
        ///         radialSegments?: number,
        ///         heightSegments?: number,
        ///     );
        /// </summary>
        public CapsuleGeometry(float radius, float height, float capSegments, float radialSegments, float heightSegments) : base(JS.New("THREE.CapsuleGeometry", radius, height, capSegments, radialSegments, heightSegments)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly radius: number;
                ///         readonly height: number;
                ///         readonly capSegments: number;
                ///         readonly radialSegments: number;
                ///         readonly heightSegments: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "CapsuleGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): CapsuleGeometry;
        /// </summary>
        public CapsuleGeometry FromJSON(object data)
        {
            return JSRef!.Call<CapsuleGeometry>("fromJSON", data);
        }
        #endregion
    }
}
