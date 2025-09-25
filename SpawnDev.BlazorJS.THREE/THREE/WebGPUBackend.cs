
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGPUBackend : Backend
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGPUBackend(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: WebGPUBackendParameters);
        /// </summary>
        public WebGPUBackend(WebGPUBackendParameters parameters) : base(JS.New("THREE.WebGPUBackend", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get coordinateSystem(): CoordinateSystem;
        /// </summary>
        public CoordinateSystem CoordinateSystem { get => JSRef!.Get<CoordinateSystem>("coordinateSystem"); }
        /// <summary>
        /// readonly isWebGPUBackend: true;
        /// </summary>
        public bool IsWebGPUBackend { get => JSRef!.Get<bool>("isWebGPUBackend"); }
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
