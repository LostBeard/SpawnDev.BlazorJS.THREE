
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PositionalAudio : Audio
    {
        #region Constructors
        /// <inheritdoc/>
        public PositionalAudio(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(listener: AudioListener);
        /// </summary>
        public PositionalAudio(AudioListener listener) : base(JS.New("THREE.PositionalAudio", listener)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// panner: PannerNode;
        /// </summary>
        public JSObject Panner { get => JSRef!.Get<JSObject>("panner"); set => JSRef!.Set("panner", value); }
        public T GetPanner<T>() => JSRef!.Get<T>("panner");
        public void SetPanner(object value) => JSRef!.Set("panner", value);
        #endregion

        #region Methods
        /// <summary>
        /// setRolloffFactor(value: number): this;
        /// </summary>
        public PositionalAudio SetRolloffFactor(float value)
        {
            return JSRef!.Call<PositionalAudio>("setRolloffFactor", value);
        }
        /// <summary>
        /// setRefDistance(value: number): this;
        /// </summary>
        public PositionalAudio SetRefDistance(float value)
        {
            return JSRef!.Call<PositionalAudio>("setRefDistance", value);
        }
        /// <summary>
        /// setMaxDistance(value: number): this;
        /// </summary>
        public PositionalAudio SetMaxDistance(float value)
        {
            return JSRef!.Call<PositionalAudio>("setMaxDistance", value);
        }
        /// <summary>
        /// setDistanceModel(value: string): this;
        /// </summary>
        public PositionalAudio SetDistanceModel(string value)
        {
            return JSRef!.Call<PositionalAudio>("setDistanceModel", value);
        }
        /// <summary>
        /// setDirectionalCone(coneInnerAngle: number, coneOuterAngle: number, coneOuterGain: number): this;
        /// </summary>
        public PositionalAudio SetDirectionalCone(float coneInnerAngle, float coneOuterAngle, float coneOuterGain)
        {
            return JSRef!.Call<PositionalAudio>("setDirectionalCone", coneInnerAngle, coneOuterAngle, coneOuterGain);
        }
        /// <summary>
        /// getRolloffFactor(): number;
        /// </summary>
        public float GetRolloffFactor()
        {
            return JSRef!.Call<float>("getRolloffFactor");
        }
        /// <summary>
        /// getRefDistance(): number;
        /// </summary>
        public float GetRefDistance()
        {
            return JSRef!.Call<float>("getRefDistance");
        }
        /// <summary>
        /// getOutput(): PannerNode;
        /// </summary>
        public PannerNode GetOutput()
        {
            return JSRef!.Call<PannerNode>("getOutput");
        }
        /// <summary>
        /// getMaxDistance(): number;
        /// </summary>
        public float GetMaxDistance()
        {
            return JSRef!.Call<float>("getMaxDistance");
        }
        /// <summary>
        /// getDistanceModel(): string;
        /// </summary>
        public string GetDistanceModel()
        {
            return JSRef!.Call<string>("getDistanceModel");
        }
        #endregion
    }
}
