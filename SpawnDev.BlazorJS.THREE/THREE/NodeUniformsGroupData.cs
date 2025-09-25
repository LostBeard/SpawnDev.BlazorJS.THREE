
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface NodeUniformsGroupData
    {
        #region Properties
        /// <summary>
        /// frameId?: number | undefined;
        /// </summary>
        float? FrameId { get; set; }
        /// <summary>
        /// renderId?: number | undefined;
        /// </summary>
        float? RenderId { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
