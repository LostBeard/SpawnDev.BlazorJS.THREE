
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Background : DataMap
    {
        #region Constructors
        /// <inheritdoc/>
        public Background(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(renderer: Renderer, nodes: Nodes);
        /// </summary>
        public Background(Renderer renderer, Nodes nodes) : base(JS.New("THREE.Background", renderer, nodes)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodes: Nodes;
        /// </summary>
        public Nodes Nodes { get => JSRef!.Get<Nodes>("nodes"); set => JSRef!.Set("nodes", value); }
        /// <summary>
        /// renderer: Renderer;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(scene: Scene, renderList: RenderList, renderContext: RenderContext): void;
        /// </summary>
        public void Update(Scene scene, RenderList renderList, RenderContext renderContext)
        {
            JSRef!.CallVoid("update", scene, renderList, renderContext);
        }
        #endregion
    }
}
