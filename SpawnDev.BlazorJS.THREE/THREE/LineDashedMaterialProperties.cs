
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LineDashedMaterialProperties : LineBasicMaterialProperties
    {
        #region Properties
        /// <summary>
        /// dashSize: number;
        /// </summary>
        float? DashSize { get; set; }
        /// <summary>
        /// gapSize: number;
        /// </summary>
        float? GapSize { get; set; }
        /// <summary>
        /// scale: number;
        /// </summary>
        float? Scale { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
