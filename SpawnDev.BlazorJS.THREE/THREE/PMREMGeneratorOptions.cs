
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface PMREMGeneratorOptions
    {
        #region Properties
        /// <summary>
        /// position?: Vector3 | undefined;
        /// </summary>
        Vector3? Position { get; set; }
        /// <summary>
        /// renderTarget?: RenderTarget | null | undefined;
        /// </summary>
        RenderTarget? RenderTarget { get; set; }
        /// <summary>
        /// size?: number | undefined;
        /// </summary>
        float? Size { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
