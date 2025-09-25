
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MaxMipLevelNode : UniformNode<float>
    {
        #region Constructors
        /// <inheritdoc/>
        public MaxMipLevelNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(textureNode: TextureNode);
        /// </summary>
        public MaxMipLevelNode(TextureNode textureNode) : base(JS.New("THREE.MaxMipLevelNode", textureNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get texture(): Texture;
        /// </summary>
        public Texture Texture { get => JSRef!.Get<Texture>("texture"); }
        /// <summary>
        /// get textureNode(): TextureNode;
        /// </summary>
        public TextureNode TextureNode { get => JSRef!.Get<TextureNode>("textureNode"); }
        #endregion

        #region Methods

        #endregion
    }
}
