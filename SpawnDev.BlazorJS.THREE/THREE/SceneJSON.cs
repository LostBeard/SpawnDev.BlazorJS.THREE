
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface SceneJSON : Object3DJSON
    {
        #region Properties
        /// <summary>
        /// object: SceneJSONObject;
        /// </summary>
        SceneJSONObject? Object { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
