
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface PerspectiveCameraJSON : Object3DJSON
    {
        #region Properties
        /// <summary>
        /// object: PerspectiveCameraJSONObject;
        /// </summary>
        PerspectiveCameraJSONObject? Object { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
