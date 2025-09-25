
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface PerspectiveCameraJSONObject : Object3DJSONObject
    {
        #region Properties
        /// <summary>
        /// aspect: number;
        /// </summary>
        float? Aspect { get; set; }
        /// <summary>
        /// far: number;
        /// </summary>
        float? Far { get; set; }
        /// <summary>
        /// filmGauge: number;
        /// </summary>
        float? FilmGauge { get; set; }
        /// <summary>
        /// filmOffset: number;
        /// </summary>
        float? FilmOffset { get; set; }
        /// <summary>
        /// focus: number;
        /// </summary>
        float? Focus { get; set; }
        /// <summary>
        /// fov: number;
        /// </summary>
        float? Fov { get; set; }
        /// <summary>
        /// near: number;
        /// </summary>
        float? Near { get; set; }
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
