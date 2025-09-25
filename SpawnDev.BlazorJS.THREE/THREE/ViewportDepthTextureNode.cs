
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ViewportDepthTextureNode : ViewportTextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ViewportDepthTextureNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(uvNode?: Node, levelNode?: Node | null);
        /// </summary>
        public ViewportDepthTextureNode(Node uvNode, Node levelNode) : base(JS.New("THREE.ViewportDepthTextureNode", uvNode, levelNode)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// getTextureForReference(): DepthTexture;
        /// </summary>
        public DepthTexture GetTextureForReference()
        {
            return JSRef!.Call<DepthTexture>("getTextureForReference");
        }
        #endregion
    }
}
