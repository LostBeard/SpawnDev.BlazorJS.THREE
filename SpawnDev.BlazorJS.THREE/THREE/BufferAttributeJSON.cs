
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface BufferAttributeJSON
    {
        #region Properties
        /// <summary>
        /// array: number[];
        /// </summary>
        Array<float>? Array { get; set; }
        /// <summary>
        /// itemSize: number;
        /// </summary>
        float? ItemSize { get; set; }
        /// <summary>
        /// name?: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// normalized: boolean;
        /// </summary>
        bool? Normalized { get; set; }
        /// <summary>
        /// type: string;
        /// </summary>
        string? Type { get; set; }
        /// <summary>
        /// usage?: Usage;
        /// </summary>
        Usage? Usage { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
