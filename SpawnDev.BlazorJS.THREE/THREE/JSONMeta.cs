
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface JSONMeta
    {
        #region Properties
        /// <summary>
        /// animations: Record<string, AnimationClipJSON>;
        /// </summary>
        Record<string, AnimationClipJSON>? Animations { get; set; }
        /// <summary>
        /// geometries: Record<string, BufferGeometryJSON>;
        /// </summary>
        Record<string, BufferGeometryJSON>? Geometries { get; set; }
        /// <summary>
        /// images: Record<string, SourceJSON>;
        /// </summary>
        Record<string, SourceJSON>? Images { get; set; }
        /// <summary>
        /// materials: Record<string, MaterialJSON>;
        /// </summary>
        Record<string, MaterialJSON>? Materials { get; set; }
        /// <summary>
        /// nodes: Record<string, object>;
        /// </summary>
        Record<string, object>? Nodes { get; set; }
        /// <summary>
        /// shapes: Record<string, ShapeJSON>;
        /// </summary>
        Record<string, ShapeJSON>? Shapes { get; set; }
        /// <summary>
        /// skeletons: Record<string, SkeletonJSON>;
        /// </summary>
        Record<string, SkeletonJSON>? Skeletons { get; set; }
        /// <summary>
        /// textures: Record<string, TextureJSON>;
        /// </summary>
        Record<string, TextureJSON>? Textures { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
