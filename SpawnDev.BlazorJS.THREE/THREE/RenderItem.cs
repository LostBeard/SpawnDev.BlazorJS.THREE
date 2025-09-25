
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface RenderItem
    {
        #region Properties
        /// <summary>
        /// clippingContext: ClippingContext | null;
        /// </summary>
        ClippingContext? ClippingContext { get; set; }
        /// <summary>
        /// geometry: BufferGeometry | null;
        /// </summary>
        BufferGeometry? Geometry { get; set; }
        /// <summary>
        /// group: GeometryGroup | null;
        /// </summary>
        GeometryGroup? Group { get; set; }
        /// <summary>
        /// groupOrder: number | null;
        /// </summary>
        float? GroupOrder { get; set; }
        /// <summary>
        /// id: number | null;
        /// </summary>
        float? Id { get; set; }
        /// <summary>
        /// material: Material | null;
        /// </summary>
        Material? Material { get; set; }
        /// <summary>
        /// object: Object3D | null;
        /// </summary>
        Object3D? Object { get; set; }
        /// <summary>
        /// renderOrder: number | null;
        /// </summary>
        float? RenderOrder { get; set; }
        /// <summary>
        /// z: number | null;
        /// </summary>
        float? Z { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
