
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface RenderObjectData
    {
        #region Properties
        /// <summary>
        /// geometry: {
                ///         id: number;
                ///         attributes: AttributesData;
                ///         indexVersion: number | null;
                ///         drawRange: {
                ///             start: number;
                ///             count: number;
                ///         };
                ///     };
        /// </summary>
        object? Geometry { get; set; }
        /// <summary>
        /// material: MaterialData;
        /// </summary>
        MaterialData? Material { get; set; }
        /// <summary>
        /// version?: number;
        /// </summary>
        float? Version { get; set; }
        /// <summary>
        /// worldMatrix: Matrix4;
        /// </summary>
        Matrix4? WorldMatrix { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
