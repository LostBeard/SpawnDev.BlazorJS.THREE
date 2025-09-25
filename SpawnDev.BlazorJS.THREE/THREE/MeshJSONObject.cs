
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshJSONObject : Object3DJSONObject
    {
        #region Properties
        /// <summary>
        /// geometry: string;
        /// </summary>
        string? Geometry { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
