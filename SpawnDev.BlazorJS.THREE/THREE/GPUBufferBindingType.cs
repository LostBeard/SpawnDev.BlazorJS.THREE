
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUBufferBindingType {
    ///     Uniform = "uniform",
    ///     Storage = "storage",
    ///     ReadOnlyStorage = "read-only-storage",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUBufferBindingType
    {
        [JsonPropertyName("uniform")]
        Uniform,
        [JsonPropertyName("storage")]
        Storage,
        [JsonPropertyName("read-only-storage")]
        ReadOnlyStorage,
    }
}
