
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ShapeJSON : PathJSON
    {
        #region Properties
        /// <summary>
        /// holes: PathJSON[];
        /// </summary>
        Array<PathJSON>? Holes { get; set; }
        /// <summary>
        /// uuid: string;
        /// </summary>
        string? Uuid { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
