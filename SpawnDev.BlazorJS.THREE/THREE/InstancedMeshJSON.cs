
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface InstancedMeshJSON : MeshJSONObject
    {
        #region Properties
        /// <summary>
        /// object: InstancedMeshJSONObject;
        /// </summary>
        InstancedMeshJSONObject? Object { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
