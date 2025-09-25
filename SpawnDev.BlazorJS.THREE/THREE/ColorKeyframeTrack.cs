
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ColorKeyframeTrack : KeyframeTrack
    {
        #region Constructors
        /// <inheritdoc/>
        public ColorKeyframeTrack(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, times: ArrayLike<number>, values: ArrayLike<number>, interpolation?: InterpolationModes);
        /// </summary>
        public ColorKeyframeTrack(string name, ArrayLikeFloat times, ArrayLikeFloat values, InterpolationModes interpolation) : base(JS.New("THREE.ColorKeyframeTrack", name, times, values, interpolation)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
