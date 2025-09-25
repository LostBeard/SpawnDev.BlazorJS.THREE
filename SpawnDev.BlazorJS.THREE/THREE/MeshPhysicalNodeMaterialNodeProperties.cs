
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshPhysicalNodeMaterialNodeProperties : MeshStandardNodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// anisotropyNode: Node | null;
        /// </summary>
        Node? AnisotropyNode { get; set; }
        /// <summary>
        /// attenuationColorNode: Node | null;
        /// </summary>
        Node? AttenuationColorNode { get; set; }
        /// <summary>
        /// attenuationDistanceNode: Node | null;
        /// </summary>
        Node? AttenuationDistanceNode { get; set; }
        /// <summary>
        /// clearcoatNode: Node | null;
        /// </summary>
        Node? ClearcoatNode { get; set; }
        /// <summary>
        /// clearcoatNormalNode: Node | null;
        /// </summary>
        Node? ClearcoatNormalNode { get; set; }
        /// <summary>
        /// clearcoatRoughnessNode: Node | null;
        /// </summary>
        Node? ClearcoatRoughnessNode { get; set; }
        /// <summary>
        /// dispersionNode: Node | null;
        /// </summary>
        Node? DispersionNode { get; set; }
        /// <summary>
        /// iorNode: Node | null;
        /// </summary>
        Node? IorNode { get; set; }
        /// <summary>
        /// iridescenceIORNode: Node | null;
        /// </summary>
        Node? IridescenceIORNode { get; set; }
        /// <summary>
        /// iridescenceNode: Node | null;
        /// </summary>
        Node? IridescenceNode { get; set; }
        /// <summary>
        /// iridescenceThicknessNode: Node | null;
        /// </summary>
        Node? IridescenceThicknessNode { get; set; }
        /// <summary>
        /// sheenNode: Node | null;
        /// </summary>
        Node? SheenNode { get; set; }
        /// <summary>
        /// sheenRoughnessNode: Node | null;
        /// </summary>
        Node? SheenRoughnessNode { get; set; }
        /// <summary>
        /// specularColorNode: Node | null;
        /// </summary>
        Node? SpecularColorNode { get; set; }
        /// <summary>
        /// specularIntensityNode: Node | null;
        /// </summary>
        Node? SpecularIntensityNode { get; set; }
        /// <summary>
        /// thicknessNode: Node | null;
        /// </summary>
        Node? ThicknessNode { get; set; }
        /// <summary>
        /// transmissionNode: Node | null;
        /// </summary>
        Node? TransmissionNode { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
