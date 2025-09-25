
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class OctahedronGeometry : PolyhedronGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public OctahedronGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(radius?: number, detail?: number);
        /// </summary>
        public OctahedronGeometry(float radius, float detail) : base(JS.New("THREE.OctahedronGeometry", radius, detail)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly type: string | "OctahedronGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): OctahedronGeometry;
        /// </summary>
        public OctahedronGeometry FromJSON(object data)
        {
            return JSRef!.Call<OctahedronGeometry>("fromJSON", data);
        }
        #endregion
    }
}
