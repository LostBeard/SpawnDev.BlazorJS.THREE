
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Audio : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public Audio(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(listener: AudioListener);
        /// </summary>
        public Audio(AudioListener listener) : base(JS.New("THREE.Audio", listener)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// autoplay: boolean;
        /// </summary>
        public bool Autoplay { get => JSRef!.Get<bool>("autoplay"); set => JSRef!.Set("autoplay", value); }
        /// <summary>
        /// buffer: AudioBuffer | null;
        /// </summary>
        public AudioBuffer Buffer { get => JSRef!.Get<AudioBuffer>("buffer"); set => JSRef!.Set("buffer", value); }
        /// <summary>
        /// context: AudioContext;
        /// </summary>
        public AudioContext Context { get => JSRef!.Get<AudioContext>("context"); set => JSRef!.Set("context", value); }
        /// <summary>
        /// detune: number;
        /// </summary>
        public float Detune { get => JSRef!.Get<float>("detune"); set => JSRef!.Set("detune", value); }
        /// <summary>
        /// duration: number | undefined;
        /// </summary>
        public float Duration { get => JSRef!.Get<float>("duration"); set => JSRef!.Set("duration", value); }
        /// <summary>
        /// filters: AudioNode[];
        /// </summary>
        public Array<AudioNode> Filters { get => JSRef!.Get<Array<AudioNode>>("filters"); set => JSRef!.Set("filters", value); }
        /// <summary>
        /// gain: GainNode;
        /// </summary>
        public GainNode Gain { get => JSRef!.Get<GainNode>("gain"); set => JSRef!.Set("gain", value); }
        /// <summary>
        /// hasPlaybackControl: boolean;
        /// </summary>
        public bool HasPlaybackControl { get => JSRef!.Get<bool>("hasPlaybackControl"); set => JSRef!.Set("hasPlaybackControl", value); }
        /// <summary>
        /// isPlaying: boolean;
        /// </summary>
        public bool IsPlaying { get => JSRef!.Get<bool>("isPlaying"); set => JSRef!.Set("isPlaying", value); }
        /// <summary>
        /// listener: AudioListener;
        /// </summary>
        public AudioListener Listener { get => JSRef!.Get<AudioListener>("listener"); set => JSRef!.Set("listener", value); }
        /// <summary>
        /// loop: boolean;
        /// </summary>
        public bool Loop { get => JSRef!.Get<bool>("loop"); set => JSRef!.Set("loop", value); }
        /// <summary>
        /// loopEnd: number;
        /// </summary>
        public float LoopEnd { get => JSRef!.Get<float>("loopEnd"); set => JSRef!.Set("loopEnd", value); }
        /// <summary>
        /// loopStart: number;
        /// </summary>
        public float LoopStart { get => JSRef!.Get<float>("loopStart"); set => JSRef!.Set("loopStart", value); }
        /// <summary>
        /// offset: number;
        /// </summary>
        public float Offset { get => JSRef!.Get<float>("offset"); set => JSRef!.Set("offset", value); }
        /// <summary>
        /// playbackRate: number;
        /// </summary>
        public float PlaybackRate { get => JSRef!.Get<float>("playbackRate"); set => JSRef!.Set("playbackRate", value); }
        /// <summary>
        /// source: AudioScheduledSourceNode | null;
        /// </summary>
        public AudioScheduledSourceNode Source { get => JSRef!.Get<AudioScheduledSourceNode>("source"); set => JSRef!.Set("source", value); }
        /// <summary>
        /// sourceType: string;
        /// </summary>
        public string SourceType { get => JSRef!.Get<string>("sourceType"); set => JSRef!.Set("sourceType", value); }
        /// <summary>
        /// readonly type: string | "Audio";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// stop(delay?: number): this;
        /// </summary>
        public Audio Stop(float delay)
        {
            return JSRef!.Call<Audio>("stop", delay);
        }
        /// <summary>
        /// setVolume(value: number): this;
        /// </summary>
        public Audio SetVolume(float value)
        {
            return JSRef!.Call<Audio>("setVolume", value);
        }
        /// <summary>
        /// setPlaybackRate(value: number): this;
        /// </summary>
        public Audio SetPlaybackRate(float value)
        {
            return JSRef!.Call<Audio>("setPlaybackRate", value);
        }
        /// <summary>
        /// setNodeSource(audioNode: AudioScheduledSourceNode): this;
        /// </summary>
        public Audio SetNodeSource(AudioScheduledSourceNode audioNode)
        {
            return JSRef!.Call<Audio>("setNodeSource", audioNode);
        }
        /// <summary>
        /// setMediaStreamSource(mediaStream: MediaStream): this;
        /// </summary>
        public Audio SetMediaStreamSource(MediaStream mediaStream)
        {
            return JSRef!.Call<Audio>("setMediaStreamSource", mediaStream);
        }
        /// <summary>
        /// setMediaElementSource(mediaElement: HTMLMediaElement): this;
        /// </summary>
        public Audio SetMediaElementSource(HTMLMediaElement mediaElement)
        {
            return JSRef!.Call<Audio>("setMediaElementSource", mediaElement);
        }
        /// <summary>
        /// setLoopStart(value: number): this;
        /// </summary>
        public Audio SetLoopStart(float value)
        {
            return JSRef!.Call<Audio>("setLoopStart", value);
        }
        /// <summary>
        /// setLoopEnd(value: number): this;
        /// </summary>
        public Audio SetLoopEnd(float value)
        {
            return JSRef!.Call<Audio>("setLoopEnd", value);
        }
        /// <summary>
        /// setLoop(value: boolean): this;
        /// </summary>
        public Audio SetLoop(bool value)
        {
            return JSRef!.Call<Audio>("setLoop", value);
        }
        /// <summary>
        /// setFilters(value: AudioNode[]): this;
        /// </summary>
        public Audio SetFilters(Array<AudioNode> value)
        {
            return JSRef!.Call<Audio>("setFilters", value);
        }
        /// <summary>
        /// setFilter(filter: AudioNode): this;
        /// </summary>
        public Audio SetFilter(AudioNode filter)
        {
            return JSRef!.Call<Audio>("setFilter", filter);
        }
        /// <summary>
        /// setDetune(value: number): this;
        /// </summary>
        public Audio SetDetune(float value)
        {
            return JSRef!.Call<Audio>("setDetune", value);
        }
        /// <summary>
        /// setBuffer(audioBuffer: AudioBuffer): this;
        /// </summary>
        public Audio SetBuffer(AudioBuffer audioBuffer)
        {
            return JSRef!.Call<Audio>("setBuffer", audioBuffer);
        }
        /// <summary>
        /// play(delay?: number): this;
        /// </summary>
        public Audio Play(float delay)
        {
            return JSRef!.Call<Audio>("play", delay);
        }
        /// <summary>
        /// pause(): this;
        /// </summary>
        public Audio Pause()
        {
            return JSRef!.Call<Audio>("pause");
        }
        /// <summary>
        /// onEnded(): void;
        /// </summary>
        public void OnEnded()
        {
            JSRef!.CallVoid("onEnded");
        }
        /// <summary>
        /// getVolume(): number;
        /// </summary>
        public float GetVolume()
        {
            return JSRef!.Call<float>("getVolume");
        }
        /// <summary>
        /// getPlaybackRate(): number;
        /// </summary>
        public float GetPlaybackRate()
        {
            return JSRef!.Call<float>("getPlaybackRate");
        }
        /// <summary>
        /// getOutput(): NodeType;
        /// </summary>
        public NodeType GetOutput()
        {
            return JSRef!.Call<NodeType>("getOutput");
        }
        /// <summary>
        /// getLoop(): boolean;
        /// </summary>
        public bool GetLoop()
        {
            return JSRef!.Call<bool>("getLoop");
        }
        /// <summary>
        /// getFilters(): AudioNode[];
        /// </summary>
        public Array<AudioNode> GetFilters()
        {
            return JSRef!.Call<Array<AudioNode>>("getFilters");
        }
        /// <summary>
        /// getFilter(): AudioNode;
        /// </summary>
        public AudioNode GetFilter()
        {
            return JSRef!.Call<AudioNode>("getFilter");
        }
        /// <summary>
        /// getDetune(): number;
        /// </summary>
        public float GetDetune()
        {
            return JSRef!.Call<float>("getDetune");
        }
        /// <summary>
        /// disconnect(): this;
        /// </summary>
        public Audio Disconnect()
        {
            return JSRef!.Call<Audio>("disconnect");
        }
        /// <summary>
        /// connect(): this;
        /// </summary>
        public Audio Connect()
        {
            return JSRef!.Call<Audio>("connect");
        }
        #endregion
    }
}
