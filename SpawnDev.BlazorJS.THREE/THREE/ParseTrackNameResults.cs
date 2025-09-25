
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ParseTrackNameResults
    {
        #region Properties
        /// <summary>
        /// nodeName: string;
        /// </summary>
        string? NodeName { get; set; }
        /// <summary>
        /// objectIndex: string;
        /// </summary>
        string? ObjectIndex { get; set; }
        /// <summary>
        /// objectName: string;
        /// </summary>
        string? ObjectName { get; set; }
        /// <summary>
        /// propertyIndex: string;
        /// </summary>
        string? PropertyIndex { get; set; }
        /// <summary>
        /// propertyName: string;
        /// </summary>
        string? PropertyName { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
