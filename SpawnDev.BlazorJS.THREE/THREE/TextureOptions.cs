
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface TextureOptions
    {
        #region Properties
        /// <summary>
        /// depth?: number;
        /// </summary>
        float? Depth { get; set; }
        /// <summary>
        /// height?: number;
        /// </summary>
        float? Height { get; set; }
        /// <summary>
        /// levels?: number;
        /// </summary>
        float? Levels { get; set; }
        /// <summary>
        /// needsMipmaps?: boolean;
        /// </summary>
        bool? NeedsMipmaps { get; set; }
        /// <summary>
        /// width?: number;
        /// </summary>
        float? Width { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
