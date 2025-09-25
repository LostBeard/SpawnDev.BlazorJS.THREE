
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Shape : Path
    {
        #region Constructors
        /// <inheritdoc/>
        public Shape(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(points?: Vector2[]);
        /// </summary>
        public Shape(Array<Vector2> points) : base(JS.New("THREE.Shape", points)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// holes: Path[];
        /// </summary>
        public Array<Path> Holes { get => JSRef!.Get<Array<Path>>("holes"); set => JSRef!.Set("holes", value); }
        /// <summary>
        /// override readonly type: string | "Shape";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(): ShapeJSON;
        /// </summary>
        public ShapeJSON ToJSON()
        {
            return JSRef!.Call<ShapeJSON>("toJSON");
        }
        /// <summary>
        /// getPointsHoles(divisions: number): Vector2[][];
        /// </summary>
        public Array<Array<Vector2>> GetPointsHoles(float divisions)
        {
            return JSRef!.Call<Array<Array<Vector2>>>("getPointsHoles", divisions);
        }
        /// <summary>
        /// fromJSON(json: ShapeJSON): this;
        /// </summary>
        public Shape FromJSON(ShapeJSON json)
        {
            return JSRef!.Call<Shape>("fromJSON", json);
        }
        /// <summary>
        /// extractPoints(divisions: number): {
        ///         shape: Vector2[];
        ///         holes: Vector2[][];
        ///     };
        /// </summary>
        public object ExtractPoints(float divisions)
        {
            return JSRef!.Call<object>("extractPoints", divisions);
        }
        #endregion
    }
}
