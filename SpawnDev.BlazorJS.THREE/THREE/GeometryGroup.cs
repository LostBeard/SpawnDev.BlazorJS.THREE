
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface GeometryGroup
    {
        #region Properties
        /// <summary>
        /// count: number;
        /// </summary>
        float? Count { get; set; }
        /// <summary>
        /// materialIndex?: number | undefined;
        /// </summary>
        float? MaterialIndex { get; set; }
        /// <summary>
        /// start: number;
        /// </summary>
        float? Start { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
