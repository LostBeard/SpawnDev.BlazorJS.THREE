
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface SpriteNodeMaterialNodeProperties : NodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// rotationNode: Node | null;
        /// </summary>
        Node? RotationNode { get; set; }
        /// <summary>
        /// scaleNode: Node | null;
        /// </summary>
        Node? ScaleNode { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
