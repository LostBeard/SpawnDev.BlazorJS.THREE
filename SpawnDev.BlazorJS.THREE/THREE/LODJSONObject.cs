
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LODJSONObject : Object3DJSONObject
    {
        #region Properties
        /// <summary>
        /// autoUpdate?: boolean;
        /// </summary>
        bool? AutoUpdate { get; set; }
        /// <summary>
        /// levels: Array<{
                ///         object: string;
                ///         distance: number;
                ///         hysteresis: number;
                ///     }>;
        /// </summary>
        Array<object>? Levels { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
