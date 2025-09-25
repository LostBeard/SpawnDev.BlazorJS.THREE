
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class QuaternionKeyframeTrack : KeyframeTrack
    {
        #region Constructors
        /// <inheritdoc/>
        public QuaternionKeyframeTrack(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, times: ArrayLike<number>, values: ArrayLike<number>, interpolation?: InterpolationModes);
        /// </summary>
        public QuaternionKeyframeTrack(string name, ArrayLikeFloat times, ArrayLikeFloat values, InterpolationModes interpolation) : base(JS.New("THREE.QuaternionKeyframeTrack", name, times, values, interpolation)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
