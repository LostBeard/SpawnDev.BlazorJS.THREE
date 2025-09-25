
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshNormalMaterialProperties : MaterialProperties
    {
        #region Properties
        /// <summary>
        /// bumpMap: Texture | null;
        /// </summary>
        Texture? BumpMap { get; set; }
        /// <summary>
        /// bumpScale: number;
        /// </summary>
        float? BumpScale { get; set; }
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
        /// <summary>
        /// wireframe: boolean;
        /// </summary>
        bool? Wireframe { get; set; }
        /// <summary>
        /// wireframeLinewidth: number;
        /// </summary>
        float? WireframeLinewidth { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
