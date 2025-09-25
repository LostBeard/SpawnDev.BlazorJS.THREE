
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUFeatureName {
    ///     CoreFeaturesAndLimits = "core-features-and-limits",
    ///     DepthClipControl = "depth-clip-control",
    ///     Depth32FloatStencil8 = "depth32float-stencil8",
    ///     TextureCompressionBC = "texture-compression-bc",
    ///     TextureCompressionBCSliced3D = "texture-compression-bc-sliced-3d",
    ///     TextureCompressionETC2 = "texture-compression-etc2",
    ///     TextureCompressionASTC = "texture-compression-astc",
    ///     TextureCompressionASTCSliced3D = "texture-compression-astc-sliced-3d",
    ///     TimestampQuery = "timestamp-query",
    ///     IndirectFirstInstance = "indirect-first-instance",
    ///     ShaderF16 = "shader-f16",
    ///     RG11B10UFloat = "rg11b10ufloat-renderable",
    ///     BGRA8UNormStorage = "bgra8unorm-storage",
    ///     Float32Filterable = "float32-filterable",
    ///     Float32Blendable = "float32-blendable",
    ///     ClipDistances = "clip-distances",
    ///     DualSourceBlending = "dual-source-blending",
    ///     Subgroups = "subgroups",
    ///     TextureFormatsTier1 = "texture-formats-tier1",
    ///     TextureFormatsTier2 = "texture-formats-tier2",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUFeatureName
    {
        [JsonPropertyName("core-features-and-limits")]
        CoreFeaturesAndLimits,
        [JsonPropertyName("depth-clip-control")]
        DepthClipControl,
        [JsonPropertyName("depth32float-stencil8")]
        Depth32FloatStencil8,
        [JsonPropertyName("texture-compression-bc")]
        TextureCompressionBC,
        [JsonPropertyName("texture-compression-bc-sliced-3d")]
        TextureCompressionBCSliced3D,
        [JsonPropertyName("texture-compression-etc2")]
        TextureCompressionETC2,
        [JsonPropertyName("texture-compression-astc")]
        TextureCompressionASTC,
        [JsonPropertyName("texture-compression-astc-sliced-3d")]
        TextureCompressionASTCSliced3D,
        [JsonPropertyName("timestamp-query")]
        TimestampQuery,
        [JsonPropertyName("indirect-first-instance")]
        IndirectFirstInstance,
        [JsonPropertyName("shader-f16")]
        ShaderF16,
        [JsonPropertyName("rg11b10ufloat-renderable")]
        RG11B10UFloat,
        [JsonPropertyName("bgra8unorm-storage")]
        BGRA8UNormStorage,
        [JsonPropertyName("float32-filterable")]
        Float32Filterable,
        [JsonPropertyName("float32-blendable")]
        Float32Blendable,
        [JsonPropertyName("clip-distances")]
        ClipDistances,
        [JsonPropertyName("dual-source-blending")]
        DualSourceBlending,
        [JsonPropertyName("subgroups")]
        Subgroups,
        [JsonPropertyName("texture-formats-tier1")]
        TextureFormatsTier1,
        [JsonPropertyName("texture-formats-tier2")]
        TextureFormatsTier2,
    }
}
