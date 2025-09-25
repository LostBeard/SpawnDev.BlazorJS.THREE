
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ShaderStageNodeData
    {
        #region Properties
        /// <summary>
        /// properties?:
                ///         | (
                ///             & {
                ///                 outputNode: Node | null;
                ///                 initialized?: boolean | undefined;
                ///             }
                ///             & {
                ///                 [K in
        /// </summary>
        object? Properties { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
