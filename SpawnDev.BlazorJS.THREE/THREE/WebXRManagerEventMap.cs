
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebXRManagerEventMap
    {
        #region Properties
        /// <summary>
        /// planeadded: { data: XRPlane };
        /// </summary>
        object? Planeadded { get; set; }
        /// <summary>
        /// planechanged: { data: XRPlane };
        /// </summary>
        object? Planechanged { get; set; }
        /// <summary>
        /// planeremoved: { data: XRPlane };
        /// </summary>
        object? Planeremoved { get; set; }
        /// <summary>
        /// planesdetected: { data: XRPlaneSet };
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
