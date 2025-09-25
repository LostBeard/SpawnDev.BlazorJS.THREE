
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface PathJSON : CurvePathJSON
    {
        #region Properties
        /// <summary>
        /// currentPoint: Vector2Tuple;
        /// </summary>
        Vector2Tuple? CurrentPoint { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
