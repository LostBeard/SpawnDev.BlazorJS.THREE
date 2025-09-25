
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AudioAnalyser : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public AudioAnalyser(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(audio: Audio<AudioNode>, fftSize?: number);
        /// </summary>
        public AudioAnalyser(Audio audio, float fftSize) : base(JS.New("THREE.AudioAnalyser", audio, fftSize)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// analyser: AnalyserNode;
        /// </summary>
        public AnalyserNode Analyser { get => JSRef!.Get<AnalyserNode>("analyser"); set => JSRef!.Set("analyser", value); }
        /// <summary>
        /// data: Uint8Array;
        /// </summary>
        public Uint8Array Data { get => JSRef!.Get<Uint8Array>("data"); set => JSRef!.Set("data", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getFrequencyData(): Uint8Array;
        /// </summary>
        public Uint8Array GetFrequencyData()
        {
            return JSRef!.Call<Uint8Array>("getFrequencyData");
        }
        /// <summary>
        /// getAverageFrequency(): number;
        /// </summary>
        public float GetAverageFrequency()
        {
            return JSRef!.Call<float>("getAverageFrequency");
        }
        #endregion
    }
}
