
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class QuadMesh<TGeometry, TMaterial> : Mesh<TGeometry, TMaterial>
    {
        #region Constructors
        /// <inheritdoc/>
        public QuadMesh(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(material?: Material | null);
        /// </summary>
        public QuadMesh(Material material) : base(JS.New("THREE.QuadMesh", material)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// camera: OrthographicCamera;
        /// </summary>
        public OrthographicCamera Camera { get => JSRef!.Get<OrthographicCamera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// readonly isQuadMesh: true;
        /// </summary>
        public bool IsQuadMesh { get => JSRef!.Get<bool>("isQuadMesh"); }
        #endregion

        #region Methods
        /// <summary>
        /// renderAsync(renderer: Renderer): Promise<void>;
        /// </summary>
        public Task RenderAsync(Renderer renderer)
        {
            return JSRef!.CallVoidAsync("renderAsync", renderer);
        }
        /// <summary>
        /// render(renderer: Renderer): void;
        /// </summary>
        public void Render(Renderer renderer)
        {
            JSRef!.CallVoid("render", renderer);
        }
        #endregion
    }
}
