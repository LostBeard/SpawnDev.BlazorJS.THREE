
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUInputStepMode {
    ///     Vertex = "vertex",
    ///     Instance = "instance",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUInputStepMode
    {
        [JsonPropertyName("vertex")]
        Vertex,
        [JsonPropertyName("instance")]
        Instance,
    }
}
