
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface OrthographicCameraJSON : Object3DJSON
    {
        #region Properties
        /// <summary>
        /// object: OrthographicCameraJSONObject;
        /// </summary>
        OrthographicCameraJSONObject? Object { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
