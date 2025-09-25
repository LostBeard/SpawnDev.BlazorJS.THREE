
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Object3DJSON
    {
        #region Properties
        /// <summary>
        /// metadata?: { version: number; type: string; generator: string };
        /// </summary>
        object? Metadata { get; set; }
        /// <summary>
        /// object: Object3DJSONObject;
        /// </summary>
        Object3DJSONObject? Object { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
