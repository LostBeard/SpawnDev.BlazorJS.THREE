
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RendererReferenceNode : ReferenceNode<Renderer>
    {
        #region Constructors
        /// <inheritdoc/>
        public RendererReferenceNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(property: string, inputType: string, renderer?: Renderer | null);
        /// </summary>
        public RendererReferenceNode(string property, string inputType, Renderer renderer) : base(JS.New("THREE.RendererReferenceNode", property, inputType, renderer)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// renderer: Renderer | null;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        #endregion

        #region Methods

        #endregion
    }
}
