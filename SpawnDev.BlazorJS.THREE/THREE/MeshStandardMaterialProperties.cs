
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshStandardMaterialProperties : MaterialProperties
    {
        #region Properties
        /// <summary>
        /// alphaMap: Texture | null;
        /// </summary>
        Texture? AlphaMap { get; set; }
        /// <summary>
        /// aoMap: Texture | null;
        /// </summary>
        Texture? AoMap { get; set; }
        /// <summary>
        /// aoMapIntensity: number;
        /// </summary>
        float? AoMapIntensity { get; set; }
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
        /// emissive: Color;
        /// </summary>
        Color? Emissive { get; set; }
        /// <summary>
        /// emissiveIntensity: number;
        /// </summary>
        float? EmissiveIntensity { get; set; }
        /// <summary>
        /// emissiveMap: Texture | null;
        /// </summary>
        Texture? EmissiveMap { get; set; }
        /// <summary>
        /// envMap: Texture | null;
        /// </summary>
        Texture? EnvMap { get; set; }
        /// <summary>
        /// envMapIntensity: number;
        /// </summary>
        float? EnvMapIntensity { get; set; }
        /// <summary>
        /// envMapRotation: Euler;
        /// </summary>
        Euler? EnvMapRotation { get; set; }
        /// <summary>
        /// flatShading: boolean;
        /// </summary>
        bool? FlatShading { get; set; }
        /// <summary>
        /// fog: boolean;
        /// </summary>
        bool? Fog { get; set; }
        /// <summary>
        /// lightMap: Texture | null;
        /// </summary>
        Texture? LightMap { get; set; }
        /// <summary>
        /// lightMapIntensity: number;
        /// </summary>
        float? LightMapIntensity { get; set; }
        /// <summary>
        /// map: Texture | null;
        /// </summary>
        Texture? Map { get; set; }
        /// <summary>
        /// metalness: number;
        /// </summary>
        float? Metalness { get; set; }
        /// <summary>
        /// metalnessMap: Texture | null;
        /// </summary>
        Texture? MetalnessMap { get; set; }
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
        /// roughness: number;
        /// </summary>
        float? Roughness { get; set; }
        /// <summary>
        /// roughnessMap: Texture | null;
        /// </summary>
        Texture? RoughnessMap { get; set; }
        /// <summary>
        /// wireframe: boolean;
        /// </summary>
        bool? Wireframe { get; set; }
        /// <summary>
        /// wireframeLinecap: "round" | "bevel" | "miter";
        /// </summary>
        string? WireframeLinecap { get; set; }
        /// <summary>
        /// wireframeLinejoin: "round" | "bevel" | "miter";
        /// </summary>
        string? WireframeLinejoin { get; set; }
        /// <summary>
        /// wireframeLinewidth: number;
        /// </summary>
        float? WireframeLinewidth { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
