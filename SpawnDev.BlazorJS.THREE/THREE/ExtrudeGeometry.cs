
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ExtrudeGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public ExtrudeGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(shapes?: Shape | Shape[], options?: ExtrudeGeometryOptions);
        /// </summary>
        public ExtrudeGeometry(Union<Shape, Array<Shape>> shapes, ExtrudeGeometryOptions options) : base(JS.New("THREE.ExtrudeGeometry", shapes, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly shapes: Shape | Shape[];
                ///         readonly options: ExtrudeGeometryOptions;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "ExtrudeGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}, shapes: object): ExtrudeGeometry;
        /// </summary>
        public ExtrudeGeometry FromJSON(object data, object shapes)
        {
            return JSRef!.Call<ExtrudeGeometry>("fromJSON", data, shapes);
        }
        /// <summary>
        /// addShape(shape: Shape): void;
        /// </summary>
        public void AddShape(Shape shape)
        {
            JSRef!.CallVoid("addShape", shape);
        }
        #endregion
    }
}
