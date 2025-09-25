
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Timer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Timer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Timer() : base(JS.New("THREE.Timer")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// update(timestamp?: number): this;
        /// </summary>
        public Timer Update(float timestamp)
        {
            return JSRef!.Call<Timer>("update", timestamp);
        }
        /// <summary>
        /// setTimescale(timescale: number): this;
        /// </summary>
        public Timer SetTimescale(float timescale)
        {
            return JSRef!.Call<Timer>("setTimescale", timescale);
        }
        /// <summary>
        /// reset(): this;
        /// </summary>
        public Timer Reset()
        {
            return JSRef!.Call<Timer>("reset");
        }
        /// <summary>
        /// getTimescale(): number;
        /// </summary>
        public float GetTimescale()
        {
            return JSRef!.Call<float>("getTimescale");
        }
        /// <summary>
        /// getElapsed(): number;
        /// </summary>
        public float GetElapsed()
        {
            return JSRef!.Call<float>("getElapsed");
        }
        /// <summary>
        /// getDelta(): number;
        /// </summary>
        public float GetDelta()
        {
            return JSRef!.Call<float>("getDelta");
        }
        /// <summary>
        /// dispose(): this;
        /// </summary>
        public Timer Dispose()
        {
            return JSRef!.Call<Timer>("dispose");
        }
        /// <summary>
        /// disconnect(): void;
        /// </summary>
        public void Disconnect()
        {
            JSRef!.CallVoid("disconnect");
        }
        /// <summary>
        /// connect(document: Document): void;
        /// </summary>
        public void Connect(Document document)
        {
            JSRef!.CallVoid("connect", document);
        }
        #endregion
    }
}
