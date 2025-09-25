
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Texture3DNode : TextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public Texture3DNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(value: Texture, uvNode?: ShaderNodeObject<Node> | null, levelNode?: ShaderNodeObject<Node> | null);
        /// </summary>
        public Texture3DNode(Texture value, ShaderNodeObject<Node> uvNode, ShaderNodeObject<Node> levelNode) : base(JS.New("THREE.Texture3DNode", value, uvNode, levelNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isTexture3DNode: true;
        /// </summary>
        public bool IsTexture3DNode { get => JSRef!.Get<bool>("isTexture3DNode"); }
        #endregion

        #region Methods
        /// <summary>
        /// normal(uvNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Normal(Node uvNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("normal", uvNode);
        }
        #endregion
    }
}
