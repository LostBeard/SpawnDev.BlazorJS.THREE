
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LightingModelReflectedLight
    {
        #region Properties
        /// <summary>
        /// directDiffuse: Node;
        /// </summary>
        Node? DirectDiffuse { get; set; }
        /// <summary>
        /// directSpecular: Node;
        /// </summary>
        Node? DirectSpecular { get; set; }
        /// <summary>
        /// indirectDiffuse: Node;
        /// </summary>
        Node? IndirectDiffuse { get; set; }
        /// <summary>
        /// indirectSpecular: Node;
        /// </summary>
        Node? IndirectSpecular { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
