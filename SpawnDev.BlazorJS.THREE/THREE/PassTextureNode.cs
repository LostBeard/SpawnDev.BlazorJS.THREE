
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PassTextureNode : TextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public PassTextureNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(passNode: PassNode, texture: Texture);
        /// </summary>
        public PassTextureNode(PassNode passNode, Texture texture) : base(JS.New("THREE.PassTextureNode", passNode, texture)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// passNode: PassNode;
        /// </summary>
        public PassNode PassNode { get => JSRef!.Get<PassNode>("passNode"); set => JSRef!.Set("passNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
