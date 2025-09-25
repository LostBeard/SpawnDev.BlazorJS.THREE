
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUVertexFormat {
    ///     Uint8x2 = "uint8x2",
    ///     Uint8x4 = "uint8x4",
    ///     Sint8x2 = "sint8x2",
    ///     Sint8x4 = "sint8x4",
    ///     Unorm8x2 = "unorm8x2",
    ///     Unorm8x4 = "unorm8x4",
    ///     Snorm8x2 = "snorm8x2",
    ///     Snorm8x4 = "snorm8x4",
    ///     Uint16x2 = "uint16x2",
    ///     Uint16x4 = "uint16x4",
    ///     Sint16x2 = "sint16x2",
    ///     Sint16x4 = "sint16x4",
    ///     Unorm16x2 = "unorm16x2",
    ///     Unorm16x4 = "unorm16x4",
    ///     Snorm16x2 = "snorm16x2",
    ///     Snorm16x4 = "snorm16x4",
    ///     Float16x2 = "float16x2",
    ///     Float16x4 = "float16x4",
    ///     Float32 = "float32",
    ///     Float32x2 = "float32x2",
    ///     Float32x3 = "float32x3",
    ///     Float32x4 = "float32x4",
    ///     Uint32 = "uint32",
    ///     Uint32x2 = "uint32x2",
    ///     Uint32x3 = "uint32x3",
    ///     Uint32x4 = "uint32x4",
    ///     Sint32 = "sint32",
    ///     Sint32x2 = "sint32x2",
    ///     Sint32x3 = "sint32x3",
    ///     Sint32x4 = "sint32x4",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUVertexFormat
    {
        [JsonPropertyName("uint8x2")]
        Uint8x2,
        [JsonPropertyName("uint8x4")]
        Uint8x4,
        [JsonPropertyName("sint8x2")]
        Sint8x2,
        [JsonPropertyName("sint8x4")]
        Sint8x4,
        [JsonPropertyName("unorm8x2")]
        Unorm8x2,
        [JsonPropertyName("unorm8x4")]
        Unorm8x4,
        [JsonPropertyName("snorm8x2")]
        Snorm8x2,
        [JsonPropertyName("snorm8x4")]
        Snorm8x4,
        [JsonPropertyName("uint16x2")]
        Uint16x2,
        [JsonPropertyName("uint16x4")]
        Uint16x4,
        [JsonPropertyName("sint16x2")]
        Sint16x2,
        [JsonPropertyName("sint16x4")]
        Sint16x4,
        [JsonPropertyName("unorm16x2")]
        Unorm16x2,
        [JsonPropertyName("unorm16x4")]
        Unorm16x4,
        [JsonPropertyName("snorm16x2")]
        Snorm16x2,
        [JsonPropertyName("snorm16x4")]
        Snorm16x4,
        [JsonPropertyName("float16x2")]
        Float16x2,
        [JsonPropertyName("float16x4")]
        Float16x4,
        [JsonPropertyName("float32")]
        Float32,
        [JsonPropertyName("float32x2")]
        Float32x2,
        [JsonPropertyName("float32x3")]
        Float32x3,
        [JsonPropertyName("float32x4")]
        Float32x4,
        [JsonPropertyName("uint32")]
        Uint32,
        [JsonPropertyName("uint32x2")]
        Uint32x2,
        [JsonPropertyName("uint32x3")]
        Uint32x3,
        [JsonPropertyName("uint32x4")]
        Uint32x4,
        [JsonPropertyName("sint32")]
        Sint32,
        [JsonPropertyName("sint32x2")]
        Sint32x2,
        [JsonPropertyName("sint32x3")]
        Sint32x3,
        [JsonPropertyName("sint32x4")]
        Sint32x4,
    }
}
