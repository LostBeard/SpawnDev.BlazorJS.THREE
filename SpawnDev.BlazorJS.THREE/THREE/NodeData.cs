
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface NodeData
    {
        #region Properties
        /// <summary>
        /// any?: ShaderStageNodeData | undefined;
        /// </summary>
        ShaderStageNodeData? Any { get; set; }
        /// <summary>
        /// compute?: ShaderStageNodeData | undefined;
        /// </summary>
        ShaderStageNodeData? Compute { get; set; }
        /// <summary>
        /// fragment?: ShaderStageNodeData | undefined;
        /// </summary>
        ShaderStageNodeData? Fragment { get; set; }
        /// <summary>
        /// vertex?: ShaderStageNodeData | undefined;
        /// </summary>
        ShaderStageNodeData? Vertex { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
