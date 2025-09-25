
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BoxGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public BoxGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         width?: number,
        ///         height?: number,
        ///         depth?: number,
        ///         widthSegments?: number,
        ///         heightSegments?: number,
        ///         depthSegments?: number,
        ///     );
        /// </summary>
        public BoxGeometry(float width = 1, float height = 1, float depth = 1, float widthSegments = 1, float heightSegments = 1, float depthSegments = 1) : base(JS.New("THREE.BoxGeometry", width, height, depth, widthSegments, heightSegments, depthSegments)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly width: number;
                ///         readonly height: number;
                ///         readonly depth: number;
                ///         readonly widthSegments: number;
                ///         readonly heightSegments: number;
                ///         readonly depthSegments: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "BoxGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): BoxGeometry;
        /// </summary>
        public BoxGeometry FromJSON(object data)
        {
            return JSRef!.Call<BoxGeometry>("fromJSON", data);
        }
        #endregion
    }
}
