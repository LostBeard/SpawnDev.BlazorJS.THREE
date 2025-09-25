
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUTextureAspect {
    ///     All = "all",
    ///     StencilOnly = "stencil-only",
    ///     DepthOnly = "depth-only",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUTextureAspect
    {
        [JsonPropertyName("all")]
        All,
        [JsonPropertyName("stencil-only")]
        StencilOnly,
        [JsonPropertyName("depth-only")]
        DepthOnly,
    }
}
