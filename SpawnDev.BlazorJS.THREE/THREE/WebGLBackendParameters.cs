
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebGLBackendParameters : BackendParameters
    {
        #region Properties
        /// <summary>
        /// trackTimestamp?: boolean | undefined;
        /// </summary>
        bool? TrackTimestamp { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
