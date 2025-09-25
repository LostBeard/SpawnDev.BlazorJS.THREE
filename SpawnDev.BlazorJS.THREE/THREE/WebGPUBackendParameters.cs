
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebGPUBackendParameters : BackendParameters
    {
        #region Properties
        /// <summary>
        /// alpha?: boolean | undefined;
        /// </summary>
        bool? Alpha { get; set; }
        /// <summary>
        /// compatibilityMode?: boolean | undefined;
        /// </summary>
        bool? CompatibilityMode { get; set; }
        /// <summary>
        /// context?: GPUCanvasContext | undefined;
        /// </summary>
        GPUCanvasContext? Context { get; set; }
        /// <summary>
        /// device?: GPUDevice | undefined;
        /// </summary>
        GPUDevice? Device { get; set; }
        /// <summary>
        /// outputType?: typeof UnsignedByteType | typeof HalfFloatType | undefined;
        /// </summary>
        Union<UnsignedByteType, HalfFloatType>? OutputType { get; set; }
        /// <summary>
        /// powerPreference?: GPUPowerPreference | undefined;
        /// </summary>
        GPUPowerPreference? PowerPreference { get; set; }
        /// <summary>
        /// requiredLimits?: Record<string, GPUSize64> | undefined;
        /// </summary>
        Record<string, GPUSize64>? RequiredLimits { get; set; }
        /// <summary>
        /// trackTimestamp?: boolean | undefined;
        /// </summary>
        bool? TrackTimestamp { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
