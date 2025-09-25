
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface BackendParameters
    {
        #region Properties
        /// <summary>
        /// canvas?: HTMLCanvasElement | OffscreenCanvas | undefined;
        /// </summary>
        Union<HTMLCanvasElement, OffscreenCanvas>? Canvas { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
