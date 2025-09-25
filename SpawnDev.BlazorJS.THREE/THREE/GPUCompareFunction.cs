
using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// export enum GPUCompareFunction {
    ///     Never = "never",
    ///     Less = "less",
    ///     Equal = "equal",
    ///     LessEqual = "less-equal",
    ///     Greater = "greater",
    ///     NotEqual = "not-equal",
    ///     GreaterEqual = "greater-equal",
    ///     Always = "always",
    /// }
    /// </summary>
    [JsonConverter(typeof(EnumStringConverterFactory))]
    public enum GPUCompareFunction
    {
        [JsonPropertyName("never")]
        Never,
        [JsonPropertyName("less")]
        Less,
        [JsonPropertyName("equal")]
        Equal,
        [JsonPropertyName("less-equal")]
        LessEqual,
        [JsonPropertyName("greater")]
        Greater,
        [JsonPropertyName("not-equal")]
        NotEqual,
        [JsonPropertyName("greater-equal")]
        GreaterEqual,
        [JsonPropertyName("always")]
        Always,
    }
}
