
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUStoreOp {
    ///     Store = "store",
    ///     Discard = "discard",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUStoreOp
    {
        [JsonPropertyName("store")]
        Store,
        [JsonPropertyName("discard")]
        Discard,
    }
}
