
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{

    public class BooleanKeyframeTrack : KeyframeTrack
    {
        #region Constructors
        /// <inheritdoc/>
        public BooleanKeyframeTrack(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, times: ArrayLike<number>, values: ArrayLike<boolean>);
        /// </summary>
        public BooleanKeyframeTrack(string name, ArrayLikeFloat times, ArrayLike<bool> values) : base(JS.New("THREE.BooleanKeyframeTrack", name, times, values)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
