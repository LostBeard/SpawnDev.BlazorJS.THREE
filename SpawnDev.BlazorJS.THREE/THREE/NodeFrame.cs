
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeFrame : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeFrame(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public NodeFrame() : base(JS.New("THREE.NodeFrame")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// camera: Camera | null;
        /// </summary>
        public Camera Camera { get => JSRef!.Get<Camera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// deltaTime: number;
        /// </summary>
        public float DeltaTime { get => JSRef!.Get<float>("deltaTime"); set => JSRef!.Set("deltaTime", value); }
        /// <summary>
        /// frameBeforeMap: WeakMap<Node, number>;
        /// </summary>
        public WeakMap<Node, float> FrameBeforeMap { get => JSRef!.Get<WeakMap<Node, float>>("frameBeforeMap"); set => JSRef!.Set("frameBeforeMap", value); }
        /// <summary>
        /// frameId: number;
        /// </summary>
        public float FrameId { get => JSRef!.Get<float>("frameId"); set => JSRef!.Set("frameId", value); }
        /// <summary>
        /// frameMap: WeakMap<Node, number>;
        /// </summary>
        public WeakMap<Node, float> FrameMap { get => JSRef!.Get<WeakMap<Node, float>>("frameMap"); set => JSRef!.Set("frameMap", value); }
        /// <summary>
        /// material: Material | null;
        /// </summary>
        public Material Material { get => JSRef!.Get<Material>("material"); set => JSRef!.Set("material", value); }
        /// <summary>
        /// object: Object3D | null;
        /// </summary>
        public Object3D Object { get => JSRef!.Get<Object3D>("object"); set => JSRef!.Set("object", value); }
        /// <summary>
        /// renderBeforeMap: WeakMap<Node, number>;
        /// </summary>
        public WeakMap<Node, float> RenderBeforeMap { get => JSRef!.Get<WeakMap<Node, float>>("renderBeforeMap"); set => JSRef!.Set("renderBeforeMap", value); }
        /// <summary>
        /// renderer: Renderer | null;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        /// <summary>
        /// renderId: number;
        /// </summary>
        public float RenderId { get => JSRef!.Get<float>("renderId"); set => JSRef!.Set("renderId", value); }
        /// <summary>
        /// renderMap: WeakMap<Node, number>;
        /// </summary>
        public WeakMap<Node, float> RenderMap { get => JSRef!.Get<WeakMap<Node, float>>("renderMap"); set => JSRef!.Set("renderMap", value); }
        /// <summary>
        /// scene: Scene | null;
        /// </summary>
        public Scene Scene { get => JSRef!.Get<Scene>("scene"); set => JSRef!.Set("scene", value); }
        /// <summary>
        /// startTime: number | null;
        /// </summary>
        public float StartTime { get => JSRef!.Get<float>("startTime"); set => JSRef!.Set("startTime", value); }
        /// <summary>
        /// time: number;
        /// </summary>
        public float Time { get => JSRef!.Get<float>("time"); set => JSRef!.Set("time", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateNode(node: Node): void;
        /// </summary>
        public void UpdateNode(Node node)
        {
            JSRef!.CallVoid("updateNode", node);
        }
        /// <summary>
        /// updateBeforeNode(node: Node): void;
        /// </summary>
        public void UpdateBeforeNode(Node node)
        {
            JSRef!.CallVoid("updateBeforeNode", node);
        }
        /// <summary>
        /// update(): void;
        /// </summary>
        public void Update()
        {
            JSRef!.CallVoid("update");
        }
        #endregion
    }
}
