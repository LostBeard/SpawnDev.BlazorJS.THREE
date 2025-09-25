
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface XRManagerEventMap
    {
        #region Properties
        /// <summary>
        /// planesdetected: {
                ///         data: XRFrame;
                ///     };
        /// </summary>
        object? Planesdetected { get; set; }
        /// <summary>
        /// sessionend: {};
        /// </summary>
        object? Sessionend { get; set; }
        /// <summary>
        /// sessionstart: {};
        /// </summary>
        object? Sessionstart { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
