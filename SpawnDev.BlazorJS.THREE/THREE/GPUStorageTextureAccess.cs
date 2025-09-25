
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUStorageTextureAccess {
    ///     WriteOnly = "write-only",
    ///     ReadOnly = "read-only",
    ///     ReadWrite = "read-write",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUStorageTextureAccess
    {
        [JsonPropertyName("write-only")]
        WriteOnly,
        [JsonPropertyName("read-only")]
        ReadOnly,
        [JsonPropertyName("read-write")]
        ReadWrite,
    }
}
