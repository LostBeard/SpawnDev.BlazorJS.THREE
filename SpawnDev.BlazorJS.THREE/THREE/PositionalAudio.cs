using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// Create a positional audio object.<br/>
    /// https://threejs.org/docs/index.html#api/en/audio/PositionalAudio
    /// </summary>
    public class PositionalAudio : Audio
    {
        #region Constructors
        /// <inheritdoc/>
        public PositionalAudio(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Create a new PositionalAudio.
        /// </summary>
        /// <param name="listener">The AudioListener</param>
        public PositionalAudio(AudioListener listener) : base(JS.New("THREE.PositionalAudio", listener)) { }

        #endregion

        #region Properties
        /// <summary>
        /// panner: PannerNode;
        /// </summary>
        public PannerNode Panner { get => JSRef!.Get<PannerNode>("panner"); set => JSRef!.Set("panner", value); }
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
