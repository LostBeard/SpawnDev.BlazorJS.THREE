
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PostProcessing : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public PostProcessing(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(renderer: Renderer, outputNode?: Node);
        /// </summary>
        public PostProcessing(Renderer renderer, Node outputNode) : base(JS.New("THREE.PostProcessing", renderer, outputNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// needsUpdate: boolean;
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// outputColorTransform: boolean;
        /// </summary>
        public bool OutputColorTransform { get => JSRef!.Get<bool>("outputColorTransform"); set => JSRef!.Set("outputColorTransform", value); }
        /// <summary>
        /// outputNode: Node;
        /// </summary>
        public Node OutputNode { get => JSRef!.Get<Node>("outputNode"); set => JSRef!.Set("outputNode", value); }
        /// <summary>
        /// renderer: Renderer;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        #endregion

        #region Methods
        /// <summary>
        /// renderAsync(): Promise<void>;
        /// </summary>
        public Task RenderAsync()
        {
            return JSRef!.CallVoidAsync("renderAsync");
        }
        /// <summary>
        /// render(): void;
        /// </summary>
        public void Render()
        {
            JSRef!.CallVoid("render");
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
