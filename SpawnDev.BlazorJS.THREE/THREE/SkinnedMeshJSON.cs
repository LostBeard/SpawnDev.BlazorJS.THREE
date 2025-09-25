
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface SkinnedMeshJSON : MeshJSON
    {
        #region Properties
        /// <summary>
        /// object: SkinnedMeshJSONObject;
        /// </summary>
        SkinnedMeshJSONObject? Object { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
