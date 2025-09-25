
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface CurvePathJSON : CurveJSON
    {
        #region Properties
        /// <summary>
        /// autoClose: boolean;
        /// </summary>
        bool? AutoClose { get; set; }
        /// <summary>
        /// curves: CurveJSON[];
        /// </summary>
        Array<CurveJSON>? Curves { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
