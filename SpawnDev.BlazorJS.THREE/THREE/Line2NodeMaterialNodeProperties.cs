
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Line2NodeMaterialNodeProperties : NodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// dashOffset: number;
        /// </summary>
        float? DashOffset { get; set; }
        /// <summary>
        /// dashScaleNode: Node | null;
        /// </summary>
        Node? DashScaleNode { get; set; }
        /// <summary>
        /// dashSizeNode: Node | null;
        /// </summary>
        Node? DashSizeNode { get; set; }
        /// <summary>
        /// gapSizeNode: Node | null;
        /// </summary>
        Node? GapSizeNode { get; set; }
        /// <summary>
        /// lineColorNode: Node | null;
        /// </summary>
        Node? LineColorNode { get; set; }
        /// <summary>
        /// offsetNode: Node | null;
        /// </summary>
        Node? OffsetNode { get; set; }
        /// <summary>
        /// useColor: boolean;
        /// </summary>
        bool? UseColor { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
