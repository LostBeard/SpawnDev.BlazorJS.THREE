
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUTextureViewDimension {
    ///     OneD = "1d",
    ///     TwoD = "2d",
    ///     TwoDArray = "2d-array",
    ///     Cube = "cube",
    ///     CubeArray = "cube-array",
    ///     ThreeD = "3d",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUTextureViewDimension
    {
        [JsonPropertyName("1d")]
        OneD,
        [JsonPropertyName("2d")]
        TwoD,
        [JsonPropertyName("2d-array")]
        TwoDArray,
        [JsonPropertyName("cube")]
        Cube,
        [JsonPropertyName("cube-array")]
        CubeArray,
        [JsonPropertyName("3d")]
        ThreeD,
    }
}
