
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DodecahedronGeometry : PolyhedronGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public DodecahedronGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(radius?: number, detail?: number);
        /// </summary>
        public DodecahedronGeometry(float radius, float detail) : base(JS.New("THREE.DodecahedronGeometry", radius, detail)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly type: string | "DodecahedronGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): DodecahedronGeometry;
        /// </summary>
        public DodecahedronGeometry FromJSON(object data)
        {
            return JSRef!.Call<DodecahedronGeometry>("fromJSON", data);
        }
        #endregion
    }
}
