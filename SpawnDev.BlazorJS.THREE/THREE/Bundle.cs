
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Bundle
    {
        #region Properties
        /// <summary>
        /// bundleGroup: BundleGroup;
        /// </summary>
        BundleGroup? BundleGroup { get; set; }
        /// <summary>
        /// camera: Camera;
        /// </summary>
        Camera? Camera { get; set; }
        /// <summary>
        /// renderList: RenderList;
        /// </summary>
        RenderList? RenderList { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
