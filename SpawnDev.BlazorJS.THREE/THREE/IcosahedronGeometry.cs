
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class IcosahedronGeometry : PolyhedronGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public IcosahedronGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(radius?: number, detail?: number);
        /// </summary>
        public IcosahedronGeometry(float radius, float detail) : base(JS.New("THREE.IcosahedronGeometry", radius, detail)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly type: string | "IcosahedronGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// static fromJSON(data: {}): IcosahedronGeometry;
        /// </summary>
        public IcosahedronGeometry FromJSON(object data)
        {
            return JSRef!.Call<IcosahedronGeometry>("fromJSON", data);
        }
        #endregion
    }
}
