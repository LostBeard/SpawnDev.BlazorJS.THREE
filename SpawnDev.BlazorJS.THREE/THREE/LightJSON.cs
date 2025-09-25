
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LightJSON : Object3DJSON
    {
        #region Properties
        /// <summary>
        /// angle?: number;
        /// </summary>
        float? Angle { get; set; }
        /// <summary>
        /// color: number;
        /// </summary>
        float? Color { get; set; }
        /// <summary>
        /// decay?: number;
        /// </summary>
        float? Decay { get; set; }
        /// <summary>
        /// distance?: number;
        /// </summary>
        float? Distance { get; set; }
        /// <summary>
        /// groundColor?: number;
        /// </summary>
        float? GroundColor { get; set; }
        /// <summary>
        /// intensity: number;
        /// </summary>
        float? Intensity { get; set; }
        /// <summary>
        /// penumbra?: number;
        /// </summary>
        float? Penumbra { get; set; }
        /// <summary>
        /// shadow?: LightShadowJSON;
        /// </summary>
        LightShadowJSON? Shadow { get; set; }
        /// <summary>
        /// target?: string;
        /// </summary>
        string? Target { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
