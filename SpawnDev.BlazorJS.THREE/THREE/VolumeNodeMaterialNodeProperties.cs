
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface VolumeNodeMaterialNodeProperties : NodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// offsetNode: Node;
        /// </summary>
        Node? OffsetNode { get; set; }
        /// <summary>
        /// scatteringNode: (params: { positionRay: ShaderNodeObject<Node> }) => Node | null;
        /// </summary>
        Callback? ScatteringNode { get; set; }
        /// <summary>
        /// steps: number;
        /// </summary>
        float? Steps { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
