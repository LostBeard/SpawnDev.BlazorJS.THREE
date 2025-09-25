
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LineBasicMaterialProperties : MaterialProperties
    {
        #region Properties
        /// <summary>
        /// color: Color;
        /// </summary>
        Color? Color { get; set; }
        /// <summary>
        /// fog: boolean;
        /// </summary>
        bool? Fog { get; set; }
        /// <summary>
        /// linecap: "butt" | "round" | "square";
        /// </summary>
        string? Linecap { get; set; }
        /// <summary>
        /// linejoin: "round" | "bevel" | "miter";
        /// </summary>
        string? Linejoin { get; set; }
        /// <summary>
        /// linewidth: number;
        /// </summary>
        float? Linewidth { get; set; }
        /// <summary>
        /// map: Texture | null;
        /// </summary>
        Texture? Map { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
