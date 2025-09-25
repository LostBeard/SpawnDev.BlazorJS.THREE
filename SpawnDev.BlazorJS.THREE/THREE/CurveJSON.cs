
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface CurveJSON
    {
        #region Properties
        /// <summary>
        /// arcLengthDivisions: number;
        /// </summary>
        float? ArcLengthDivisions { get; set; }
        /// <summary>
        /// metadata: { version: number; type: string; generator: string };
        /// </summary>
        object? Metadata { get; set; }
        /// <summary>
        /// type: string;
        /// </summary>
        string? Type { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
