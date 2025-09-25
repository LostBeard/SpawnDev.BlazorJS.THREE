
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshPhysicalMaterialProperties : MeshStandardMaterialProperties
    {
        #region Properties
        /// <summary>
        /// anisotropyMap: Texture | null;
        /// </summary>
        Texture? AnisotropyMap { get; set; }
        /// <summary>
        /// anisotropyRotation: number;
        /// </summary>
        float? AnisotropyRotation { get; set; }
        /// <summary>
        /// clearcoatMap: Texture | null;
        /// </summary>
        Texture? ClearcoatMap { get; set; }
        /// <summary>
        /// clearcoatNormalMap: Texture | null;
        /// </summary>
        Texture? ClearcoatNormalMap { get; set; }
        /// <summary>
        /// clearcoatNormalScale: Vector2;
        /// </summary>
        Vector2? ClearcoatNormalScale { get; set; }
        /// <summary>
        /// clearcoatRoughness: number;
        /// </summary>
        float? ClearcoatRoughness { get; set; }
        /// <summary>
        /// clearcoatRoughnessMap: Texture | null;
        /// </summary>
        Texture? ClearcoatRoughnessMap { get; set; }
        /// <summary>
        /// ior: number;
        /// </summary>
        float? Ior { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
