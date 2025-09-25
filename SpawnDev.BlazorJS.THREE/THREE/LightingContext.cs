
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LightingContext
    {
        #region Properties
        /// <summary>
        /// ambientOcclusion: Node;
        /// </summary>
        Node? AmbientOcclusion { get; set; }
        /// <summary>
        /// backdrop: Node;
        /// </summary>
        Node? Backdrop { get; set; }
        /// <summary>
        /// backdropAlpha: Node;
        /// </summary>
        Node? BackdropAlpha { get; set; }
        /// <summary>
        /// iblIrradiance: Node;
        /// </summary>
        Node? IblIrradiance { get; set; }
        /// <summary>
        /// irradiance: Node;
        /// </summary>
        Node? Irradiance { get; set; }
        /// <summary>
        /// radiance: Node;
        /// </summary>
        Node? Radiance { get; set; }
        /// <summary>
        /// reflectedLight: LightingModelReflectedLight;
        /// </summary>
        LightingModelReflectedLight? ReflectedLight { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
