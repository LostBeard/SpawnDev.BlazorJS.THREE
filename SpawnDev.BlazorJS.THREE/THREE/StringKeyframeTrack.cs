
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StringKeyframeTrack : KeyframeTrack
    {
        #region Constructors
        /// <inheritdoc/>
        public StringKeyframeTrack(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, times: ArrayLike<number>, values: ArrayLike<string>);
        /// </summary>
        public StringKeyframeTrack(string name, ArrayLikeFloat times, ArrayLike<string> values) : base(JS.New("THREE.StringKeyframeTrack", name, times, values)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
