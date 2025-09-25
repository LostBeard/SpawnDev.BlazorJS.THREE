
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebXRController : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebXRController(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public WebXRController() : base(JS.New("THREE.WebXRController")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// update(inputSource: XRInputSource, frame: XRFrame, referenceSpace: XRReferenceSpace): this;
        /// </summary>
        public WebXRController Update(XRInputSource inputSource, XRFrame frame, XRReferenceSpace referenceSpace)
        {
            return JSRef!.Call<WebXRController>("update", inputSource, frame, referenceSpace);
        }
        /// <summary>
        /// getTargetRaySpace(): XRTargetRaySpace;
        /// </summary>
        public XRTargetRaySpace GetTargetRaySpace()
        {
            return JSRef!.Call<XRTargetRaySpace>("getTargetRaySpace");
        }
        /// <summary>
        /// getHandSpace(): XRHandSpace;
        /// </summary>
        public XRHandSpace GetHandSpace()
        {
            return JSRef!.Call<XRHandSpace>("getHandSpace");
        }
        /// <summary>
        /// getGripSpace(): XRGripSpace;
        /// </summary>
        public XRGripSpace GetGripSpace()
        {
            return JSRef!.Call<XRGripSpace>("getGripSpace");
        }
        /// <summary>
        /// dispatchEvent(event: { type: XRControllerEventType; data?: XRInputSource }): this;
        /// </summary>
        public WebXRController DispatchEvent(object ev)
        {
            return JSRef!.Call<WebXRController>("dispatchEvent", ev);
        }
        /// <summary>
        /// disconnect(inputSource: XRInputSource): this;
        /// </summary>
        public WebXRController Disconnect(XRInputSource inputSource)
        {
            return JSRef!.Call<WebXRController>("disconnect", inputSource);
        }
        /// <summary>
        /// connect(inputSource: XRInputSource): this;
        /// </summary>
        public WebXRController Connect(XRInputSource inputSource)
        {
            return JSRef!.Call<WebXRController>("connect", inputSource);
        }
        #endregion
    }
}
