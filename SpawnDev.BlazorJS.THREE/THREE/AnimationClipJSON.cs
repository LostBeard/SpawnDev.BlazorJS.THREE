
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface AnimationClipJSON
    {
        #region Properties
        /// <summary>
        /// blendMode: AnimationBlendMode;
        /// </summary>
        AnimationBlendMode? BlendMode { get; set; }
        /// <summary>
        /// duration: number;
        /// </summary>
        float? Duration { get; set; }
        /// <summary>
        /// name: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// tracks: KeyframeTrackJSON[];
        /// </summary>
        Array<KeyframeTrackJSON>? Tracks { get; set; }
        /// <summary>
        /// uuid: string;
        /// </summary>
        string? Uuid { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
