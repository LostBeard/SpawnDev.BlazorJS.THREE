
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface TextureData
    {
        #region Properties
        /// <summary>
        /// generation?: number;
        /// </summary>
        float? Generation { get; set; }
        /// <summary>
        /// initialized?: boolean;
        /// </summary>
        bool? Initialized { get; set; }
        /// <summary>
        /// isDefaultTexture?: boolean;
        /// </summary>
        bool? IsDefaultTexture { get; set; }
        /// <summary>
        /// version?: number;
        /// </summary>
        float? Version { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
