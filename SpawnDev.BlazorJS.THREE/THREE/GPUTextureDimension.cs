
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUTextureDimension {
    ///     OneD = "1d",
    ///     TwoD = "2d",
    ///     ThreeD = "3d",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUTextureDimension
    {
        [JsonPropertyName("1d")]
        OneD,
        [JsonPropertyName("2d")]
        TwoD,
        [JsonPropertyName("3d")]
        ThreeD,
    }
}
