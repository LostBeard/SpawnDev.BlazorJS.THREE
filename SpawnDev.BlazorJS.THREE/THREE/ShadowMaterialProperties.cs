
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ShadowMaterialProperties : MaterialProperties
    {
        #region Properties
        /// <summary>
        /// color: Color;
        /// </summary>
        Color? Color { get; set; }
        /// <summary>
        /// fog: boolean;
        /// </summary>
        bool? Fog { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
