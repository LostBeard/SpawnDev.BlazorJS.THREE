
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface HSL
    {
        #region Properties
        /// <summary>
        /// h: number;
        /// </summary>
        float? H { get; set; }
        /// <summary>
        /// l: number;
        /// </summary>
        float? L { get; set; }
        /// <summary>
        /// s: number;
        /// </summary>
        float? S { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
