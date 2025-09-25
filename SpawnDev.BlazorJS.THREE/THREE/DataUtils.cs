
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DataUtils : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public DataUtils(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// static toHalfFloat(val: number): number;
        /// </summary>
        public float ToHalfFloat(float val)
        {
            return JSRef!.Call<float>("toHalfFloat", val);
        }
        /// <summary>
        /// static fromHalfFloat(val: number): number;
        /// </summary>
        public float FromHalfFloat(float val)
        {
            return JSRef!.Call<float>("fromHalfFloat", val);
        }
        #endregion
    }
}
