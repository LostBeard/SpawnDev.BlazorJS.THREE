
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RTTNode : TextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public RTTNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, width?: number | null, height?: number | null, options?: RTTNodeOptions);
        /// </summary>
        public RTTNode(Node node, float width, float height, RTTNodeOptions options) : base(JS.New("THREE.RTTNode", node, width, height, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get autoResize(): boolean;
        /// </summary>
        public bool AutoResize { get => JSRef!.Get<bool>("autoResize"); }
        /// <summary>
        /// autoUpdate: boolean;
        /// </summary>
        public bool AutoUpdate { get => JSRef!.Get<bool>("autoUpdate"); set => JSRef!.Set("autoUpdate", value); }
        /// <summary>
        /// height: number | null;
        /// </summary>
        public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
        /// <summary>
        /// readonly isRTTNode: true;
        /// </summary>
        public bool IsRTTNode { get => JSRef!.Get<bool>("isRTTNode"); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// pixelRatio?: number;
        /// </summary>
        public float PixelRatio { get => JSRef!.Get<float>("pixelRatio"); set => JSRef!.Set("pixelRatio", value); }
        /// <summary>
        /// renderTarget: RenderTarget | null;
        /// </summary>
        public RenderTarget RenderTarget { get => JSRef!.Get<RenderTarget>("renderTarget"); set => JSRef!.Set("renderTarget", value); }
        /// <summary>
        /// textureNeedsUpdate: boolean;
        /// </summary>
        public bool TextureNeedsUpdate { get => JSRef!.Get<bool>("textureNeedsUpdate"); set => JSRef!.Set("textureNeedsUpdate", value); }
        /// <summary>
        /// width: number | null;
        /// </summary>
        public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setSize(width: number | null, height: number | null): void;
        /// </summary>
        public void SetSize(float width, float height)
        {
            JSRef!.CallVoid("setSize", width, height);
        }
        /// <summary>
        /// setPixelRatio(pixelRatio: number): void;
        /// </summary>
        public void SetPixelRatio(float pixelRatio)
        {
            JSRef!.CallVoid("setPixelRatio", pixelRatio);
        }
        #endregion
    }
}
