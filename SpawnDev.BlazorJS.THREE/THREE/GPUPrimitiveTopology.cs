
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUPrimitiveTopology {
    ///     PointList = "point-list",
    ///     LineList = "line-list",
    ///     LineStrip = "line-strip",
    ///     TriangleList = "triangle-list",
    ///     TriangleStrip = "triangle-strip",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUPrimitiveTopology
    {
        [JsonPropertyName("point-list")]
        PointList,
        [JsonPropertyName("line-list")]
        LineList,
        [JsonPropertyName("line-strip")]
        LineStrip,
        [JsonPropertyName("triangle-list")]
        TriangleList,
        [JsonPropertyName("triangle-strip")]
        TriangleStrip,
    }
}
