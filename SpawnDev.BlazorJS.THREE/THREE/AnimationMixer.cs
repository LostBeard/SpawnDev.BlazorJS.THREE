
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AnimationMixer : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public AnimationMixer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(root: Object3D | AnimationObjectGroup);
        /// </summary>
        public AnimationMixer(Union<Object3D, AnimationObjectGroup> root) : base(JS.New("THREE.AnimationMixer", root)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// time: number;
        /// </summary>
        public float Time { get => JSRef!.Get<float>("time"); set => JSRef!.Set("time", value); }
        /// <summary>
        /// timeScale: number;
        /// </summary>
        public float TimeScale { get => JSRef!.Get<float>("timeScale"); set => JSRef!.Set("timeScale", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(deltaTime: number): AnimationMixer;
        /// </summary>
        public AnimationMixer Update(float deltaTime)
        {
            return JSRef!.Call<AnimationMixer>("update", deltaTime);
        }
        /// <summary>
        /// uncacheRoot(root: Object3D | AnimationObjectGroup): void;
        /// </summary>
        public void UncacheRoot(Union<Object3D, AnimationObjectGroup> root)
        {
            JSRef!.CallVoid("uncacheRoot", root);
        }
        /// <summary>
        /// uncacheClip(clip: AnimationClip): void;
        /// </summary>
        public void UncacheClip(AnimationClip clip)
        {
            JSRef!.CallVoid("uncacheClip", clip);
        }
        /// <summary>
        /// uncacheAction(clip: AnimationClip | string, optionalRoot?: Object3D | AnimationObjectGroup): void;
        /// </summary>
        public void UncacheAction(Union<AnimationClip, string> clip, Union<Object3D, AnimationObjectGroup> optionalRoot)
        {
            JSRef!.CallVoid("uncacheAction", clip, optionalRoot);
        }
        /// <summary>
        /// stopAllAction(): AnimationMixer;
        /// </summary>
        public AnimationMixer StopAllAction()
        {
            return JSRef!.Call<AnimationMixer>("stopAllAction");
        }
        /// <summary>
        /// setTime(time: number): AnimationMixer;
        /// </summary>
        public AnimationMixer SetTime(float time)
        {
            return JSRef!.Call<AnimationMixer>("setTime", time);
        }
        /// <summary>
        /// getRoot(): Object3D | AnimationObjectGroup;
        /// </summary>
        public Union<Object3D, AnimationObjectGroup> GetRoot()
        {
            return JSRef!.Call<Union<Object3D, AnimationObjectGroup>>("getRoot");
        }
        /// <summary>
        /// existingAction(
        ///         clip: AnimationClip | string,
        ///         optionalRoot?: Object3D | AnimationObjectGroup,
        ///     ): AnimationAction | null;
        /// </summary>
        public AnimationAction ExistingAction(Union<AnimationClip, string> clip, Union<Object3D, AnimationObjectGroup> optionalRoot)
        {
            return JSRef!.Call<AnimationAction>("existingAction", clip, optionalRoot);
        }
        /// <summary>
        /// clipAction(
        ///         clip: AnimationClip,
        ///         optionalRoot?: Object3D | AnimationObjectGroup,
        ///         blendMode?: AnimationBlendMode,
        ///     ): AnimationAction;
        /// </summary>
        public AnimationAction ClipAction(AnimationClip clip, Union<Object3D, AnimationObjectGroup> optionalRoot, AnimationBlendMode blendMode)
        {
            return JSRef!.Call<AnimationAction>("clipAction", clip, optionalRoot, blendMode);
        }
        /// <summary>
        /// clipAction(
        ///         clip: AnimationClip | string,
        ///         optionalRoot?: Object3D | AnimationObjectGroup,
        ///         blendMode?: AnimationBlendMode,
        ///     ): AnimationAction | null;
        /// </summary>
        public AnimationAction ClipAction(Union<AnimationClip, string> clip, Union<Object3D, AnimationObjectGroup> optionalRoot, AnimationBlendMode blendMode)
        {
            return JSRef!.Call<AnimationAction>("clipAction", clip, optionalRoot, blendMode);
        }
        #endregion
    }
}
