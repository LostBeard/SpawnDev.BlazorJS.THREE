
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUFrontFace {
    ///     CCW = "ccw",
    ///     CW = "cw",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUFrontFace
    {
        [JsonPropertyName("ccw")]
        CCW,
        [JsonPropertyName("cw")]
        CW,
    }
}
