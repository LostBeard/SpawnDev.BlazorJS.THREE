
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshStandardNodeMaterialNodeProperties : NodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// emissiveNode: Node | null;
        /// </summary>
        Node? EmissiveNode { get; set; }
        /// <summary>
        /// metalnessNode: Node | null;
        /// </summary>
        Node? MetalnessNode { get; set; }
        /// <summary>
        /// roughnessNode: Node | null;
        /// </summary>
        Node? RoughnessNode { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
