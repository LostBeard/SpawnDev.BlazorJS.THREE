
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ViewportSharedTextureNode : ViewportTextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ViewportSharedTextureNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(uvNode?: Node, levelNode?: Node | null);
        /// </summary>
        public ViewportSharedTextureNode(Node uvNode, Node levelNode) : base(JS.New("THREE.ViewportSharedTextureNode", uvNode, levelNode)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// getTextureForReference(): FramebufferTexture;
        /// </summary>
        public FramebufferTexture GetTextureForReference()
        {
            return JSRef!.Call<FramebufferTexture>("getTextureForReference");
        }
        #endregion
    }
}
