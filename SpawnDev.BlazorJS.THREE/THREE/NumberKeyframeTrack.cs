
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NumberKeyframeTrack : KeyframeTrack
    {
        #region Constructors
        /// <inheritdoc/>
        public NumberKeyframeTrack(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, times: ArrayLike<number>, values: ArrayLike<number>, interpolation?: InterpolationModes);
        /// </summary>
        public NumberKeyframeTrack(string name, ArrayLikeFloat times, ArrayLikeFloat values, InterpolationModes interpolation) : base(JS.New("THREE.NumberKeyframeTrack", name, times, values, interpolation)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
