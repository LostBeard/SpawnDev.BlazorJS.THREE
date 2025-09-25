
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Box3JSON
    {
        #region Properties
        /// <summary>
        /// max: number[];
        /// </summary>
        Array<float>? Max { get; set; }
        /// <summary>
        /// min: number[];
        /// </summary>
        Array<float>? Min { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
