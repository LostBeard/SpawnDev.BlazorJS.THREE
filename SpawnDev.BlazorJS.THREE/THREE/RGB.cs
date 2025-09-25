
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface RGB
    {
        #region Properties
        /// <summary>
        /// b: number;
        /// </summary>
        float? B { get; set; }
        /// <summary>
        /// g: number;
        /// </summary>
        float? G { get; set; }
        /// <summary>
        /// r: number;
        /// </summary>
        float? R { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
