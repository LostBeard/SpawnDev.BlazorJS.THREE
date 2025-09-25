
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshDepthMaterialProperties : MaterialProperties
    {
        #region Properties
        /// <summary>
        /// alphaMap: Texture | null;
        /// </summary>
        Texture? AlphaMap { get; set; }
        /// <summary>
        /// depthPacking: DepthPackingStrategies;
        /// </summary>
        DepthPackingStrategies? DepthPacking { get; set; }
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
        /// map: Texture | null;
        /// </summary>
        Texture? Map { get; set; }
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
