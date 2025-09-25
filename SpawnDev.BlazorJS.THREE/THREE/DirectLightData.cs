
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface DirectLightData
    {
        #region Properties
        /// <summary>
        /// lightColor: Node;
        /// </summary>
        Node? LightColor { get; set; }
        /// <summary>
        /// lightDirection: Node;
        /// </summary>
        Node? LightDirection { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
