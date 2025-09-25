
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Clock : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Clock(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(autoStart?: boolean);
        /// </summary>
        public Clock(bool autoStart) : base(JS.New("THREE.Clock", autoStart)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// autoStart: boolean;
        /// </summary>
        public bool AutoStart { get => JSRef!.Get<bool>("autoStart"); set => JSRef!.Set("autoStart", value); }
        /// <summary>
        /// elapsedTime: number;
        /// </summary>
        public float ElapsedTime { get => JSRef!.Get<float>("elapsedTime"); set => JSRef!.Set("elapsedTime", value); }
        /// <summary>
        /// oldTime: number;
        /// </summary>
        public float OldTime { get => JSRef!.Get<float>("oldTime"); set => JSRef!.Set("oldTime", value); }
        /// <summary>
        /// running: boolean;
        /// </summary>
        public bool Running { get => JSRef!.Get<bool>("running"); set => JSRef!.Set("running", value); }
        /// <summary>
        /// startTime: number;
        /// </summary>
        public float StartTime { get => JSRef!.Get<float>("startTime"); set => JSRef!.Set("startTime", value); }
        #endregion

        #region Methods
        /// <summary>
        /// stop(): void;
        /// </summary>
        public void Stop()
        {
            JSRef!.CallVoid("stop");
        }
        /// <summary>
        /// start(): void;
        /// </summary>
        public void Start()
        {
            JSRef!.CallVoid("start");
        }
        /// <summary>
        /// getElapsedTime(): number;
        /// </summary>
        public float GetElapsedTime()
        {
            return JSRef!.Call<float>("getElapsedTime");
        }
        /// <summary>
        /// getDelta(): number;
        /// </summary>
        public float GetDelta()
        {
            return JSRef!.Call<float>("getDelta");
        }
        #endregion
    }
}
