
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TorusGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public TorusGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(radius?: number, tube?: number, radialSegments?: number, tubularSegments?: number, arc?: number);
        /// </summary>
        public TorusGeometry(float radius, float tube, float radialSegments, float tubularSegments, float arc) : base(JS.New("THREE.TorusGeometry", radius, tube, radialSegments, tubularSegments, arc)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly radius: number;
                ///         readonly tube: number;
                ///         readonly radialSegments: number;
                ///         readonly tubularSegments: number;
                ///         readonly arc: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "TorusGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: any): TorusGeometry;
        /// </summary>
        public TorusGeometry FromJSON(object data)
        {
            return JSRef!.Call<TorusGeometry>("fromJSON", data);
        }
        #endregion
    }
}
