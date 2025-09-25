
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUBlendFactor {
    ///     Zero = "zero",
    ///     One = "one",
    ///     Src = "src",
    ///     OneMinusSrc = "one-minus-src",
    ///     SrcAlpha = "src-alpha",
    ///     OneMinusSrcAlpha = "one-minus-src-alpha",
    ///     Dst = "dst",
    ///     OneMinusDst = "one-minus-dst",
    ///     DstAlpha = "dst-alpha",
    ///     OneMinusDstAlpha = "one-minus-dst-alpha",
    ///     SrcAlphaSaturated = "src-alpha-saturated",
    ///     Constant = "constant",
    ///     OneMinusConstant = "one-minus-constant",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUBlendFactor
    {
        [JsonPropertyName("zero")]
        Zero,
        [JsonPropertyName("one")]
        One,
        [JsonPropertyName("src")]
        Src,
        [JsonPropertyName("one-minus-src")]
        OneMinusSrc,
        [JsonPropertyName("src-alpha")]
        SrcAlpha,
        [JsonPropertyName("one-minus-src-alpha")]
        OneMinusSrcAlpha,
        [JsonPropertyName("dst")]
        Dst,
        [JsonPropertyName("one-minus-dst")]
        OneMinusDst,
        [JsonPropertyName("dst-alpha")]
        DstAlpha,
        [JsonPropertyName("one-minus-dst-alpha")]
        OneMinusDstAlpha,
        [JsonPropertyName("src-alpha-saturated")]
        SrcAlphaSaturated,
        [JsonPropertyName("constant")]
        Constant,
        [JsonPropertyName("one-minus-constant")]
        OneMinusConstant,
    }
}
