
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface KeyframeTrackJSON
    {
        #region Properties
        /// <summary>
        /// interpolation?: InterpolationModes;
        /// </summary>
        InterpolationModes? Interpolation { get; set; }
        /// <summary>
        /// name: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// times: number[];
        /// </summary>
        Array<float>? Times { get; set; }
        /// <summary>
        /// type: string;
        /// </summary>
        string? Type { get; set; }
        /// <summary>
        /// values: number[];
        /// </summary>
        Array<float>? Values { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
