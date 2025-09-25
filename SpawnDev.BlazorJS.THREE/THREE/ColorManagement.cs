
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ColorManagement
    {
        #region Properties
        /// <summary>
        /// colorSpaceToWorking: (color: Color, sourceColorSpace: string) => Color;
        /// </summary>
        Callback? ColorSpaceToWorking { get; set; }
        /// <summary>
        /// convert: (color: Color, sourceColorSpace: string, targetColorSpace: string) => Color;
        /// </summary>
        Callback? Convert { get; set; }
        /// <summary>
        /// define: (colorSpaces: Record<string, ColorSpaceDefinition>) => void;
        /// </summary>
        Callback? Define { get; set; }
        /// <summary>
        /// enabled: boolean;
        /// </summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// fromWorkingColorSpace: (color: Color, targetColorSpace: string) => Color;
        /// </summary>
        Callback? FromWorkingColorSpace { get; set; }
        /// <summary>
        /// getLuminanceCoefficients: (target: Vector3, colorSpace?: string) => [number, number, number];
        /// </summary>
        Callback? GetLuminanceCoefficients { get; set; }
        /// <summary>
        /// getPrimaries: (colorSpace: string) => [number, number, number, number, number, number];
        /// </summary>
        Callback? GetPrimaries { get; set; }
        /// <summary>
        /// getTransfer: (colorSpace: string) => ColorSpaceTransfer;
        /// </summary>
        Callback? GetTransfer { get; set; }
        /// <summary>
        /// spaces: Record<string, ColorSpaceDefinition>;
        /// </summary>
        Record<string, ColorSpaceDefinition>? Spaces { get; set; }
        /// <summary>
        /// toWorkingColorSpace: (color: Color, sourceColorSpace: string) => Color;
        /// </summary>
        Callback? ToWorkingColorSpace { get; set; }
        /// <summary>
        /// workingColorSpace: string;
        /// </summary>
        string? WorkingColorSpace { get; set; }
        /// <summary>
        /// workingToColorSpace: (color: Color, targetColorSpace: string) => Color;
        /// </summary>
        Callback? WorkingToColorSpace { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
