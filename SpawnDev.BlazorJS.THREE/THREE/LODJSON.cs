
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface LODJSON : Object3DJSON
    {
        #region Properties
        /// <summary>
        /// object: LODJSONObject;
        /// </summary>
        LODJSONObject? Object { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
