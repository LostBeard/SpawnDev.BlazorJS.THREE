
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AnimationAction : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public AnimationAction(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         mixer: AnimationMixer,
        ///         clip: AnimationClip,
        ///         localRoot?: Object3D | null,
        ///         blendMode?: AnimationBlendMode,
        ///     );
        /// </summary>
        public AnimationAction(AnimationMixer mixer, AnimationClip clip, Object3D localRoot, AnimationBlendMode blendMode) : base(JS.New("THREE.AnimationAction", mixer, clip, localRoot, blendMode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// blendMode: AnimationBlendMode;
        /// </summary>
        public AnimationBlendMode BlendMode { get => JSRef!.Get<AnimationBlendMode>("blendMode"); set => JSRef!.Set("blendMode", value); }
        /// <summary>
        /// clampWhenFinished: boolean;
        /// </summary>
        public bool ClampWhenFinished { get => JSRef!.Get<bool>("clampWhenFinished"); set => JSRef!.Set("clampWhenFinished", value); }
        /// <summary>
        /// enabled: boolean;
        /// </summary>
        public bool Enabled { get => JSRef!.Get<bool>("enabled"); set => JSRef!.Set("enabled", value); }
        /// <summary>
        /// loop: AnimationActionLoopStyles;
        /// </summary>
        public AnimationActionLoopStyles Loop { get => JSRef!.Get<AnimationActionLoopStyles>("loop"); set => JSRef!.Set("loop", value); }
        /// <summary>
        /// paused: boolean;
        /// </summary>
        public bool Paused { get => JSRef!.Get<bool>("paused"); set => JSRef!.Set("paused", value); }
        /// <summary>
        /// repetitions: number;
        /// </summary>
        public float Repetitions { get => JSRef!.Get<float>("repetitions"); set => JSRef!.Set("repetitions", value); }
        /// <summary>
        /// time: number;
        /// </summary>
        public float Time { get => JSRef!.Get<float>("time"); set => JSRef!.Set("time", value); }
        /// <summary>
        /// timeScale: number;
        /// </summary>
        public float TimeScale { get => JSRef!.Get<float>("timeScale"); set => JSRef!.Set("timeScale", value); }
        /// <summary>
        /// weight: number;
        /// </summary>
        public float Weight { get => JSRef!.Get<float>("weight"); set => JSRef!.Set("weight", value); }
        /// <summary>
        /// zeroSlopeAtEnd: boolean;
        /// </summary>
        public bool ZeroSlopeAtEnd { get => JSRef!.Get<bool>("zeroSlopeAtEnd"); set => JSRef!.Set("zeroSlopeAtEnd", value); }
        /// <summary>
        /// zeroSlopeAtStart: boolean;
        /// </summary>
        public bool ZeroSlopeAtStart { get => JSRef!.Get<bool>("zeroSlopeAtStart"); set => JSRef!.Set("zeroSlopeAtStart", value); }
        #endregion

        #region Methods
        /// <summary>
        /// warp(startTimeScale: number, endTimeScale: number, duration: number): AnimationAction;
        /// </summary>
        public AnimationAction Warp(float startTimeScale, float endTimeScale, float duration)
        {
            return JSRef!.Call<AnimationAction>("warp", startTimeScale, endTimeScale, duration);
        }
        /// <summary>
        /// syncWith(action: AnimationAction): AnimationAction;
        /// </summary>
        public AnimationAction SyncWith(AnimationAction action)
        {
            return JSRef!.Call<AnimationAction>("syncWith", action);
        }
        /// <summary>
        /// stopWarping(): AnimationAction;
        /// </summary>
        public AnimationAction StopWarping()
        {
            return JSRef!.Call<AnimationAction>("stopWarping");
        }
        /// <summary>
        /// stopFading(): AnimationAction;
        /// </summary>
        public AnimationAction StopFading()
        {
            return JSRef!.Call<AnimationAction>("stopFading");
        }
        /// <summary>
        /// stop(): AnimationAction;
        /// </summary>
        public AnimationAction Stop()
        {
            return JSRef!.Call<AnimationAction>("stop");
        }
        /// <summary>
        /// startAt(time: number): AnimationAction;
        /// </summary>
        public AnimationAction StartAt(float time)
        {
            return JSRef!.Call<AnimationAction>("startAt", time);
        }
        /// <summary>
        /// setLoop(mode: AnimationActionLoopStyles, repetitions: number): AnimationAction;
        /// </summary>
        public AnimationAction SetLoop(AnimationActionLoopStyles mode, float repetitions)
        {
            return JSRef!.Call<AnimationAction>("setLoop", mode, repetitions);
        }
        /// <summary>
        /// setEffectiveWeight(weight: number): AnimationAction;
        /// </summary>
        public AnimationAction SetEffectiveWeight(float weight)
        {
            return JSRef!.Call<AnimationAction>("setEffectiveWeight", weight);
        }
        /// <summary>
        /// setEffectiveTimeScale(timeScale: number): AnimationAction;
        /// </summary>
        public AnimationAction SetEffectiveTimeScale(float timeScale)
        {
            return JSRef!.Call<AnimationAction>("setEffectiveTimeScale", timeScale);
        }
        /// <summary>
        /// setDuration(duration: number): AnimationAction;
        /// </summary>
        public AnimationAction SetDuration(float duration)
        {
            return JSRef!.Call<AnimationAction>("setDuration", duration);
        }
        /// <summary>
        /// reset(): AnimationAction;
        /// </summary>
        public AnimationAction Reset()
        {
            return JSRef!.Call<AnimationAction>("reset");
        }
        /// <summary>
        /// play(): AnimationAction;
        /// </summary>
        public AnimationAction Play()
        {
            return JSRef!.Call<AnimationAction>("play");
        }
        /// <summary>
        /// isScheduled(): boolean;
        /// </summary>
        public bool IsScheduled()
        {
            return JSRef!.Call<bool>("isScheduled");
        }
        /// <summary>
        /// isRunning(): boolean;
        /// </summary>
        public bool IsRunning()
        {
            return JSRef!.Call<bool>("isRunning");
        }
        /// <summary>
        /// halt(duration: number): AnimationAction;
        /// </summary>
        public AnimationAction Halt(float duration)
        {
            return JSRef!.Call<AnimationAction>("halt", duration);
        }
        /// <summary>
        /// getRoot(): Object3D;
        /// </summary>
        public Object3D GetRoot()
        {
            return JSRef!.Call<Object3D>("getRoot");
        }
        /// <summary>
        /// getMixer(): AnimationMixer;
        /// </summary>
        public AnimationMixer GetMixer()
        {
            return JSRef!.Call<AnimationMixer>("getMixer");
        }
        /// <summary>
        /// getEffectiveWeight(): number;
        /// </summary>
        public float GetEffectiveWeight()
        {
            return JSRef!.Call<float>("getEffectiveWeight");
        }
        /// <summary>
        /// getEffectiveTimeScale(): number;
        /// </summary>
        public float GetEffectiveTimeScale()
        {
            return JSRef!.Call<float>("getEffectiveTimeScale");
        }
        /// <summary>
        /// getClip(): AnimationClip;
        /// </summary>
        public AnimationClip GetClip()
        {
            return JSRef!.Call<AnimationClip>("getClip");
        }
        /// <summary>
        /// fadeOut(duration: number): AnimationAction;
        /// </summary>
        public AnimationAction FadeOut(float duration)
        {
            return JSRef!.Call<AnimationAction>("fadeOut", duration);
        }
        /// <summary>
        /// fadeIn(duration: number): AnimationAction;
        /// </summary>
        public AnimationAction FadeIn(float duration)
        {
            return JSRef!.Call<AnimationAction>("fadeIn", duration);
        }
        /// <summary>
        /// crossFadeTo(fadeInAction: AnimationAction, duration: number, warp?: boolean): AnimationAction;
        /// </summary>
        public AnimationAction CrossFadeTo(AnimationAction fadeInAction, float duration, bool warp)
        {
            return JSRef!.Call<AnimationAction>("crossFadeTo", fadeInAction, duration, warp);
        }
        /// <summary>
        /// crossFadeFrom(fadeOutAction: AnimationAction, duration: number, warp?: boolean): AnimationAction;
        /// </summary>
        public AnimationAction CrossFadeFrom(AnimationAction fadeOutAction, float duration, bool warp)
        {
            return JSRef!.Call<AnimationAction>("crossFadeFrom", fadeOutAction, duration, warp);
        }
        #endregion
    }
}
