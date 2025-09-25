
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebXRSpaceEventMap : Object3DEventMap
    {
        #region Properties
        /// <summary>
        /// connected: { data: XRInputSource };
        /// </summary>
        object? Connected { get; set; }
        /// <summary>
        /// disconnected: { data: XRInputSource };
        /// </summary>
        object? Disconnected { get; set; }
        /// <summary>
        /// move: {};
        /// </summary>
        object? Move { get; set; }
        /// <summary>
        /// pinchend: { handedness: XRHandedness; target: WebXRController };
        /// </summary>
        object? Pinchend { get; set; }
        /// <summary>
        /// pinchstart: { handedness: XRHandedness; target: WebXRController };
        /// </summary>
        object? Pinchstart { get; set; }
        /// <summary>
        /// select: { data: XRInputSource };
        /// </summary>
        object? Select { get; set; }
        /// <summary>
        /// selectend: { data: XRInputSource };
        /// </summary>
        object? Selectend { get; set; }
        /// <summary>
        /// selectstart: { data: XRInputSource };
        /// </summary>
        object? Selectstart { get; set; }
        /// <summary>
        /// squeeze: { data: XRInputSource };
        /// </summary>
        object? Squeeze { get; set; }
        /// <summary>
        /// squeezeend: { data: XRInputSource };
        /// </summary>
        object? Squeezeend { get; set; }
        /// <summary>
        /// squeezestart: { data: XRInputSource };
        /// </summary>
        object? Squeezestart { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
