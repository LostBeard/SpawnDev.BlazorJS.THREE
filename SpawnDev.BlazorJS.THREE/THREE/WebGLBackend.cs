
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLBackend : Backend
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLBackend(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: BackendParameters);
        /// </summary>
        public WebGLBackend(BackendParameters parameters) : base(JS.New("THREE.WebGLBackend", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get coordinateSystem(): CoordinateSystem;
        /// </summary>
        public CoordinateSystem CoordinateSystem { get => JSRef!.Get<CoordinateSystem>("coordinateSystem"); }
        #endregion

        #region Methods
        /// <summary>
        /// getMaxAnisotropy(): number;
        /// </summary>
        public float GetMaxAnisotropy()
        {
            return JSRef!.Call<float>("getMaxAnisotropy");
        }
        #endregion
    }
}
