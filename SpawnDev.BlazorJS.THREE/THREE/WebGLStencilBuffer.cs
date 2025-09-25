
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLStencilBuffer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLStencilBuffer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public WebGLStencilBuffer() : base(JS.New("THREE.WebGLStencilBuffer")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// setTest(stencilTest: boolean): void;
        /// </summary>
        public void SetTest(bool stencilTest)
        {
            JSRef!.CallVoid("setTest", stencilTest);
        }
        /// <summary>
        /// setOp(stencilFail: number, stencilZFail: number, stencilZPass: number): void;
        /// </summary>
        public void SetOp(float stencilFail, float stencilZFail, float stencilZPass)
        {
            JSRef!.CallVoid("setOp", stencilFail, stencilZFail, stencilZPass);
        }
        /// <summary>
        /// setMask(stencilMask: number): void;
        /// </summary>
        public void SetMask(float stencilMask)
        {
            JSRef!.CallVoid("setMask", stencilMask);
        }
        /// <summary>
        /// setLocked(lock: boolean): void;
        /// </summary>
        public void SetLocked(bool bLock)
        {
            JSRef!.CallVoid("setLocked", bLock);
        }
        /// <summary>
        /// setFunc(stencilFunc: number, stencilRef: number, stencilMask: number): void;
        /// </summary>
        public void SetFunc(float stencilFunc, float stencilRef, float stencilMask)
        {
            JSRef!.CallVoid("setFunc", stencilFunc, stencilRef, stencilMask);
        }
        /// <summary>
        /// setClear(stencil: number): void;
        /// </summary>
        public void SetClear(float stencil)
        {
            JSRef!.CallVoid("setClear", stencil);
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
