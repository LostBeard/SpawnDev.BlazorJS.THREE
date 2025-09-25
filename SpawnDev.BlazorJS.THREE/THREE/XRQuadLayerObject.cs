
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface XRQuadLayerObject
    {
        #region Properties
        /// <summary>
        /// height: number;
        /// </summary>
        float? Height { get; set; }
        /// <summary>
        /// material: Material;
        /// </summary>
        Material? Material { get; set; }
        /// <summary>
        /// pixelheight: number;
        /// </summary>
        float? Pixelheight { get; set; }
        /// <summary>
        /// pixelwidth: number;
        /// </summary>
        float? Pixelwidth { get; set; }
        /// <summary>
        /// plane: Mesh;
        /// </summary>
        Mesh? Plane { get; set; }
        /// <summary>
        /// quaternion: Quaternion;
        /// </summary>
        Quaternion? Quaternion { get; set; }
        /// <summary>
        /// rendercall: () => void;
        /// </summary>
        Callback? Rendercall { get; set; }
        /// <summary>
        /// renderTarget: XRRenderTarget;
        /// </summary>
        XRRenderTarget? RenderTarget { get; set; }
        /// <summary>
        /// translation: Vector3;
        /// </summary>
        Vector3? Translation { get; set; }
        /// <summary>
        /// type: "quad";
        /// </summary>
        string? Type { get; set; }
        /// <summary>
        /// width: number;
        /// </summary>
        float? Width { get; set; }
        /// <summary>
        /// xrlayer?: XRLayer;
        /// </summary>
        XRLayer? Xrlayer { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
