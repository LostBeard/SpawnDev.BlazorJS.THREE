
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface DirectRectAreaLightData
    {
        #region Properties
        /// <summary>
        /// halfHeight: Node;
        /// </summary>
        Node? HalfHeight { get; set; }
        /// <summary>
        /// halfWidth: Node;
        /// </summary>
        Node? HalfWidth { get; set; }
        /// <summary>
        /// lightColor: Node;
        /// </summary>
        Node? LightColor { get; set; }
        /// <summary>
        /// lightPosition: Node;
        /// </summary>
        Node? LightPosition { get; set; }
        /// <summary>
        /// ltc_1: Node;
        /// </summary>
        Node? Ltc_1 { get; set; }
        /// <summary>
        /// ltc_2: Node;
        /// </summary>
        Node? Ltc_2 { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
