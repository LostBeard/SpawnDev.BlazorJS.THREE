
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface NodeChild
    {
        #region Properties
        /// <summary>
        /// childNode: Node;
        /// </summary>
        Node? ChildNode { get; set; }
        /// <summary>
        /// index?: number | string;
        /// </summary>
        Union<float, string>? Index { get; set; }
        /// <summary>
        /// property: string;
        /// </summary>
        string? Property { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
