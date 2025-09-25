
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PolyhedronGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public PolyhedronGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(vertices?: number[], indices?: number[], radius?: number, detail?: number);
        /// </summary>
        public PolyhedronGeometry(Array<float> vertices, Array<float> indices, float radius, float detail) : base(JS.New("THREE.PolyhedronGeometry", vertices, indices, radius, detail)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly vertices: number[];
                ///         readonly indices: number[];
                ///         readonly radius: number;
                ///         readonly detail: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "PolyhedronGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): PolyhedronGeometry;
        /// </summary>
        public PolyhedronGeometry FromJSON(object data)
        {
            return JSRef!.Call<PolyhedronGeometry>("fromJSON", data);
        }
        #endregion
    }
}
