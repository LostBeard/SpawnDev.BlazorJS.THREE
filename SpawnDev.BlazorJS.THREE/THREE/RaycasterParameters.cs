
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface RaycasterParameters
    {
        #region Properties
        /// <summary>
        /// Line: { threshold: number };
        /// </summary>
        object? Line { get; set; }
        /// <summary>
        /// Line2?: { threshold: number };
        /// </summary>
        object? Line2 { get; set; }
        /// <summary>
        /// LOD: any;
        /// </summary>
        object? LOD { get; set; }
        /// <summary>
        /// Mesh: any;
        /// </summary>
        object? Mesh { get; set; }
        /// <summary>
        /// Points: { threshold: number };
        /// </summary>
        object? Points { get; set; }
        /// <summary>
        /// Sprite: any;
        /// </summary>
        object? Sprite { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
