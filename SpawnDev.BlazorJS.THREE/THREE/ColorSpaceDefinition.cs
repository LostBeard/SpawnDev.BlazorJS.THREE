
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ColorSpaceDefinition
    {
        #region Properties
        /// <summary>
        /// fromXYZ: Matrix3;
        /// </summary>
        Matrix3? FromXYZ { get; set; }
        /// <summary>
        /// luminanceCoefficients: [number, number, number];
        /// </summary>
        (float, float, float)? LuminanceCoefficients { get; set; }
        /// <summary>
        /// outputColorSpaceConfig?: { drawingBufferColorSpace: string; toneMappingNode?: "extended" | "standard" };
        /// </summary>
        object? OutputColorSpaceConfig { get; set; }
        /// <summary>
        /// primaries: [number, number, number, number, number, number];
        /// </summary>
        (float, float, float, float, float, float)? Primaries { get; set; }
        /// <summary>
        /// toXYZ: Matrix3;
        /// </summary>
        Matrix3? ToXYZ { get; set; }
        /// <summary>
        /// transfer: ColorSpaceTransfer;
        /// </summary>
        ColorSpaceTransfer? Transfer { get; set; }
        /// <summary>
        /// whitePoint: [number, number];
        /// </summary>
        (float, float)? WhitePoint { get; set; }
        /// <summary>
        /// workingColorSpaceConfig?: { unpackColorSpace: string };
        /// </summary>
        object? WorkingColorSpaceConfig { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
