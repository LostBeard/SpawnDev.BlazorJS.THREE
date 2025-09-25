
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface FogJSON
    {
        #region Properties
        /// <summary>
        /// color: number;
        /// </summary>
        float? Color { get; set; }
        /// <summary>
        /// far: number;
        /// </summary>
        float? Far { get; set; }
        /// <summary>
        /// name: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// near: number;
        /// </summary>
        float? Near { get; set; }
        /// <summary>
        /// type: string;
        /// </summary>
        string? Type { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
