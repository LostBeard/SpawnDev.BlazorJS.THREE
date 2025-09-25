
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface FogExp2JSON
    {
        #region Properties
        /// <summary>
        /// color: number;
        /// </summary>
        float? Color { get; set; }
        /// <summary>
        /// density: number;
        /// </summary>
        float? Density { get; set; }
        /// <summary>
        /// name: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// type: string;
        /// </summary>
        string? Type { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
