
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUTextureSampleType {
    ///     Float = "float",
    ///     UnfilterableFloat = "unfilterable-float",
    ///     Depth = "depth",
    ///     SInt = "sint",
    ///     UInt = "uint",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUTextureSampleType
    {
        [JsonPropertyName("float")]
        Float,
        [JsonPropertyName("unfilterable-float")]
        UnfilterableFloat,
        [JsonPropertyName("depth")]
        Depth,
        [JsonPropertyName("sint")]
        SInt,
        [JsonPropertyName("uint")]
        UInt,
    }
}
