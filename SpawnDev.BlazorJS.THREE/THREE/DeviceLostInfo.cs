
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface DeviceLostInfo
    {
        #region Properties
        /// <summary>
        /// api: "WebGL" | "WebGPU";
        /// </summary>
        string? Api { get; set; }
        /// <summary>
        /// message: string;
        /// </summary>
        string? Message { get; set; }
        /// <summary>
        /// originalEvent: object;
        /// </summary>
        object? OriginalEvent { get; set; }
        /// <summary>
        /// reason: string | null;
        /// </summary>
        string? Reason { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
