
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Object3DEventMap
    {
        #region Properties
        /// <summary>
        /// added: {};
        /// </summary>
        object? Added { get; set; }
        /// <summary>
        /// childadded: { child: Object3D };
        /// </summary>
        object? Childadded { get; set; }
        /// <summary>
        /// childremoved: { child: Object3D };
        /// </summary>
        object? Childremoved { get; set; }
        /// <summary>
        /// removed: {};
        /// </summary>
        object? Removed { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
