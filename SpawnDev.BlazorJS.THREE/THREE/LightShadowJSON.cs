
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LightShadowJSON
    {
        #region Properties
        /// <summary>
        /// bias?: number;
        /// </summary>
        float? Bias { get; set; }
        ///// <summary>
        ///// camera: Omit<Object3DJSONObject, "matrix">;
        ///// </summary>
        //Omit<Object3DJSONObject, string>? Camera { get; set; }
        /// <summary>
        /// intensity?: number;
        /// </summary>
        float? Intensity { get; set; }
        /// <summary>
        /// mapSize?: Vector2Tuple;
        /// </summary>
        Vector2Tuple? MapSize { get; set; }
        /// <summary>
        /// normalBias?: number;
        /// </summary>
        float? NormalBias { get; set; }
        /// <summary>
        /// radius?: number;
        /// </summary>
        float? Radius { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
