
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LoopNodeObjectParameter
    {
        #region Properties
        /// <summary>
        /// condition?: string;
        /// </summary>
        string? Condition { get; set; }
        /// <summary>
        /// end: number | Node;
        /// </summary>
        Union<float, Node>? End { get; set; }
        /// <summary>
        /// start: number | Node;
        /// </summary>
        Union<float, Node>? Start { get; set; }
        /// <summary>
        /// type?: "int" | "uint" | "float";
        /// </summary>
        string? Type { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
