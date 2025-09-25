
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ViewportTextureNode : TextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ViewportTextureNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(uvNode?: Node, levelNode?: Node | null, framebufferTexture?: FramebufferTexture | null);
        /// </summary>
        public ViewportTextureNode(Node uvNode, Node levelNode, FramebufferTexture framebufferTexture) : base(JS.New("THREE.ViewportTextureNode", uvNode, levelNode, framebufferTexture)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        public bool GenerateMipmaps { get => JSRef!.Get<bool>("generateMipmaps"); set => JSRef!.Set("generateMipmaps", value); }
        /// <summary>
        /// readonly isOutputTextureNode: true;
        /// </summary>
        public bool IsOutputTextureNode { get => JSRef!.Get<bool>("isOutputTextureNode"); }
        /// <summary>
        /// updateBeforeType: NodeUpdateType;
        /// </summary>
        public NodeUpdateType UpdateBeforeType { get => JSRef!.Get<NodeUpdateType>("updateBeforeType"); set => JSRef!.Set("updateBeforeType", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getTextureForReference(reference?: RenderTarget | null): Texture;
        /// </summary>
        public Texture GetTextureForReference(RenderTarget reference)
        {
            return JSRef!.Call<Texture>("getTextureForReference", reference);
        }
        #endregion
    }
}
