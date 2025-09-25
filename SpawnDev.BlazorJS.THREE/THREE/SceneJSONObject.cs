
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface SceneJSONObject : Object3DJSONObject
    {
        #region Properties
        /// <summary>
        /// backgroundBlurriness?: number;
        /// </summary>
        float? BackgroundBlurriness { get; set; }
        /// <summary>
        /// backgroundIntensity?: number;
        /// </summary>
        float? BackgroundIntensity { get; set; }
        /// <summary>
        /// backgroundRotation: EulerTuple;
        /// </summary>
        EulerTuple? BackgroundRotation { get; set; }
        /// <summary>
        /// environmentIntensity?: number;
        /// </summary>
        float? EnvironmentIntensity { get; set; }
        /// <summary>
        /// environmentRotation: EulerTuple;
        /// </summary>
        EulerTuple? EnvironmentRotation { get; set; }
        /// <summary>
        /// fog?: FogJSON | FogExp2JSON;
        /// </summary>
        Union<FogJSON, FogExp2JSON>? Fog { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
