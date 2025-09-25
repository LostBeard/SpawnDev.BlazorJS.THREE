
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TubeGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public TubeGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         path?: Curve<Vector3>,
        ///         tubularSegments?: number,
        ///         radius?: number,
        ///         radialSegments?: number,
        ///         closed?: boolean,
        ///     );
        /// </summary>
        public TubeGeometry(Curve<Vector3> path, float tubularSegments, float radius, float radialSegments, bool closed) : base(JS.New("THREE.TubeGeometry", path, tubularSegments, radius, radialSegments, closed)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// binormals: Vector3[];
        /// </summary>
        public Array<Vector3> Binormals { get => JSRef!.Get<Array<Vector3>>("binormals"); set => JSRef!.Set("binormals", value); }
        /// <summary>
        /// normals: Vector3[];
        /// </summary>
        public Array<Vector3> Normals { get => JSRef!.Get<Array<Vector3>>("normals"); set => JSRef!.Set("normals", value); }
        /// <summary>
        /// readonly parameters: {
                ///         readonly path: Curve<Vector3>;
                ///         readonly tubularSegments: number;
                ///         readonly radius: number;
                ///         readonly radialSegments: number;
                ///         readonly closed: boolean;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// tangents: Vector3[];
        /// </summary>
        public Array<Vector3> Tangents { get => JSRef!.Get<Array<Vector3>>("tangents"); set => JSRef!.Set("tangents", value); }
        /// <summary>
        /// override readonly type: string | "TubeGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): TubeGeometry;
        /// </summary>
        public TubeGeometry FromJSON(object data)
        {
            return JSRef!.Call<TubeGeometry>("fromJSON", data);
        }
        #endregion
    }
}
