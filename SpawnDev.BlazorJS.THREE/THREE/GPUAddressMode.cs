
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUAddressMode {
    ///     ClampToEdge = "clamp-to-edge",
    ///     Repeat = "repeat",
    ///     MirrorRepeat = "mirror-repeat",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUAddressMode
    {
        [JsonPropertyName("clamp-to-edge")]
        ClampToEdge,
        [JsonPropertyName("repeat")]
        Repeat,
        [JsonPropertyName("mirror-repeat")]
        MirrorRepeat,
    }
}
