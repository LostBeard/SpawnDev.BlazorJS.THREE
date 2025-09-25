
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUBlendOperation {
    ///     Add = "add",
    ///     Subtract = "subtract",
    ///     ReverseSubtract = "reverse-subtract",
    ///     Min = "min",
    ///     Max = "max",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUBlendOperation
    {
        [JsonPropertyName("add")]
        Add,
        [JsonPropertyName("subtract")]
        Subtract,
        [JsonPropertyName("reverse-subtract")]
        ReverseSubtract,
        [JsonPropertyName("min")]
        Min,
        [JsonPropertyName("max")]
        Max,
    }
}
