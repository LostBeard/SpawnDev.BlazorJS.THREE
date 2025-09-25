
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ComputeNodeData
    {
        #region Properties
        /// <summary>
        /// pipeline: ComputePipeline;
        /// </summary>
        ComputePipeline? Pipeline { get; set; }
        /// <summary>
        /// version: number;
        /// </summary>
        float? Version { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
