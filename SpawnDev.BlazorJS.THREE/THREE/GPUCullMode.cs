
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUCullMode {
    ///     None = "none",
    ///     Front = "front",
    ///     Back = "back",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUCullMode
    {
        [JsonPropertyName("none")]
        None,
        [JsonPropertyName("front")]
        Front,
        [JsonPropertyName("back")]
        Back,
    }
}
