
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TetrahedronGeometry : PolyhedronGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public TetrahedronGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(radius?: number, detail?: number);
        /// </summary>
        public TetrahedronGeometry(float radius, float detail) : base(JS.New("THREE.TetrahedronGeometry", radius, detail)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly type: string | "TetrahedronGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): TetrahedronGeometry;
        /// </summary>
        public TetrahedronGeometry FromJSON(object data)
        {
            return JSRef!.Call<TetrahedronGeometry>("fromJSON", data);
        }
        #endregion
    }
}
