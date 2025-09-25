
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Vector4Like
    {
        #region Properties
        /// <summary>
        /// readonly w: number;
        /// </summary>
        float? W { get; }
        /// <summary>
        /// readonly x: number;
        /// </summary>
        float? X { get; }
        /// <summary>
        /// readonly y: number;
        /// </summary>
        float? Y { get; }
        /// <summary>
        /// readonly z: number;
        /// </summary>
        float? Z { get; }
        #endregion

        #region Methods

        #endregion
    }
}
