
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface NodeJSONIntermediateOutputData
    {
        #region Properties
        /// <summary>
        /// images?: object[];
        /// </summary>
        Array<object>? Images { get; set; }
        /// <summary>
        /// inputNodes?: NodeJSONInputNodes | undefined;
        /// </summary>
        NodeJSONInputNodes? InputNodes { get; set; }
        /// <summary>
        /// meta?: NodeJSONMeta | undefined;
        /// </summary>
        NodeJSONMeta? Meta { get; set; }
        /// <summary>
        /// metadata?: NodeJSONMetadata;
        /// </summary>
        NodeJSONMetadata? Metadata { get; set; }
        /// <summary>
        /// nodes?: NodeJSONIntermediateOutputData[];
        /// </summary>
        Array<NodeJSONIntermediateOutputData>? Nodes { get; set; }
        /// <summary>
        /// textures?: object[];
        /// </summary>
        Array<object>? Textures { get; set; }
        /// <summary>
        /// type: string | undefined;
        /// </summary>
        string? Type { get; set; }
        /// <summary>
        /// uuid: string;
        /// </summary>
        string? Uuid { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
