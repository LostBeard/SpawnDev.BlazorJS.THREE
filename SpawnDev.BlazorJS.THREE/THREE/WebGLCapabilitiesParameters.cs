
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebGLCapabilitiesParameters
    {
        #region Properties
        /// <summary>
        /// logarithmicDepthBuffer?: boolean | undefined;
        /// </summary>
        bool? LogarithmicDepthBuffer { get; set; }
        /// <summary>
        /// precision?: string | undefined;
        /// </summary>
        string? Precision { get; set; }
        /// <summary>
        /// reversedDepthBuffer?: boolean | undefined;
        /// </summary>
        bool? ReversedDepthBuffer { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
