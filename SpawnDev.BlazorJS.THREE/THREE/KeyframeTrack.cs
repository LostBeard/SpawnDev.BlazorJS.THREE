
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class KeyframeTrack : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public KeyframeTrack(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         name: string,
        ///         times: ArrayLike<number>,
        ///         values: ArrayLike<number | string | boolean>,
        ///         interpolation?: InterpolationModes,
        ///     );
        /// </summary>
        public KeyframeTrack(string name, ArrayLikeFloat times, ArrayLike<Union<float, string, bool>> values, InterpolationModes interpolation) : base(JS.New("THREE.KeyframeTrack", name, times, values, interpolation)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// DefaultInterpolation: InterpolationModes;
        /// </summary>
        public InterpolationModes DefaultInterpolation { get => JSRef!.Get<InterpolationModes>("DefaultInterpolation"); set => JSRef!.Set("DefaultInterpolation", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        ///// <summary>
        ///// TimeBufferType: TypedArrayConstructor | ArrayConstructor;
        ///// </summary>
        //public Union<TypedArrayConstructor, ArrayConstructor> TimeBufferType { get => JSRef!.Get<Union<TypedArrayConstructor, ArrayConstructor>>("TimeBufferType"); set => JSRef!.Set("TimeBufferType", value); }
        /// <summary>
        /// times: Float32Array;
        /// </summary>
        public Float32Array Times { get => JSRef!.Get<Float32Array>("times"); set => JSRef!.Set("times", value); }
        ///// <summary>
        ///// ValueBufferType: TypedArrayConstructor | ArrayConstructor;
        ///// </summary>
        //public Union<TypedArrayConstructor, ArrayConstructor> ValueBufferType { get => JSRef!.Get<Union<TypedArrayConstructor, ArrayConstructor>>("ValueBufferType"); set => JSRef!.Set("ValueBufferType", value); }
        /// <summary>
        /// values: Float32Array;
        /// </summary>
        public Float32Array Values { get => JSRef!.Get<Float32Array>("values"); set => JSRef!.Set("values", value); }
        /// <summary>
        /// ValueTypeName: string;
        /// </summary>
        public string ValueTypeName { get => JSRef!.Get<string>("ValueTypeName"); set => JSRef!.Set("ValueTypeName", value); }
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
        /// trim(startTime: number, endTime: number): KeyframeTrack;
        /// </summary>
        public KeyframeTrack Trim(float startTime, float endTime)
        {
            return JSRef!.Call<KeyframeTrack>("trim", startTime, endTime);
        }
        /// <summary>
        /// static toJSON(track: KeyframeTrack): KeyframeTrackJSON;
        /// </summary>
        public KeyframeTrackJSON ToJSON(KeyframeTrack track)
        {
            return JSRef!.Call<KeyframeTrackJSON>("toJSON", track);
        }
        /// <summary>
        /// shift(timeOffset: number): KeyframeTrack;
        /// </summary>
        public KeyframeTrack Shift(float timeOffset)
        {
            return JSRef!.Call<KeyframeTrack>("shift", timeOffset);
        }
        /// <summary>
        /// setInterpolation(interpolation: InterpolationModes): KeyframeTrack;
        /// </summary>
        public KeyframeTrack SetInterpolation(InterpolationModes interpolation)
        {
            return JSRef!.Call<KeyframeTrack>("setInterpolation", interpolation);
        }
        /// <summary>
        /// scale(timeScale: number): KeyframeTrack;
        /// </summary>
        public KeyframeTrack Scale(float timeScale)
        {
            return JSRef!.Call<KeyframeTrack>("scale", timeScale);
        }
        /// <summary>
        /// optimize(): this;
        /// </summary>
        public KeyframeTrack Optimize()
        {
            return JSRef!.Call<KeyframeTrack>("optimize");
        }
        /// <summary>
        /// InterpolantFactoryMethodSmooth(result?: TypedArray): CubicInterpolant;
        /// </summary>
        public CubicInterpolant InterpolantFactoryMethodSmooth(TypedArray result)
        {
            return JSRef!.Call<CubicInterpolant>("InterpolantFactoryMethodSmooth", result);
        }
        /// <summary>
        /// InterpolantFactoryMethodLinear(result?: TypedArray): LinearInterpolant;
        /// </summary>
        public LinearInterpolant InterpolantFactoryMethodLinear(TypedArray result)
        {
            return JSRef!.Call<LinearInterpolant>("InterpolantFactoryMethodLinear", result);
        }
        /// <summary>
        /// InterpolantFactoryMethodDiscrete(result?: TypedArray): DiscreteInterpolant;
        /// </summary>
        public DiscreteInterpolant InterpolantFactoryMethodDiscrete(TypedArray result)
        {
            return JSRef!.Call<DiscreteInterpolant>("InterpolantFactoryMethodDiscrete", result);
        }
        /// <summary>
        /// getValueSize(): number;
        /// </summary>
        public float GetValueSize()
        {
            return JSRef!.Call<float>("getValueSize");
        }
        /// <summary>
        /// getInterpolation(): InterpolationModes;
        /// </summary>
        public InterpolationModes GetInterpolation()
        {
            return JSRef!.Call<InterpolationModes>("getInterpolation");
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public KeyframeTrack Clone()
        {
            return JSRef!.Call<KeyframeTrack>("clone");
        }
        #endregion
    }
}
