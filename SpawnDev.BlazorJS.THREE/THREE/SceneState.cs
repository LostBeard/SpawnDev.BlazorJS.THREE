
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface SceneState
    {
        #region Properties
        /// <summary>
        /// background: Color | Texture | CubeTexture | null;
        /// </summary>
        Union<Color, Texture, CubeTexture>? Background { get; set; }
        /// <summary>
        /// backgroundNode: Node | null | undefined;
        /// </summary>
        Node? BackgroundNode { get; set; }
        /// <summary>
        /// overrideMaterial: Material | null;
        /// </summary>
        Material? OverrideMaterial { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
