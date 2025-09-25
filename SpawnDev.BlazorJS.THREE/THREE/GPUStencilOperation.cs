
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUStencilOperation {
    ///     Keep = "keep",
    ///     Zero = "zero",
    ///     Replace = "replace",
    ///     Invert = "invert",
    ///     IncrementClamp = "increment-clamp",
    ///     DecrementClamp = "decrement-clamp",
    ///     IncrementWrap = "increment-wrap",
    ///     DecrementWrap = "decrement-wrap",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUStencilOperation
    {
        [JsonPropertyName("keep")]
        Keep,
        [JsonPropertyName("zero")]
        Zero,
        [JsonPropertyName("replace")]
        Replace,
        [JsonPropertyName("invert")]
        Invert,
        [JsonPropertyName("increment-clamp")]
        IncrementClamp,
        [JsonPropertyName("decrement-clamp")]
        DecrementClamp,
        [JsonPropertyName("increment-wrap")]
        IncrementWrap,
        [JsonPropertyName("decrement-wrap")]
        DecrementWrap,
    }
}
