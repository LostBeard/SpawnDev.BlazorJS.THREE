
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CubeTextureNode : TextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public CubeTextureNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         value: CubeTexture,
        ///         uvNode?: ShaderNodeObject<Node> | null,
        ///         levelNode?: ShaderNodeObject<Node> | null,
        ///         biasNode?: ShaderNodeObject<Node> | null,
        ///     );
        /// </summary>
        public CubeTextureNode(CubeTexture value, ShaderNodeObject<Node> uvNode, ShaderNodeObject<Node> levelNode, ShaderNodeObject<Node> biasNode) : base(JS.New("THREE.CubeTextureNode", value, uvNode, levelNode, biasNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// isCubeTextureNode: boolean;
        /// </summary>
        public bool IsCubeTextureNode { get => JSRef!.Get<bool>("isCubeTextureNode"); set => JSRef!.Set("isCubeTextureNode", value); }
        /// <summary>
        /// levelNode: ShaderNodeObject<Node> | null;
        /// </summary>
        public ShaderNodeObject<Node> LevelNode { get => JSRef!.Get<ShaderNodeObject<Node>>("levelNode"); set => JSRef!.Set("levelNode", value); }
        /// <summary>
        /// uvNode: ShaderNodeObject<Node> | null;
        /// </summary>
        public ShaderNodeObject<Node> UvNode { get => JSRef!.Get<ShaderNodeObject<Node>>("uvNode"); set => JSRef!.Set("uvNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getDefaultUV(): Node;
        /// </summary>
        public Node GetDefaultUV()
        {
            return JSRef!.Call<Node>("getDefaultUV");
        }
        #endregion
    }
}
