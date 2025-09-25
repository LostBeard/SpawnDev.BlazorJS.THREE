
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Face
    {
        #region Properties
        /// <summary>
        /// a: number;
        /// </summary>
        float? A { get; set; }
        /// <summary>
        /// b: number;
        /// </summary>
        float? B { get; set; }
        /// <summary>
        /// c: number;
        /// </summary>
        float? C { get; set; }
        /// <summary>
        /// materialIndex: number;
        /// </summary>
        float? MaterialIndex { get; set; }
        /// <summary>
        /// normal: Vector3;
        /// </summary>
        Vector3? Normal { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
