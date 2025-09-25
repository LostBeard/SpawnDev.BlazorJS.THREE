
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Earcut : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Earcut(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// static triangulate(data: number[], holeIndices?: number[], dim?: number): number[];
        /// </summary>
        public Array<float> Triangulate(Array<float> data, Array<float> holeIndices, float dim)
        {
            return JSRef!.Call<Array<float>>("triangulate", data, holeIndices, dim);
        }
        #endregion
    }
}
