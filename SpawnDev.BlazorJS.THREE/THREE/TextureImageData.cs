
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface TextureImageData
    {
        #region Properties
        /// <summary>
        /// data: TypedArray;
        /// </summary>
        TypedArray? Data { get; set; }
        /// <summary>
        /// height: number;
        /// </summary>
        float? Height { get; set; }
        /// <summary>
        /// width: number;
        /// </summary>
        float? Width { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
