
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebXRManager : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public WebXRManager(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(renderer: WebGLRenderer, gl: WebGLRenderingContext);
        /// </summary>
        public WebXRManager(WebGLRenderer renderer, WebGLRenderingContext gl) : base(JS.New("THREE.WebXRManager", renderer, gl)) { }

        #endregion

        #region Properties
        /// <summary>
        /// cameraAutoUpdate: boolean;
        /// </summary>
        public bool CameraAutoUpdate { get => JSRef!.Get<bool>("cameraAutoUpdate"); set => JSRef!.Set("cameraAutoUpdate", value); }
        /// <summary>
        /// enabled: boolean;
        /// </summary>
        public bool Enabled { get => JSRef!.Get<bool>("enabled"); set => JSRef!.Set("enabled", value); }
        /// <summary>
        /// isPresenting: boolean;
        /// </summary>
        public bool IsPresenting { get => JSRef!.Get<bool>("isPresenting"); set => JSRef!.Set("isPresenting", value); }
        #endregion

        #region Methods
        /// <summary>
        /// (camera: PerspectiveCamera) => void
        /// </summary>
        public void UpdateCamera(PerspectiveCamera camera)
        {
            JSRef!.CallVoid("updateCamera", camera);
        }
        /// <summary>
        /// (value: XRSession | null) => Promise<void>
        /// </summary>
        public Task SetSession(XRSession value)
        {
            return JSRef!.CallVoidAsync("setSession", value);
        }
        /// <summary>
        /// (value: XRReferenceSpaceType) => void
        /// </summary>
        public void SetReferenceSpaceType(XRReferenceSpaceType value)
        {
            JSRef!.CallVoid("setReferenceSpaceType", value);
        }
        /// <summary>
        /// (value: XRReferenceSpace) => void
        /// </summary>
        public void SetReferenceSpace(XRReferenceSpace value)
        {
            JSRef!.CallVoid("setReferenceSpace", value);
        }
        /// <summary>
        /// (value: number) => void
        /// </summary>
        public void SetFramebufferScaleFactor(float value)
        {
            JSRef!.CallVoid("setFramebufferScaleFactor", value);
        }
        /// <summary>
        /// (value: number) => void
        /// </summary>
        public void SetFoveation(float value)
        {
            JSRef!.CallVoid("setFoveation", value);
        }
        /// <summary>
        /// (callback: XRFrameRequestCallback | null) => void
        /// </summary>
        public void SetAnimationLoop(XRFrameRequestCallback callback)
        {
            JSRef!.CallVoid("setAnimationLoop", callback);
        }
        /// <summary>
        /// () => boolean
        /// </summary>
        public bool HasDepthSensing()
        {
            return JSRef!.Call<bool>("hasDepthSensing");
        }
        /// <summary>
        /// () => XRSession | null
        /// </summary>
        public XRSession GetSession()
        {
            return JSRef!.Call<XRSession>("getSession");
        }
        /// <summary>
        /// () => XRReferenceSpace | null
        /// </summary>
        public XRReferenceSpace GetReferenceSpace()
        {
            return JSRef!.Call<XRReferenceSpace>("getReferenceSpace");
        }
        /// <summary>
        /// (index: number) => XRHandSpace
        /// </summary>
        public XRHandSpace GetHand(float index)
        {
            return JSRef!.Call<XRHandSpace>("getHand", index);
        }
        /// <summary>
        /// () => XRFrame
        /// </summary>
        public XRFrame GetFrame()
        {
            return JSRef!.Call<XRFrame>("getFrame");
        }
        /// <summary>
        /// () => number | undefined
        /// </summary>
        public float GetFoveation()
        {
            return JSRef!.Call<float>("getFoveation");
        }
        /// <summary>
        /// () => XREnvironmentBlendMode | undefined
        /// </summary>
        public XREnvironmentBlendMode GetEnvironmentBlendMode()
        {
            return JSRef!.Call<XREnvironmentBlendMode>("getEnvironmentBlendMode");
        }
        /// <summary>
        /// () => ExternalTexture | null
        /// </summary>
        public ExternalTexture GetDepthTexture()
        {
            return JSRef!.Call<ExternalTexture>("getDepthTexture");
        }
        /// <summary>
        /// () => Mesh | null
        /// </summary>
        public Mesh GetDepthSensingMesh()
        {
            return JSRef!.Call<Mesh>("getDepthSensingMesh");
        }
        /// <summary>
        /// (index: number) => XRGripSpace
        /// </summary>
        public XRGripSpace GetControllerGrip(float index)
        {
            return JSRef!.Call<XRGripSpace>("getControllerGrip", index);
        }
        /// <summary>
        /// (index: number) => XRTargetRaySpace
        /// </summary>
        public XRTargetRaySpace GetController(float index)
        {
            return JSRef!.Call<XRTargetRaySpace>("getController", index);
        }
        /// <summary>
        /// (xrCamera: WebXRCamera) => ExternalTexture | undefined
        /// </summary>
        public ExternalTexture GetCameraTexture(WebXRCamera xrCamera)
        {
            return JSRef!.Call<ExternalTexture>("getCameraTexture", xrCamera);
        }
        /// <summary>
        /// () => WebXRArrayCamera
        /// </summary>
        public WebXRArrayCamera GetCamera()
        {
            return JSRef!.Call<WebXRArrayCamera>("getCamera");
        }
        /// <summary>
        /// () => XRWebGLBinding
        /// </summary>
        public XRWebGLBinding GetBinding()
        {
            return JSRef!.Call<XRWebGLBinding>("getBinding");
        }
        /// <summary>
        /// () => XRWebGLLayer | XRProjectionLayer
        /// </summary>
        public XRLayer GetBaseLayer()
        {
            return JSRef!.Call<XRLayer>("getBaseLayer");
        }
        /// <summary>
        /// () => void
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
