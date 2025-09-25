
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class XRManager : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public XRManager(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(renderer: Renderer, multiview?: boolean);
        /// </summary>
        public XRManager(Renderer renderer, bool multiview) : base(JS.New("THREE.XRManager", renderer, multiview)) { }
        
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
        /// <summary>
        /// Object3DEventMap>;
        /// </summary>
        public Object3DEventMap Object3DEventMap { get => JSRef!.Get<Object3DEventMap>("Object3DEventMap"); set => JSRef!.Set("Object3DEventMap", value); }
        /// <summary>
        /// XRGripSpace;
        /// </summary>
        public XRGripSpace XRGripSpace { get => JSRef!.Get<XRGripSpace>("XRGripSpace"); set => JSRef!.Set("XRGripSpace", value); }
        /// <summary>
        /// XRHandSpace;
        /// </summary>
        public XRHandSpace XRHandSpace { get => JSRef!.Get<XRHandSpace>("XRHandSpace"); set => JSRef!.Set("XRHandSpace", value); }
        /// <summary>
        /// XRTargetRaySpace;
        /// </summary>
        public XRTargetRaySpace XRTargetRaySpace { get => JSRef!.Get<XRTargetRaySpace>("XRTargetRaySpace"); set => JSRef!.Set("XRTargetRaySpace", value); }
        #endregion

        #region Methods
        /// <summary>
        /// useMultiview(): boolean;
        /// </summary>
        public bool UseMultiview()
        {
            return JSRef!.Call<bool>("useMultiview");
        }
        /// <summary>
        /// updateCamera(camera: PerspectiveCamera): void;
        /// </summary>
        public void UpdateCamera(PerspectiveCamera camera)
        {
            JSRef!.CallVoid("updateCamera", camera);
        }
        /// <summary>
        /// setSession(session: XRSession): Promise<void>;
        /// </summary>
        public Task SetSession(XRSession session)
        {
            return JSRef!.CallVoidAsync("setSession", session);
        }
        /// <summary>
        /// setReferenceSpaceType(type: XRReferenceSpaceType): void;
        /// </summary>
        public void SetReferenceSpaceType(XRReferenceSpaceType type)
        {
            JSRef!.CallVoid("setReferenceSpaceType", type);
        }
        /// <summary>
        /// setReferenceSpace(space: XRReferenceSpace): void;
        /// </summary>
        public void SetReferenceSpace(XRReferenceSpace space)
        {
            JSRef!.CallVoid("setReferenceSpace", space);
        }
        /// <summary>
        /// setFramebufferScaleFactor(factor: number): void;
        /// </summary>
        public void SetFramebufferScaleFactor(float factor)
        {
            JSRef!.CallVoid("setFramebufferScaleFactor", factor);
        }
        /// <summary>
        /// setFoveation(foveation: number): void;
        /// </summary>
        public void SetFoveation(float foveation)
        {
            JSRef!.CallVoid("setFoveation", foveation);
        }
        /// <summary>
        /// renderLayers(): void;
        /// </summary>
        public void RenderLayers()
        {
            JSRef!.CallVoid("renderLayers");
        }
        /// <summary>
        /// import(
        /// </summary>
        public object Import()
        {
            return JSRef!.Call<object>("import");
        }
        /// <summary>
        /// getSession(): XRSession | null;
        /// </summary>
        public XRSession GetSession()
        {
            return JSRef!.Call<XRSession>("getSession");
        }
        /// <summary>
        /// getReferenceSpaceType(): XRReferenceSpaceType;
        /// </summary>
        public XRReferenceSpaceType GetReferenceSpaceType()
        {
            return JSRef!.Call<XRReferenceSpaceType>("getReferenceSpaceType");
        }
        /// <summary>
        /// getReferenceSpace(): XRReferenceSpace | null;
        /// </summary>
        public XRReferenceSpace GetReferenceSpace()
        {
            return JSRef!.Call<XRReferenceSpace>("getReferenceSpace");
        }
        /// <summary>
        /// getHand(index: number):
        /// </summary>
        public object GetHand(float index)
        {
            return JSRef!.Call<object>("getHand", index);
        }
        /// <summary>
        /// getFramebufferScaleFactor(): number;
        /// </summary>
        public float GetFramebufferScaleFactor()
        {
            return JSRef!.Call<float>("getFramebufferScaleFactor");
        }
        /// <summary>
        /// getFrame(): XRFrame | null;
        /// </summary>
        public XRFrame GetFrame()
        {
            return JSRef!.Call<XRFrame>("getFrame");
        }
        /// <summary>
        /// getFoveation(): number | undefined;
        /// </summary>
        public float GetFoveation()
        {
            return JSRef!.Call<float>("getFoveation");
        }
        /// <summary>
        /// getEnvironmentBlendMode(): XREnvironmentBlendMode | undefined;
        /// </summary>
        public XREnvironmentBlendMode GetEnvironmentBlendMode()
        {
            return JSRef!.Call<XREnvironmentBlendMode>("getEnvironmentBlendMode");
        }
        /// <summary>
        /// getControllerGrip(index: number):
        /// </summary>
        public object GetControllerGrip(float index)
        {
            return JSRef!.Call<object>("getControllerGrip", index);
        }
        /// <summary>
        /// getController(index: number):
        /// </summary>
        public object GetController(float index)
        {
            return JSRef!.Call<object>("getController", index);
        }
        /// <summary>
        /// getCamera(): ArrayCamera;
        /// </summary>
        public ArrayCamera GetCamera()
        {
            return JSRef!.Call<ArrayCamera>("getCamera");
        }
        /// <summary>
        /// getBinding(): XRWebGLBinding | null;
        /// </summary>
        public XRWebGLBinding GetBinding()
        {
            return JSRef!.Call<XRWebGLBinding>("getBinding");
        }
        /// <summary>
        /// createQuadLayer(
        ///         width: number,
        ///         height: number,
        ///         translation: Vector3,
        ///         quaternion: Quaternion,
        ///         pixelwidth: number,
        ///         pixelheight: number,
        ///         rendercall: () => void,
        ///         attributes?: LayerAttributes,
        ///     ): Mesh<PlaneGeometry, MeshBasicMaterial,
        /// </summary>
        public object CreateQuadLayer(float width, float height, Vector3 translation, Quaternion quaternion, float pixelwidth, float pixelheight, Callback rendercall, LayerAttributes attributes)
        {
            return JSRef!.Call<object>("createQuadLayer", width, height, translation, quaternion, pixelwidth, pixelheight, rendercall, attributes);
        }
        /// <summary>
        /// createCylinderLayer(
        ///         radius: number,
        ///         centralAngle: number,
        ///         aspectratio: number,
        ///         translation: Vector3,
        ///         quaternion: Quaternion,
        ///         pixelwidth: number,
        ///         pixelheight: number,
        ///         rendercall: () => void,
        ///         attributes?: LayerAttributes,
        ///     ): Mesh<CylinderGeometry, MeshBasicMaterial,
        /// </summary>
        public object CreateCylinderLayer(float radius, float centralAngle, float aspectratio, Vector3 translation, Quaternion quaternion, float pixelwidth, float pixelheight, Callback rendercall, LayerAttributes attributes)
        {
            return JSRef!.Call<object>("createCylinderLayer", radius, centralAngle, aspectratio, translation, quaternion, pixelwidth, pixelheight, rendercall, attributes);
        }
        #endregion
    }
}
