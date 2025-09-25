
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface NodeJSONMetadata
    {
        #region Properties
        /// <summary>
        /// generator: "Node.toJSON";
        /// </summary>
        string? Generator { get; set; }
        /// <summary>
        /// type: "Node";
        /// </summary>
        string? Type { get; set; }
        /// <summary>
        /// version: number;
        /// </summary>
        float? Version { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
