
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface SphereJSON
    {
        #region Properties
        /// <summary>
        /// center: number[];
        /// </summary>
        Array<float>? Center { get; set; }
        /// <summary>
        /// radius: number;
        /// </summary>
        float? Radius { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
