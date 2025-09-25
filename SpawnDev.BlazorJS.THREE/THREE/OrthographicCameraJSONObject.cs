
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface OrthographicCameraJSONObject : Object3DJSONObject
    {
        #region Properties
        /// <summary>
        /// bottom: number;
        /// </summary>
        float? Bottom { get; set; }
        /// <summary>
        /// far: number;
        /// </summary>
        float? Far { get; set; }
        /// <summary>
        /// left: number;
        /// </summary>
        float? Left { get; set; }
        /// <summary>
        /// near: number;
        /// </summary>
        float? Near { get; set; }
        /// <summary>
        /// right: number;
        /// </summary>
        float? Right { get; set; }
        /// <summary>
        /// top: number;
        /// </summary>
        float? Top { get; set; }
        /// <summary>
        /// view?: {
                ///         enabled: boolean;
                ///         fullWidth: number;
                ///         fullHeight: number;
                ///         offsetX: number;
                ///         offsetY: number;
                ///         width: number;
                ///         height: number;
                ///     };
        /// </summary>
        object? View { get; set; }
        /// <summary>
        /// zoom: number;
        /// </summary>
        float? Zoom { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
