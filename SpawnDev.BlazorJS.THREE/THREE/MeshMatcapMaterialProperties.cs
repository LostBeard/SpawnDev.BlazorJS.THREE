
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshMatcapMaterialProperties : MaterialProperties
    {
        #region Properties
        /// <summary>
        /// alphaMap: Texture | null;
        /// </summary>
        Texture? AlphaMap { get; set; }
        /// <summary>
        /// bumpMap: Texture | null;
        /// </summary>
        Texture? BumpMap { get; set; }
        /// <summary>
        /// bumpScale: number;
        /// </summary>
        float? BumpScale { get; set; }
        /// <summary>
        /// color: Color;
        /// </summary>
        Color? Color { get; set; }
        /// <summary>
        /// displacementBias: number;
        /// </summary>
        float? DisplacementBias { get; set; }
        /// <summary>
        /// displacementMap: Texture | null;
        /// </summary>
        Texture? DisplacementMap { get; set; }
        /// <summary>
        /// displacementScale: number;
        /// </summary>
        float? DisplacementScale { get; set; }
        /// <summary>
        /// flatShading: boolean;
        /// </summary>
        bool? FlatShading { get; set; }
        /// <summary>
        /// fog: boolean;
        /// </summary>
        bool? Fog { get; set; }
        /// <summary>
        /// map: Texture | null;
        /// </summary>
        Texture? Map { get; set; }
        /// <summary>
        /// matcap: Texture | null;
        /// </summary>
        Texture? Matcap { get; set; }
        /// <summary>
        /// normalMap: Texture | null;
        /// </summary>
        Texture? NormalMap { get; set; }
        /// <summary>
        /// normalMapType: NormalMapTypes;
        /// </summary>
        NormalMapTypes? NormalMapType { get; set; }
        /// <summary>
        /// normalScale: Vector2;
        /// </summary>
        Vector2? NormalScale { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
