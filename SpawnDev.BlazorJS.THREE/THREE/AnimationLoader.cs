
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AnimationLoader : Loader<Array<AnimationClip>>
    {
        #region Constructors
        /// <inheritdoc/>
        public AnimationLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public AnimationLoader(LoadingManager manager) : base(JS.New("THREE.AnimationLoader", manager)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// parse(json: readonlyunknown[]): AnimationClip[];
        /// </summary>
        public Array<AnimationClip> Parse(Array<object> json)
        {
            return JSRef!.Call<Array<AnimationClip>>("parse", json);
        }
        #endregion
    }
}
