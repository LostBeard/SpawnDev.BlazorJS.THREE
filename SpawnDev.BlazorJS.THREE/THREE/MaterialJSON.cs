
//using System.Text;
//using Microsoft.JSInterop;
//using SpawnDev.BlazorJS;
//using SpawnDev.BlazorJS.JSObjects;

//namespace SpawnDev.BlazorJS.THREE
//{
//    public interface MaterialJSON
//    {
//        #region Properties
//        /// <summary>
//        /// alphaHash?: boolean;
//        /// </summary>
//        bool? AlphaHash { get; set; }
//        /// <summary>
//        /// alphaMap?: string;
//        /// </summary>
//        string? AlphaMap { get; set; }
//        /// <summary>
//        /// alphaTest?: number;
//        /// </summary>
//        float? AlphaTest { get; set; }
//        /// <summary>
//        /// alphaToCoverage?: boolean;
//        /// </summary>
//        bool? AlphaToCoverage { get; set; }
//        /// <summary>
//        /// anisotropy?: number;
//        /// </summary>
//        float? Anisotropy { get; set; }
//        /// <summary>
//        /// anisotropyMap?: string;
//        /// </summary>
//        string? AnisotropyMap { get; set; }
//        /// <summary>
//        /// anisotropyRotation?: number;
//        /// </summary>
//        float? AnisotropyRotation { get; set; }
//        /// <summary>
//        /// aoMap?: string;
//        /// </summary>
//        string? AoMap { get; set; }
//        /// <summary>
//        /// aoMapIntensity?: number;
//        /// </summary>
//        float? AoMapIntensity { get; set; }
//        /// <summary>
//        /// attenuationColor?: number;
//        /// </summary>
//        float? AttenuationColor { get; set; }
//        /// <summary>
//        /// attenuationDistance?: number;
//        /// </summary>
//        float? AttenuationDistance { get; set; }
//        /// <summary>
//        /// blendAlpha?: number;
//        /// </summary>
//        float? BlendAlpha { get; set; }
//        /// <summary>
//        /// blendColor?: number;
//        /// </summary>
//        float? BlendColor { get; set; }
//        /// <summary>
//        /// blendDst?: BlendingDstFactor;
//        /// </summary>
//        BlendingDstFactor? BlendDst { get; set; }
//        /// <summary>
//        /// blendDstAlpha?: number | null;
//        /// </summary>
//        float? BlendDstAlpha { get; set; }
//        /// <summary>
//        /// blendEquation?: BlendingEquation;
//        /// </summary>
//        BlendingEquation? BlendEquation { get; set; }
//        /// <summary>
//        /// blendEquationAlpha?: number | null;
//        /// </summary>
//        float? BlendEquationAlpha { get; set; }
//        /// <summary>
//        /// blending?: Blending;
//        /// </summary>
//        Blending? Blending { get; set; }
//        /// <summary>
//        /// blendSrc?: BlendingSrcFactor;
//        /// </summary>
//        BlendingSrcFactor? BlendSrc { get; set; }
//        /// <summary>
//        /// blendSrcAlpha?: number | null;
//        /// </summary>
//        float? BlendSrcAlpha { get; set; }
//        /// <summary>
//        /// bumpMap?: string;
//        /// </summary>
//        string? BumpMap { get; set; }
//        /// <summary>
//        /// bumpScale?: number;
//        /// </summary>
//        float? BumpScale { get; set; }
//        /// <summary>
//        /// clearcoat?: number;
//        /// </summary>
//        float? Clearcoat { get; set; }
//        /// <summary>
//        /// clearcoatMap?: string;
//        /// </summary>
//        string? ClearcoatMap { get; set; }
//        /// <summary>
//        /// clearcoatNormalMap?: string;
//        /// </summary>
//        string? ClearcoatNormalMap { get; set; }
//        /// <summary>
//        /// clearcoatNormalScale?: Vector2Tuple;
//        /// </summary>
//        Vector2Tuple? ClearcoatNormalScale { get; set; }
//        /// <summary>
//        /// clearcoatRoughness?: number;
//        /// </summary>
//        float? ClearcoatRoughness { get; set; }
//        /// <summary>
//        /// clearcoatRoughnessMap?: string;
//        /// </summary>
//        string? ClearcoatRoughnessMap { get; set; }
//        /// <summary>
//        /// color?: number;
//        /// </summary>
//        float? Color { get; set; }
//        /// <summary>
//        /// colorWrite?: boolean;
//        /// </summary>
//        bool? ColorWrite { get; set; }
//        /// <summary>
//        /// combine?: Combine;
//        /// </summary>
//        Combine? Combine { get; set; }
//        /// <summary>
//        /// dashSize?: number;
//        /// </summary>
//        float? DashSize { get; set; }
//        /// <summary>
//        /// depthFunc?: DepthModes;
//        /// </summary>
//        DepthModes? DepthFunc { get; set; }
//        /// <summary>
//        /// depthTest?: boolean;
//        /// </summary>
//        bool? DepthTest { get; set; }
//        /// <summary>
//        /// depthWrite?: boolean;
//        /// </summary>
//        bool? DepthWrite { get; set; }
//        /// <summary>
//        /// dispersion?: number;
//        /// </summary>
//        float? Dispersion { get; set; }
//        /// <summary>
//        /// displacementBias?: number;
//        /// </summary>
//        float? DisplacementBias { get; set; }
//        /// <summary>
//        /// displacementMap?: string;
//        /// </summary>
//        string? DisplacementMap { get; set; }
//        /// <summary>
//        /// displacementScale?: number;
//        /// </summary>
//        float? DisplacementScale { get; set; }
//        /// <summary>
//        /// dithering?: boolean;
//        /// </summary>
//        bool? Dithering { get; set; }
//        /// <summary>
//        /// emissive?: number;
//        /// </summary>
//        float? Emissive { get; set; }
//        /// <summary>
//        /// emissiveIntensity?: number;
//        /// </summary>
//        float? EmissiveIntensity { get; set; }
//        /// <summary>
//        /// emissiveMap?: string;
//        /// </summary>
//        string? EmissiveMap { get; set; }
//        /// <summary>
//        /// envMap?: string;
//        /// </summary>
//        string? EnvMap { get; set; }
//        /// <summary>
//        /// envMapIntensity?: number;
//        /// </summary>
//        float? EnvMapIntensity { get; set; }
//        /// <summary>
//        /// envMapRotation?: EulerTuple;
//        /// </summary>
//        EulerTuple? EnvMapRotation { get; set; }
//        /// <summary>
//        /// flatShading?: boolean;
//        /// </summary>
//        bool? FlatShading { get; set; }
//        /// <summary>
//        /// fog?: boolean;
//        /// </summary>
//        bool? Fog { get; set; }
//        /// <summary>
//        /// forceSinglePass?: boolean;
//        /// </summary>
//        bool? ForceSinglePass { get; set; }
//        /// <summary>
//        /// gapSize?: number;
//        /// </summary>
//        float? GapSize { get; set; }
//        /// <summary>
//        /// gradientMap?: string;
//        /// </summary>
//        string? GradientMap { get; set; }
//        /// <summary>
//        /// images?: SourceJSON[];
//        /// </summary>
//        Array<SourceJSON>? Images { get; set; }
//        /// <summary>
//        /// iridescence?: number;
//        /// </summary>
//        float? Iridescence { get; set; }
//        /// <summary>
//        /// iridescenceIOR?: number;
//        /// </summary>
//        float? IridescenceIOR { get; set; }
//        /// <summary>
//        /// iridescenceMap?: string;
//        /// </summary>
//        string? IridescenceMap { get; set; }
//        /// <summary>
//        /// iridescenceThicknessMap?: string;
//        /// </summary>
//        string? IridescenceThicknessMap { get; set; }
//        /// <summary>
//        /// iridescenceThicknessRange?: number;
//        /// </summary>
//        float? IridescenceThicknessRange { get; set; }
//        /// <summary>
//        /// lightMap?: string;
//        /// </summary>
//        string? LightMap { get; set; }
//        /// <summary>
//        /// lightMapIntensity?: number;
//        /// </summary>
//        float? LightMapIntensity { get; set; }
//        /// <summary>
//        /// linewidth?: number;
//        /// </summary>
//        float? Linewidth { get; set; }
//        /// <summary>
//        /// map?: string;
//        /// </summary>
//        string? Map { get; set; }
//        /// <summary>
//        /// matcap?: string;
//        /// </summary>
//        string? Matcap { get; set; }
//        /// <summary>
//        /// metadata: { version: number; type: string; generator: string };
//        /// </summary>
//        object? Metadata { get; set; }
//        /// <summary>
//        /// metalness?: number;
//        /// </summary>
//        float? Metalness { get; set; }
//        /// <summary>
//        /// metalnessMap?: string;
//        /// </summary>
//        string? MetalnessMap { get; set; }
//        /// <summary>
//        /// name?: string;
//        /// </summary>
//        string? Name { get; set; }
//        /// <summary>
//        /// normalMap?: string;
//        /// </summary>
//        string? NormalMap { get; set; }
//        /// <summary>
//        /// normalMapType?: NormalMapTypes;
//        /// </summary>
//        NormalMapTypes? NormalMapType { get; set; }
//        /// <summary>
//        /// normalScale?: Vector2Tuple;
//        /// </summary>
//        Vector2Tuple? NormalScale { get; set; }
//        /// <summary>
//        /// opacity?: number;
//        /// </summary>
//        float? Opacity { get; set; }
//        /// <summary>
//        /// polygonOffset?: boolean;
//        /// </summary>
//        bool? PolygonOffset { get; set; }
//        /// <summary>
//        /// polygonOffsetFactor?: number;
//        /// </summary>
//        float? PolygonOffsetFactor { get; set; }
//        /// <summary>
//        /// polygonOffsetUnits?: number;
//        /// </summary>
//        float? PolygonOffsetUnits { get; set; }
//        /// <summary>
//        /// premultipliedAlpha?: boolean;
//        /// </summary>
//        bool? PremultipliedAlpha { get; set; }
//        /// <summary>
//        /// reflectivity?: number;
//        /// </summary>
//        float? Reflectivity { get; set; }
//        /// <summary>
//        /// refractionRatio?: number;
//        /// </summary>
//        float? RefractionRatio { get; set; }
//        /// <summary>
//        /// rotation?: number;
//        /// </summary>
//        float? Rotation { get; set; }
//        /// <summary>
//        /// roughness?: number;
//        /// </summary>
//        float? Roughness { get; set; }
//        /// <summary>
//        /// roughnessMap?: string;
//        /// </summary>
//        string? RoughnessMap { get; set; }
//        /// <summary>
//        /// scale?: number;
//        /// </summary>
//        float? Scale { get; set; }
//        /// <summary>
//        /// shadowSide?: number;
//        /// </summary>
//        float? ShadowSide { get; set; }
//        /// <summary>
//        /// sheen?: number;
//        /// </summary>
//        float? Sheen { get; set; }
//        /// <summary>
//        /// sheenColor?: number;
//        /// </summary>
//        float? SheenColor { get; set; }
//        /// <summary>
//        /// sheenRoughness?: number;
//        /// </summary>
//        float? SheenRoughness { get; set; }
//        /// <summary>
//        /// shininess?: number;
//        /// </summary>
//        float? Shininess { get; set; }
//        /// <summary>
//        /// side?: Side;
//        /// </summary>
//        Side? Side { get; set; }
//        /// <summary>
//        /// size?: number;
//        /// </summary>
//        float? Size { get; set; }
//        /// <summary>
//        /// sizeAttenuation?: boolean;
//        /// </summary>
//        bool? SizeAttenuation { get; set; }
//        /// <summary>
//        /// specular?: number;
//        /// </summary>
//        float? Specular { get; set; }
//        /// <summary>
//        /// specularColor?: number;
//        /// </summary>
//        float? SpecularColor { get; set; }
//        /// <summary>
//        /// specularColorMap?: string;
//        /// </summary>
//        string? SpecularColorMap { get; set; }
//        /// <summary>
//        /// specularIntensity?: number;
//        /// </summary>
//        float? SpecularIntensity { get; set; }
//        /// <summary>
//        /// specularIntensityMap?: string;
//        /// </summary>
//        string? SpecularIntensityMap { get; set; }
//        /// <summary>
//        /// specularMap?: string;
//        /// </summary>
//        string? SpecularMap { get; set; }
//        /// <summary>
//        /// stencilFail?: StencilOp;
//        /// </summary>
//        StencilOp? StencilFail { get; set; }
//        /// <summary>
//        /// stencilFunc?: StencilFunc;
//        /// </summary>
//        StencilFunc? StencilFunc { get; set; }
//        /// <summary>
//        /// stencilFuncMask?: number;
//        /// </summary>
//        float? StencilFuncMask { get; set; }
//        /// <summary>
//        /// stencilRef?: number;
//        /// </summary>
//        float? StencilRef { get; set; }
//        /// <summary>
//        /// stencilWrite?: boolean;
//        /// </summary>
//        bool? StencilWrite { get; set; }
//        /// <summary>
//        /// stencilWriteMask?: number;
//        /// </summary>
//        float? StencilWriteMask { get; set; }
//        /// <summary>
//        /// stencilZFail?: StencilOp;
//        /// </summary>
//        StencilOp? StencilZFail { get; set; }
//        /// <summary>
//        /// stencilZPass?: StencilOp;
//        /// </summary>
//        StencilOp? StencilZPass { get; set; }
//        /// <summary>
//        /// textures?: Array<Omit<TextureJSON, "metadata">>;
//        /// </summary>
//        Array<Omit<TextureJSON, string>>? Textures { get; set; }
//        /// <summary>
//        /// thickness?: number;
//        /// </summary>
//        float? Thickness { get; set; }
//        /// <summary>
//        /// thicknessMap?: string;
//        /// </summary>
//        string? ThicknessMap { get; set; }
//        /// <summary>
//        /// toneMapped?: boolean;
//        /// </summary>
//        bool? ToneMapped { get; set; }
//        /// <summary>
//        /// transmission?: number;
//        /// </summary>
//        float? Transmission { get; set; }
//        /// <summary>
//        /// transmissionMap?: string;
//        /// </summary>
//        string? TransmissionMap { get; set; }
//        /// <summary>
//        /// transparent?: boolean;
//        /// </summary>
//        bool? Transparent { get; set; }
//        /// <summary>
//        /// type: string;
//        /// </summary>
//        string? Type { get; set; }
//        /// <summary>
//        /// userData?: Record<string, object>;
//        /// </summary>
//        Record<string, object>? UserData { get; set; }
//        /// <summary>
//        /// uuid: string;
//        /// </summary>
//        string? Uuid { get; set; }
//        /// <summary>
//        /// vertexColors?: boolean;
//        /// </summary>
//        bool? VertexColors { get; set; }
//        /// <summary>
//        /// visible?: boolean;
//        /// </summary>
//        bool? Visible { get; set; }
//        /// <summary>
//        /// wireframe?: boolean;
//        /// </summary>
//        bool? Wireframe { get; set; }
//        /// <summary>
//        /// wireframeLinecap?: string;
//        /// </summary>
//        string? WireframeLinecap { get; set; }
//        /// <summary>
//        /// wireframeLinejoin?: string;
//        /// </summary>
//        string? WireframeLinejoin { get; set; }
//        /// <summary>
//        /// wireframeLinewidth?: number;
//        /// </summary>
//        float? WireframeLinewidth { get; set; }
//        #endregion

//        #region Methods

//        #endregion
//    }
//}
