
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLColorBuffer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLColorBuffer(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// setMask(colorMask: boolean): void;
        /// </summary>
        public void SetMask(bool colorMask)
        {
            JSRef!.CallVoid("setMask", colorMask);
        }
        /// <summary>
        /// setLocked(lock: boolean): void;
        /// </summary>
        public void SetLocked(bool bLock)
        {
            JSRef!.CallVoid("setLocked", bLock);
        }
        /// <summary>
        /// setClear(r: number, g: number, b: number, a: number, premultipliedAlpha: boolean): void;
        /// </summary>
        public void SetClear(float r, float g, float b, float a, bool premultipliedAlpha)
        {
            JSRef!.CallVoid("setClear", r, g, b, a, premultipliedAlpha);
        }
        /// <summary>
        /// reset(): void;
        /// </summary>
        public void Reset()
        {
            JSRef!.CallVoid("reset");
        }
        #endregion
    }
}
