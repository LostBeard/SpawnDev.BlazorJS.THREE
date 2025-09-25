
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PlaneGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public PlaneGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number, widthSegments?: number, heightSegments?: number);
        /// </summary>
        public PlaneGeometry(float width, float height, float widthSegments, float heightSegments) : base(JS.New("THREE.PlaneGeometry", width, height, widthSegments, heightSegments)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly width: number;
                ///         readonly height: number;
                ///         readonly widthSegments: number;
                ///         readonly heightSegments: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "PlaneGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): PlaneGeometry;
        /// </summary>
        public PlaneGeometry FromJSON(object data)
        {
            return JSRef!.Call<PlaneGeometry>("fromJSON", data);
        }
        #endregion
    }
}
