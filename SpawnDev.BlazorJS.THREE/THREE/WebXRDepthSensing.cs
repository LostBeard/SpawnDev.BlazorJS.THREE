
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebXRDepthSensing : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebXRDepthSensing(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public WebXRDepthSensing() : base(JS.New("THREE.WebXRDepthSensing")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// depthFar: number;
        /// </summary>
        public float DepthFar { get => JSRef!.Get<float>("depthFar"); set => JSRef!.Set("depthFar", value); }
        /// <summary>
        /// depthNear: number;
        /// </summary>
        public float DepthNear { get => JSRef!.Get<float>("depthNear"); set => JSRef!.Set("depthNear", value); }
        /// <summary>
        /// mesh: Mesh | null;
        /// </summary>
        public Mesh Mesh { get => JSRef!.Get<Mesh>("mesh"); set => JSRef!.Set("mesh", value); }
        /// <summary>
        /// texture: ExternalTexture | null;
        /// </summary>
        public ExternalTexture Texture { get => JSRef!.Get<ExternalTexture>("texture"); set => JSRef!.Set("texture", value); }
        #endregion

        #region Methods
        /// <summary>
        /// reset(): void;
        /// </summary>
        public void Reset()
        {
            JSRef!.CallVoid("reset");
        }
        /// <summary>
        /// init(depthData: XRWebGLDepthInformation, renderState: XRRenderState): void;
        /// </summary>
        public void Init(XRWebGLDepthInformation depthData, XRRenderState renderState)
        {
            JSRef!.CallVoid("init", depthData, renderState);
        }
        /// <summary>
        /// getMesh(cameraXR: WebXRArrayCamera): Mesh | null;
        /// </summary>
        public Mesh GetMesh(WebXRArrayCamera cameraXR)
        {
            return JSRef!.Call<Mesh>("getMesh", cameraXR);
        }
        /// <summary>
        /// getDepthTexture(): ExternalTexture | null;
        /// </summary>
        public ExternalTexture GetDepthTexture()
        {
            return JSRef!.Call<ExternalTexture>("getDepthTexture");
        }
        #endregion
    }
}
