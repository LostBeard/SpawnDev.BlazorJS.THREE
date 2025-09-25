
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshJSON : Object3DJSON
    {
        #region Properties
        /// <summary>
        /// object: MeshJSONObject;
        /// </summary>
        MeshJSONObject? Object { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
