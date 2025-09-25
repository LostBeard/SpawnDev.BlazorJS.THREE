
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface BatchedMeshGeometryRange
    {
        #region Properties
        /// <summary>
        /// count: number;
        /// </summary>
        float? Count { get; set; }
        /// <summary>
        /// indexCount: number;
        /// </summary>
        float? IndexCount { get; set; }
        /// <summary>
        /// indexStart: number;
        /// </summary>
        float? IndexStart { get; set; }
        /// <summary>
        /// reservedIndexCount: number;
        /// </summary>
        float? ReservedIndexCount { get; set; }
        /// <summary>
        /// reservedVertexCount: number;
        /// </summary>
        float? ReservedVertexCount { get; set; }
        /// <summary>
        /// start: number;
        /// </summary>
        float? Start { get; set; }
        /// <summary>
        /// vertexCount: number;
        /// </summary>
        float? VertexCount { get; set; }
        /// <summary>
        /// vertexStart: number;
        /// </summary>
        float? VertexStart { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
