
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AnimationClip : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public AnimationClip(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name?: string, duration?: number, tracks?: Array<KeyframeTrack>, blendMode?: AnimationBlendMode);
        /// </summary>
        public AnimationClip(string name, float duration, Array<KeyframeTrack> tracks, AnimationBlendMode blendMode) : base(JS.New("THREE.AnimationClip", name, duration, tracks, blendMode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// blendMode: AnimationBlendMode;
        /// </summary>
        public AnimationBlendMode BlendMode { get => JSRef!.Get<AnimationBlendMode>("blendMode"); set => JSRef!.Set("blendMode", value); }
        /// <summary>
        /// duration: number;
        /// </summary>
        public float Duration { get => JSRef!.Get<float>("duration"); set => JSRef!.Set("duration", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// tracks: Array<KeyframeTrack>;
        /// </summary>
        public Array<KeyframeTrack> Tracks { get => JSRef!.Get<Array<KeyframeTrack>>("tracks"); set => JSRef!.Set("tracks", value); }
        /// <summary>
        /// userData: Record<string, object>;
        /// </summary>
        public Record<string, object> UserData { get => JSRef!.Get<Record<string, object>>("userData"); set => JSRef!.Set("userData", value); }
        /// <summary>
        /// readonly uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); }
        #endregion

        #region Methods
        /// <summary>
        /// validate(): boolean;
        /// </summary>
        public bool Validate()
        {
            return JSRef!.Call<bool>("validate");
        }
        /// <summary>
        /// trim(): AnimationClip;
        /// </summary>
        public AnimationClip Trim()
        {
            return JSRef!.Call<AnimationClip>("trim");
        }
        /// <summary>
        /// static toJSON(clip: AnimationClip): AnimationClipJSON;
        /// </summary>
        public AnimationClipJSON ToJSON(AnimationClip clip)
        {
            return JSRef!.Call<AnimationClipJSON>("toJSON", clip);
        }
        /// <summary>
        /// toJSON(): AnimationClipJSON;
        /// </summary>
        public AnimationClipJSON ToJSON()
        {
            return JSRef!.Call<AnimationClipJSON>("toJSON");
        }
        /// <summary>
        /// resetDuration(): AnimationClip;
        /// </summary>
        public AnimationClip ResetDuration()
        {
            return JSRef!.Call<AnimationClip>("resetDuration");
        }
        /// <summary>
        /// static parseAnimation(animation: AnimationClipJSON, bones: Array<Bone>): AnimationClip | null;
        /// </summary>
        public AnimationClip ParseAnimation(AnimationClipJSON animation, Array<Bone> bones)
        {
            return JSRef!.Call<AnimationClip>("parseAnimation", animation, bones);
        }
        /// <summary>
        /// static parse(json: AnimationClipJSON): AnimationClip;
        /// </summary>
        public AnimationClip Parse(AnimationClipJSON json)
        {
            return JSRef!.Call<AnimationClip>("parse", json);
        }
        /// <summary>
        /// optimize(): AnimationClip;
        /// </summary>
        public AnimationClip Optimize()
        {
            return JSRef!.Call<AnimationClip>("optimize");
        }
        /// <summary>
        /// static findByName(objectOrClipArray: Array<AnimationClip> | Object3D, name: string): AnimationClip | null;
        /// </summary>
        public AnimationClip FindByName(Union<Array<AnimationClip>, Object3D> objectOrClipArray, string name)
        {
            return JSRef!.Call<AnimationClip>("findByName", objectOrClipArray, name);
        }
        /// <summary>
        /// static CreateFromMorphTargetSequence(
        ///         name: string,
        ///         morphTargetSequence: Array<MorphTarget>,
        ///         fps: number,
        ///         noLoop: boolean,
        ///     ): AnimationClip;
        /// </summary>
        public AnimationClip CreateFromMorphTargetSequence(string name, Array<MorphTarget> morphTargetSequence, float fps, bool noLoop)
        {
            return JSRef!.Call<AnimationClip>("CreateFromMorphTargetSequence", name, morphTargetSequence, fps, noLoop);
        }
        /// <summary>
        /// static CreateClipsFromMorphTargetSequences(
        ///         morphTargets: Array<MorphTarget>,
        ///         fps: number,
        ///         noLoop: boolean,
        ///     ): Array<AnimationClip>;
        /// </summary>
        public Array<AnimationClip> CreateClipsFromMorphTargetSequences(Array<MorphTarget> morphTargets, float fps, bool noLoop)
        {
            return JSRef!.Call<Array<AnimationClip>>("CreateClipsFromMorphTargetSequences", morphTargets, fps, noLoop);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public AnimationClip Clone()
        {
            return JSRef!.Call<AnimationClip>("clone");
        }
        #endregion
    }
}
