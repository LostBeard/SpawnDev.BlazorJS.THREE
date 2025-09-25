
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebGLProgramParameters
    {
        #region Properties
        /// <summary>
        /// alphaHash: boolean;
        /// </summary>
        bool? AlphaHash { get; set; }
        /// <summary>
        /// alphaMap: boolean;
        /// </summary>
        bool? AlphaMap { get; set; }
        /// <summary>
        /// alphaMapUv: string | false;
        /// </summary>
        Union<string, bool>? AlphaMapUv { get; set; }
        /// <summary>
        /// alphaTest: boolean;
        /// </summary>
        bool? AlphaTest { get; set; }
        /// <summary>
        /// alphaToCoverage: boolean;
        /// </summary>
        bool? AlphaToCoverage { get; set; }
        /// <summary>
        /// anisotropy: boolean;
        /// </summary>
        bool? Anisotropy { get; set; }
        /// <summary>
        /// anisotropyMap: boolean;
        /// </summary>
        bool? AnisotropyMap { get; set; }
        /// <summary>
        /// anisotropyMapUv: string | false;
        /// </summary>
        Union<string, bool>? AnisotropyMapUv { get; set; }
        /// <summary>
        /// aoMap: boolean;
        /// </summary>
        bool? AoMap { get; set; }
        /// <summary>
        /// aoMapUv: string | false;
        /// </summary>
        Union<string, bool>? AoMapUv { get; set; }
        /// <summary>
        /// batching: boolean;
        /// </summary>
        bool? Batching { get; set; }
        /// <summary>
        /// batchingColor: boolean;
        /// </summary>
        bool? BatchingColor { get; set; }
        /// <summary>
        /// bumpMap: boolean;
        /// </summary>
        bool? BumpMap { get; set; }
        /// <summary>
        /// bumpMapUv: string | false;
        /// </summary>
        Union<string, bool>? BumpMapUv { get; set; }
        /// <summary>
        /// clearcoat: boolean;
        /// </summary>
        bool? Clearcoat { get; set; }
        /// <summary>
        /// clearcoatMap: boolean;
        /// </summary>
        bool? ClearcoatMap { get; set; }
        /// <summary>
        /// clearcoatMapUv: string | false;
        /// </summary>
        Union<string, bool>? ClearcoatMapUv { get; set; }
        /// <summary>
        /// clearcoatNormalMap: boolean;
        /// </summary>
        bool? ClearcoatNormalMap { get; set; }
        /// <summary>
        /// clearcoatNormalMapUv: string | false;
        /// </summary>
        Union<string, bool>? ClearcoatNormalMapUv { get; set; }
        /// <summary>
        /// clearcoatRoughnessMap: boolean;
        /// </summary>
        bool? ClearcoatRoughnessMap { get; set; }
        /// <summary>
        /// clearcoatRoughnessMapUv: string | false;
        /// </summary>
        Union<string, bool>? ClearcoatRoughnessMapUv { get; set; }
        /// <summary>
        /// combine: Combine | undefined;
        /// </summary>
        Combine? Combine { get; set; }
        /// <summary>
        /// customFragmentShaderID: string | undefined;
        /// </summary>
        string? CustomFragmentShaderID { get; set; }
        /// <summary>
        /// customProgramCacheKey: string;
        /// </summary>
        string? CustomProgramCacheKey { get; set; }
        /// <summary>
        /// customVertexShaderID: string | undefined;
        /// </summary>
        string? CustomVertexShaderID { get; set; }
        /// <summary>
        /// decodeVideoTexture: boolean;
        /// </summary>
        bool? DecodeVideoTexture { get; set; }
        /// <summary>
        /// decodeVideoTextureEmissive: boolean;
        /// </summary>
        bool? DecodeVideoTextureEmissive { get; set; }
        /// <summary>
        /// defines: { [define: string]: string | number | boolean } | undefined;
        /// </summary>
        object? Defines { get; set; }
        /// <summary>
        /// depthPacking: DepthPackingStrategies | 0;
        /// </summary>
        Union<DepthPackingStrategies, float>? DepthPacking { get; set; }
        /// <summary>
        /// dispersion: boolean;
        /// </summary>
        bool? Dispersion { get; set; }
        /// <summary>
        /// displacementMap: boolean;
        /// </summary>
        bool? DisplacementMap { get; set; }
        /// <summary>
        /// displacementMapUv: string | false;
        /// </summary>
        Union<string, bool>? DisplacementMapUv { get; set; }
        /// <summary>
        /// dithering: boolean;
        /// </summary>
        bool? Dithering { get; set; }
        /// <summary>
        /// doubleSided: boolean;
        /// </summary>
        bool? DoubleSided { get; set; }
        /// <summary>
        /// emissiveMap: boolean;
        /// </summary>
        bool? EmissiveMap { get; set; }
        /// <summary>
        /// emissiveMapUv: string | false;
        /// </summary>
        Union<string, bool>? EmissiveMapUv { get; set; }
        /// <summary>
        /// envMap: boolean;
        /// </summary>
        bool? EnvMap { get; set; }
        /// <summary>
        /// envMapCubeUVHeight: number | null;
        /// </summary>
        float? EnvMapCubeUVHeight { get; set; }
        /// <summary>
        /// envMapMode: Mapping | false;
        /// </summary>
        Union<Mapping, bool>? EnvMapMode { get; set; }
        /// <summary>
        /// extensionClipCullDistance: boolean;
        /// </summary>
        bool? ExtensionClipCullDistance { get; set; }
        /// <summary>
        /// extensionMultiDraw: boolean;
        /// </summary>
        bool? ExtensionMultiDraw { get; set; }
        /// <summary>
        /// flatShading: boolean;
        /// </summary>
        bool? FlatShading { get; set; }
        /// <summary>
        /// flipSided: boolean;
        /// </summary>
        bool? FlipSided { get; set; }
        /// <summary>
        /// fog: boolean;
        /// </summary>
        bool? Fog { get; set; }
        /// <summary>
        /// fogExp2: boolean;
        /// </summary>
        bool? FogExp2 { get; set; }
        /// <summary>
        /// fragmentShader: string;
        /// </summary>
        string? FragmentShader { get; set; }
        /// <summary>
        /// glslVersion: GLSLVersion | null | undefined;
        /// </summary>
        GLSLVersion? GlslVersion { get; set; }
        /// <summary>
        /// gradientMap: boolean;
        /// </summary>
        bool? GradientMap { get; set; }
        /// <summary>
        /// index0AttributeName: string | undefined;
        /// </summary>
        string? Index0AttributeName { get; set; }
        /// <summary>
        /// instancing: boolean;
        /// </summary>
        bool? Instancing { get; set; }
        /// <summary>
        /// instancingColor: boolean;
        /// </summary>
        bool? InstancingColor { get; set; }
        /// <summary>
        /// instancingMorph: boolean;
        /// </summary>
        bool? InstancingMorph { get; set; }
        /// <summary>
        /// iridescence: boolean;
        /// </summary>
        bool? Iridescence { get; set; }
        /// <summary>
        /// iridescenceMap: boolean;
        /// </summary>
        bool? IridescenceMap { get; set; }
        /// <summary>
        /// iridescenceMapUv: string | false;
        /// </summary>
        Union<string, bool>? IridescenceMapUv { get; set; }
        /// <summary>
        /// iridescenceThicknessMap: boolean;
        /// </summary>
        bool? IridescenceThicknessMap { get; set; }
        /// <summary>
        /// iridescenceThicknessMapUv: string | false;
        /// </summary>
        Union<string, bool>? IridescenceThicknessMapUv { get; set; }
        /// <summary>
        /// isRawShaderMaterial: boolean;
        /// </summary>
        bool? IsRawShaderMaterial { get; set; }
        /// <summary>
        /// lightMap: boolean;
        /// </summary>
        bool? LightMap { get; set; }
        /// <summary>
        /// lightMapUv: string | false;
        /// </summary>
        Union<string, bool>? LightMapUv { get; set; }
        /// <summary>
        /// logarithmicDepthBuffer: boolean;
        /// </summary>
        bool? LogarithmicDepthBuffer { get; set; }
        /// <summary>
        /// map: boolean;
        /// </summary>
        bool? Map { get; set; }
        /// <summary>
        /// mapUv: string | false;
        /// </summary>
        Union<string, bool>? MapUv { get; set; }
        /// <summary>
        /// matcap: boolean;
        /// </summary>
        bool? Matcap { get; set; }
        /// <summary>
        /// metalnessMap: boolean;
        /// </summary>
        bool? MetalnessMap { get; set; }
        /// <summary>
        /// metalnessMapUv: string | false;
        /// </summary>
        Union<string, bool>? MetalnessMapUv { get; set; }
        /// <summary>
        /// morphColors: boolean;
        /// </summary>
        bool? MorphColors { get; set; }
        /// <summary>
        /// morphNormals: boolean;
        /// </summary>
        bool? MorphNormals { get; set; }
        /// <summary>
        /// morphTargets: boolean;
        /// </summary>
        bool? MorphTargets { get; set; }
        /// <summary>
        /// morphTargetsCount: number;
        /// </summary>
        float? MorphTargetsCount { get; set; }
        /// <summary>
        /// morphTextureStride: number;
        /// </summary>
        float? MorphTextureStride { get; set; }
        /// <summary>
        /// normalMap: boolean;
        /// </summary>
        bool? NormalMap { get; set; }
        /// <summary>
        /// normalMapObjectSpace: boolean;
        /// </summary>
        bool? NormalMapObjectSpace { get; set; }
        /// <summary>
        /// normalMapTangentSpace: boolean;
        /// </summary>
        bool? NormalMapTangentSpace { get; set; }
        /// <summary>
        /// normalMapUv: string | false;
        /// </summary>
        Union<string, bool>? NormalMapUv { get; set; }
        /// <summary>
        /// numClipIntersection: number;
        /// </summary>
        float? NumClipIntersection { get; set; }
        /// <summary>
        /// numClippingPlanes: number;
        /// </summary>
        float? NumClippingPlanes { get; set; }
        /// <summary>
        /// numDirLights: number;
        /// </summary>
        float? NumDirLights { get; set; }
        /// <summary>
        /// numDirLightShadows: number;
        /// </summary>
        float? NumDirLightShadows { get; set; }
        /// <summary>
        /// numHemiLights: number;
        /// </summary>
        float? NumHemiLights { get; set; }
        /// <summary>
        /// numLightProbes: number;
        /// </summary>
        float? NumLightProbes { get; set; }
        /// <summary>
        /// numPointLights: number;
        /// </summary>
        float? NumPointLights { get; set; }
        /// <summary>
        /// numPointLightShadows: number;
        /// </summary>
        float? NumPointLightShadows { get; set; }
        /// <summary>
        /// numRectAreaLights: number;
        /// </summary>
        float? NumRectAreaLights { get; set; }
        /// <summary>
        /// numSpotLightMaps: number;
        /// </summary>
        float? NumSpotLightMaps { get; set; }
        /// <summary>
        /// numSpotLights: number;
        /// </summary>
        float? NumSpotLights { get; set; }
        /// <summary>
        /// numSpotLightShadows: number;
        /// </summary>
        float? NumSpotLightShadows { get; set; }
        /// <summary>
        /// numSpotLightShadowsWithMaps: number;
        /// </summary>
        float? NumSpotLightShadowsWithMaps { get; set; }
        /// <summary>
        /// opaque: boolean;
        /// </summary>
        bool? Opaque { get; set; }
        /// <summary>
        /// outputColorSpace: string;
        /// </summary>
        string? OutputColorSpace { get; set; }
        /// <summary>
        /// pointsUvs: boolean;
        /// </summary>
        bool? PointsUvs { get; set; }
        /// <summary>
        /// precision: "lowp" | "mediump" | "highp";
        /// </summary>
        string? Precision { get; set; }
        /// <summary>
        /// premultipliedAlpha: boolean;
        /// </summary>
        bool? PremultipliedAlpha { get; set; }
        /// <summary>
        /// rendererExtensionParallelShaderCompile: boolean;
        /// </summary>
        bool? RendererExtensionParallelShaderCompile { get; set; }
        /// <summary>
        /// reverseDepthBuffer: boolean;
        /// </summary>
        bool? ReverseDepthBuffer { get; set; }
        /// <summary>
        /// roughnessMap: boolean;
        /// </summary>
        bool? RoughnessMap { get; set; }
        /// <summary>
        /// roughnessMapUv: string | false;
        /// </summary>
        Union<string, bool>? RoughnessMapUv { get; set; }
        /// <summary>
        /// shaderID: string;
        /// </summary>
        string? ShaderID { get; set; }
        /// <summary>
        /// shaderName: string;
        /// </summary>
        string? ShaderName { get; set; }
        /// <summary>
        /// shaderType: string;
        /// </summary>
        string? ShaderType { get; set; }
        /// <summary>
        /// shadowMapEnabled: boolean;
        /// </summary>
        bool? ShadowMapEnabled { get; set; }
        /// <summary>
        /// shadowMapType: ShadowMapType;
        /// </summary>
        ShadowMapType? ShadowMapType { get; set; }
        /// <summary>
        /// sheen: boolean;
        /// </summary>
        bool? Sheen { get; set; }
        /// <summary>
        /// sheenColorMap: boolean;
        /// </summary>
        bool? SheenColorMap { get; set; }
        /// <summary>
        /// sheenColorMapUv: string | false;
        /// </summary>
        Union<string, bool>? SheenColorMapUv { get; set; }
        /// <summary>
        /// sheenRoughnessMap: boolean;
        /// </summary>
        bool? SheenRoughnessMap { get; set; }
        /// <summary>
        /// sheenRoughnessMapUv: string | false;
        /// </summary>
        Union<string, bool>? SheenRoughnessMapUv { get; set; }
        /// <summary>
        /// sizeAttenuation: boolean;
        /// </summary>
        bool? SizeAttenuation { get; set; }
        /// <summary>
        /// skinning: boolean;
        /// </summary>
        bool? Skinning { get; set; }
        /// <summary>
        /// specularColorMap: boolean;
        /// </summary>
        bool? SpecularColorMap { get; set; }
        /// <summary>
        /// specularColorMapUv: string | false;
        /// </summary>
        Union<string, bool>? SpecularColorMapUv { get; set; }
        /// <summary>
        /// specularIntensityMap: boolean;
        /// </summary>
        bool? SpecularIntensityMap { get; set; }
        /// <summary>
        /// specularIntensityMapUv: string | false;
        /// </summary>
        Union<string, bool>? SpecularIntensityMapUv { get; set; }
        /// <summary>
        /// specularMap: boolean;
        /// </summary>
        bool? SpecularMap { get; set; }
        /// <summary>
        /// specularMapUv: string | false;
        /// </summary>
        Union<string, bool>? SpecularMapUv { get; set; }
        /// <summary>
        /// supportsVertexTextures: boolean;
        /// </summary>
        bool? SupportsVertexTextures { get; set; }
        /// <summary>
        /// thicknessMap: boolean;
        /// </summary>
        bool? ThicknessMap { get; set; }
        /// <summary>
        /// thicknessMapUv: string | false;
        /// </summary>
        Union<string, bool>? ThicknessMapUv { get; set; }
        /// <summary>
        /// toneMapping: ToneMapping;
        /// </summary>
        ToneMapping? ToneMapping { get; set; }
        /// <summary>
        /// transmission: boolean;
        /// </summary>
        bool? Transmission { get; set; }
        /// <summary>
        /// transmissionMap: boolean;
        /// </summary>
        bool? TransmissionMap { get; set; }
        /// <summary>
        /// transmissionMapUv: string | false;
        /// </summary>
        Union<string, bool>? TransmissionMapUv { get; set; }
        /// <summary>
        /// useDepthPacking: boolean;
        /// </summary>
        bool? UseDepthPacking { get; set; }
        /// <summary>
        /// useFog: boolean;
        /// </summary>
        bool? UseFog { get; set; }
        /// <summary>
        /// vertexAlphas: boolean;
        /// </summary>
        bool? VertexAlphas { get; set; }
        /// <summary>
        /// vertexColors: boolean;
        /// </summary>
        bool? VertexColors { get; set; }
        /// <summary>
        /// vertexShader: string;
        /// </summary>
        string? VertexShader { get; set; }
        /// <summary>
        /// vertexTangents: boolean;
        /// </summary>
        bool? VertexTangents { get; set; }
        /// <summary>
        /// vertexUv1s: boolean;
        /// </summary>
        bool? VertexUv1s { get; set; }
        /// <summary>
        /// vertexUv2s: boolean;
        /// </summary>
        bool? VertexUv2s { get; set; }
        /// <summary>
        /// vertexUv3s: boolean;
        /// </summary>
        bool? VertexUv3s { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
