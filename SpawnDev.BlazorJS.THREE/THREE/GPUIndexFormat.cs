
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUIndexFormat {
    ///     Uint16 = "uint16",
    ///     Uint32 = "uint32",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUIndexFormat
    {
        [JsonPropertyName("uint16")]
        Uint16,
        [JsonPropertyName("uint32")]
        Uint32,
    }
}
