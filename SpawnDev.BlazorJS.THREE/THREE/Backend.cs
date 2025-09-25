
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Backend : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Backend(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: BackendParameters);
        /// </summary>
        public Backend(BackendParameters parameters) : base(JS.New("THREE.Backend", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// abstract get coordinateSystem(): CoordinateSystem;
        /// </summary>
        public CoordinateSystem CoordinateSystem { get => JSRef!.Get<CoordinateSystem>("coordinateSystem"); }
        /// <summary>
        /// domElement: HTMLCanvasElement | OffscreenCanvas | null;
        /// </summary>
        public Union<HTMLCanvasElement, OffscreenCanvas> DomElement { get => JSRef!.Get<Union<HTMLCanvasElement, OffscreenCanvas>>("domElement"); set => JSRef!.Set("domElement", value); }
        /// <summary>
        /// renderer: Renderer | null;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        #endregion

        #region Methods
        /// <summary>
        /// init(renderer: Renderer): void;
        /// </summary>
        public void Init(Renderer renderer)
        {
            JSRef!.CallVoid("init", renderer);
        }
        /// <summary>
        /// getDomElement(): HTMLCanvasElement | OffscreenCanvas;
        /// </summary>
        public Union<HTMLCanvasElement, OffscreenCanvas> GetDomElement()
        {
            return JSRef!.Call<Union<HTMLCanvasElement, OffscreenCanvas>>("getDomElement");
        }
        #endregion
    }
}
