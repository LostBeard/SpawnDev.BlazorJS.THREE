
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShapeGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public ShapeGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(shapes?: Shape | Shape[], curveSegments?: number);
        /// </summary>
        public ShapeGeometry(Union<Shape, Array<Shape>> shapes, float curveSegments) : base(JS.New("THREE.ShapeGeometry", shapes, curveSegments)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly shapes: Shape | Shape[];
                ///         readonly curveSegments: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "ShapeGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): ShapeGeometry;
        /// </summary>
        public ShapeGeometry FromJSON(object data)
        {
            return JSRef!.Call<ShapeGeometry>("fromJSON", data);
        }
        #endregion
    }
}
