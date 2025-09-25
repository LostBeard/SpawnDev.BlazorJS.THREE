
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUFilterMode {
    ///     Linear = "linear",
    ///     Nearest = "nearest",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUFilterMode
    {
        [JsonPropertyName("linear")]
        Linear,
        [JsonPropertyName("nearest")]
        Nearest,
    }
}
