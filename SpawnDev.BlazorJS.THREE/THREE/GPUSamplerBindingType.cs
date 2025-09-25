
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUSamplerBindingType {
    ///     Filtering = "filtering",
    ///     NonFiltering = "non-filtering",
    ///     Comparison = "comparison",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUSamplerBindingType
    {
        [JsonPropertyName("filtering")]
        Filtering,
        [JsonPropertyName("non-filtering")]
        NonFiltering,
        [JsonPropertyName("comparison")]
        Comparison,
    }
}
