
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Rectangle
    {
        #region Properties
        /// <summary>
        /// w: number;
        /// </summary>
        float? W { get; set; }
        /// <summary>
        /// x: number;
        /// </summary>
        float? X { get; set; }
        /// <summary>
        /// y: number;
        /// </summary>
        float? Y { get; set; }
        /// <summary>
        /// z: number;
        /// </summary>
        float? Z { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
