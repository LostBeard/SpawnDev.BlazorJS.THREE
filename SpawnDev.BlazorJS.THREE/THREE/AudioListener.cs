
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AudioListener : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public AudioListener(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public AudioListener() : base(JS.New("THREE.AudioListener")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// context: AudioContext;
        /// </summary>
        public AudioContext Context { get => JSRef!.Get<AudioContext>("context"); set => JSRef!.Set("context", value); }
        /// <summary>
        /// filter: AudioNode;
        /// </summary>
        public AudioNode Filter { get => JSRef!.Get<AudioNode>("filter"); set => JSRef!.Set("filter", value); }
        /// <summary>
        /// gain: GainNode;
        /// </summary>
        public GainNode Gain { get => JSRef!.Get<GainNode>("gain"); set => JSRef!.Set("gain", value); }
        /// <summary>
        /// timeDelta: number;
        /// </summary>
        public float TimeDelta { get => JSRef!.Get<float>("timeDelta"); set => JSRef!.Set("timeDelta", value); }
        /// <summary>
        /// readonly type: string | "AudioListener";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// setMasterVolume(value: number): this;
        /// </summary>
        public AudioListener SetMasterVolume(float value)
        {
            return JSRef!.Call<AudioListener>("setMasterVolume", value);
        }
        /// <summary>
        /// setFilter(value: AudioNode): this;
        /// </summary>
        public AudioListener SetFilter(AudioNode value)
        {
            return JSRef!.Call<AudioListener>("setFilter", value);
        }
        /// <summary>
        /// removeFilter(): this;
        /// </summary>
        public AudioListener RemoveFilter()
        {
            return JSRef!.Call<AudioListener>("removeFilter");
        }
        /// <summary>
        /// getMasterVolume(): number;
        /// </summary>
        public float GetMasterVolume()
        {
            return JSRef!.Call<float>("getMasterVolume");
        }
        /// <summary>
        /// getInput(): GainNode;
        /// </summary>
        public GainNode GetInput()
        {
            return JSRef!.Call<GainNode>("getInput");
        }
        /// <summary>
        /// getFilter(): AudioNode;
        /// </summary>
        public AudioNode GetFilter()
        {
            return JSRef!.Call<AudioNode>("getFilter");
        }
        #endregion
    }
}
