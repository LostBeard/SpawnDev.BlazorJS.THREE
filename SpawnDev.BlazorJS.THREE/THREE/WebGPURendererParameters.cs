
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebGPURendererParameters : RendererParameters, WebGPUBackendParameters
    {
        #region Properties
        /// <summary>
        /// forceWebGL?: boolean | undefined;
        /// </summary>
        bool? ForceWebGL { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
