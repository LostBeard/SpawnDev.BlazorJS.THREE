
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface CacheKeyData
    {
        #region Properties
        /// <summary>
        /// cacheKey: number;
        /// </summary>
        float? CacheKey { get; set; }
        /// <summary>
        /// callId: number;
        /// </summary>
        float? CallId { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
