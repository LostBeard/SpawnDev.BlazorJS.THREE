
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface NodeJSONMeta
    {
        #region Properties
        /// <summary>
        /// images: {
                ///         [key: string]: object;
                ///     };
        /// </summary>
        object? Images { get; set; }
        /// <summary>
        /// nodes: {
                ///         [key: string]: NodeJSONIntermediateOutputData;
                ///     };
        /// </summary>
        object? Nodes { get; set; }
        /// <summary>
        /// textures: {
                ///         [key: string]: object;
                ///     };
        /// </summary>
        object? Textures { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
