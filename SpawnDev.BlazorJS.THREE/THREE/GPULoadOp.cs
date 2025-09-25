
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPULoadOp {
    ///     Load = "load",
    ///     Clear = "clear",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPULoadOp
    {
        [JsonPropertyName("load")]
        Load,
        [JsonPropertyName("clear")]
        Clear,
    }
}
