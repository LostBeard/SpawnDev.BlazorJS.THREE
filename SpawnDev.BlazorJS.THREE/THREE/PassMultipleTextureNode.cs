
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PassMultipleTextureNode : PassTextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public PassMultipleTextureNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(passNode: PassNode, textureName: string, previousTexture?: boolean);
        /// </summary>
        public PassMultipleTextureNode(PassNode passNode, string textureName, bool previousTexture) : base(JS.New("THREE.PassMultipleTextureNode", passNode, textureName, previousTexture)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// previousTexture: boolean;
        /// </summary>
        public bool PreviousTexture { get => JSRef!.Get<bool>("previousTexture"); set => JSRef!.Set("previousTexture", value); }
        /// <summary>
        /// textureName: string;
        /// </summary>
        public string TextureName { get => JSRef!.Get<string>("textureName"); set => JSRef!.Set("textureName", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateTexture(): void;
        /// </summary>
        public void UpdateTexture()
        {
            JSRef!.CallVoid("updateTexture");
        }
        #endregion
    }
}
