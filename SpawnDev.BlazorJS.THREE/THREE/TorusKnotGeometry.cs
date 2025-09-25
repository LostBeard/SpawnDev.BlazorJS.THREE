
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TorusKnotGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public TorusKnotGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         radius?: number,
        ///         tube?: number,
        ///         tubularSegments?: number,
        ///         radialSegments?: number,
        ///         p?: number,
        ///         q?: number,
        ///     );
        /// </summary>
        public TorusKnotGeometry(float radius, float tube, float tubularSegments, float radialSegments, float p, float q) : base(JS.New("THREE.TorusKnotGeometry", radius, tube, tubularSegments, radialSegments, p, q)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly radius: number;
                ///         readonly tube: number;
                ///         readonly tubularSegments: number;
                ///         readonly radialSegments: number;
                ///         readonly p: number;
                ///         readonly q: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "TorusKnotGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): TorusKnotGeometry;
        /// </summary>
        public TorusKnotGeometry FromJSON(object data)
        {
            return JSRef!.Call<TorusKnotGeometry>("fromJSON", data);
        }
        #endregion
    }
}
