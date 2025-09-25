
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGPURenderer : Renderer
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGPURenderer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: WebGPURendererParameters);
        /// </summary>
        public WebGPURenderer(WebGPURendererParameters parameters) : base(JS.New("THREE.WebGPURenderer", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isWebGPURenderer: true;
        /// </summary>
        public bool IsWebGPURenderer { get => JSRef!.Get<bool>("isWebGPURenderer"); }
        /// <summary>
        /// library: StandardNodeLibrary;
        /// </summary>
        public StandardNodeLibrary Library { get => JSRef!.Get<StandardNodeLibrary>("library"); set => JSRef!.Set("library", value); }
        #endregion

        #region Methods

        #endregion
    }
}
