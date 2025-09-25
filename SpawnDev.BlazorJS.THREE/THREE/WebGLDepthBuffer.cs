
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLDepthBuffer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLDepthBuffer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public WebGLDepthBuffer() : base(JS.New("THREE.WebGLDepthBuffer")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// setTest(depthTest: boolean): void;
        /// </summary>
        public void SetTest(bool depthTest)
        {
            JSRef!.CallVoid("setTest", depthTest);
        }
        /// <summary>
        /// setReversed(value: boolean): void;
        /// </summary>
        public void SetReversed(bool value)
        {
            JSRef!.CallVoid("setReversed", value);
        }
        /// <summary>
        /// setMask(depthMask: boolean): void;
        /// </summary>
        public void SetMask(bool depthMask)
        {
            JSRef!.CallVoid("setMask", depthMask);
        }
        /// <summary>
        /// setLocked(lock: boolean): void;
        /// </summary>
        public void SetLocked(bool bLock)
        {
            JSRef!.CallVoid("setLocked", bLock);
        }
        /// <summary>
        /// setFunc(depthFunc: DepthModes): void;
        /// </summary>
        public void SetFunc(DepthModes depthFunc)
        {
            JSRef!.CallVoid("setFunc", depthFunc);
        }
        /// <summary>
        /// setClear(depth: number): void;
        /// </summary>
        public void SetClear(float depth)
        {
            JSRef!.CallVoid("setClear", depth);
        }
        /// <summary>
        /// reset(): void;
        /// </summary>
        public void Reset()
        {
            JSRef!.CallVoid("reset");
        }
        /// <summary>
        /// getReversed(): boolean;
        /// </summary>
        public bool GetReversed()
        {
            return JSRef!.Call<bool>("getReversed");
        }
        #endregion
    }
}
