
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Texture3DImageData : TextureImageData
    {
        #region Properties
        /// <summary>
        /// depth: number;
        /// </summary>
        float? Depth { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
