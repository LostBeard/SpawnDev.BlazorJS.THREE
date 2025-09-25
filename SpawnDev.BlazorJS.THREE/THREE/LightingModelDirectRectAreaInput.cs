
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LightingModelDirectRectAreaInput : DirectRectAreaLightData
    {
        #region Properties
        /// <summary>
        /// lightNode: Node;
        /// </summary>
        Node? LightNode { get; set; }
        /// <summary>
        /// reflectedLight: LightingModelReflectedLight;
        /// </summary>
        LightingModelReflectedLight? ReflectedLight { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
