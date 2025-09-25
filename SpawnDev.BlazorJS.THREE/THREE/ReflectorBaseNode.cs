
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ReflectorBaseNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ReflectorBaseNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(textureNode: TextureNode, parameters?: ReflectorNodeParameters);
        /// </summary>
        public ReflectorBaseNode(TextureNode textureNode, ReflectorNodeParameters parameters) : base(JS.New("THREE.ReflectorBaseNode", textureNode, parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bounces: boolean;
        /// </summary>
        public bool Bounces { get => JSRef!.Get<bool>("bounces"); set => JSRef!.Set("bounces", value); }
        /// <summary>
        /// forceUpdate: boolean;
        /// </summary>
        public bool ForceUpdate { get => JSRef!.Get<bool>("forceUpdate"); set => JSRef!.Set("forceUpdate", value); }
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        public bool GenerateMipmaps { get => JSRef!.Get<bool>("generateMipmaps"); set => JSRef!.Set("generateMipmaps", value); }
        /// <summary>
        /// hasOutput: boolean;
        /// </summary>
        public bool HasOutput { get => JSRef!.Get<bool>("hasOutput"); set => JSRef!.Set("hasOutput", value); }
        /// <summary>
        /// renderTargets: Map<Camera, RenderTarget>;
        /// </summary>
        public Map<Camera, RenderTarget> RenderTargets { get => JSRef!.Get<Map<Camera, RenderTarget>>("renderTargets"); set => JSRef!.Set("renderTargets", value); }
        /// <summary>
        /// get resolution(): number;
        /// </summary>
        public float Resolution { get => JSRef!.Get<float>("resolution"); set => JSRef!.Set("resolution", value); }
        /// <summary>
        /// resolutionScale: number;
        /// </summary>
        public float ResolutionScale { get => JSRef!.Get<float>("resolutionScale"); set => JSRef!.Set("resolutionScale", value); }
        /// <summary>
        /// target: Object3D;
        /// </summary>
        public Object3D Target { get => JSRef!.Get<Object3D>("target"); set => JSRef!.Set("target", value); }
        /// <summary>
        /// textureNode: TextureNode;
        /// </summary>
        public TextureNode TextureNode { get => JSRef!.Get<TextureNode>("textureNode"); set => JSRef!.Set("textureNode", value); }
        ///// <summary>
        ///// virtualCameras: WeakMap<Camera, Camera>;
        ///// </summary>
        //public WeakMap<Camera> VirtualCameras { get => JSRef!.Get<WeakMap<Camera>>("virtualCameras"); set => JSRef!.Set("virtualCameras", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getVirtualCamera(camera: Camera): Camera;
        /// </summary>
        public Camera GetVirtualCamera(Camera camera)
        {
            return JSRef!.Call<Camera>("getVirtualCamera", camera);
        }
        /// <summary>
        /// getRenderTarget(camera: Camera): RenderTarget;
        /// </summary>
        public RenderTarget GetRenderTarget(Camera camera)
        {
            return JSRef!.Call<RenderTarget>("getRenderTarget", camera);
        }
        #endregion
    }
}
