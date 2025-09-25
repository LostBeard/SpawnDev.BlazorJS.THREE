
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TextureNode : UniformNode<Texture>
    {
        #region Constructors
        /// <inheritdoc/>
        public TextureNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         value?: Texture,
        ///         uvNode?: ShaderNodeObject<Node> | null,
        ///         levelNode?: ShaderNodeObject<Node> | null,
        ///         biasNode?: ShaderNodeObject<Node> | null,
        ///     );
        /// </summary>
        public TextureNode(Texture value, ShaderNodeObject<Node> uvNode, ShaderNodeObject<Node> levelNode, ShaderNodeObject<Node> biasNode) : base(JS.New("THREE.TextureNode", value, uvNode, levelNode, biasNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// biasNode: ShaderNodeObject<Node> | null;
        /// </summary>
        public ShaderNodeObject<Node> BiasNode { get => JSRef!.Get<ShaderNodeObject<Node>>("biasNode"); set => JSRef!.Set("biasNode", value); }
        /// <summary>
        /// compareNode: Node | null;
        /// </summary>
        public Node CompareNode { get => JSRef!.Get<Node>("compareNode"); set => JSRef!.Set("compareNode", value); }
        /// <summary>
        /// depthNode: Node | null;
        /// </summary>
        public Node DepthNode { get => JSRef!.Get<Node>("depthNode"); set => JSRef!.Set("depthNode", value); }
        /// <summary>
        /// gradNode: Node | null;
        /// </summary>
        public Node GradNode { get => JSRef!.Get<Node>("gradNode"); set => JSRef!.Set("gradNode", value); }
        /// <summary>
        /// readonly isTextureNode: true;
        /// </summary>
        public bool IsTextureNode { get => JSRef!.Get<bool>("isTextureNode"); }
        /// <summary>
        /// levelNode: ShaderNodeObject<Node> | null;
        /// </summary>
        public ShaderNodeObject<Node> LevelNode { get => JSRef!.Get<ShaderNodeObject<Node>>("levelNode"); set => JSRef!.Set("levelNode", value); }
        /// <summary>
        /// referenceNode: Node | null;
        /// </summary>
        public Node ReferenceNode { get => JSRef!.Get<Node>("referenceNode"); set => JSRef!.Set("referenceNode", value); }
        /// <summary>
        /// sampler: boolean;
        /// </summary>
        public bool Sampler { get => JSRef!.Get<bool>("sampler"); set => JSRef!.Set("sampler", value); }
        /// <summary>
        /// updateMatrix: boolean;
        /// </summary>
        public bool UpdateMatrix { get => JSRef!.Get<bool>("updateMatrix"); set => JSRef!.Set("updateMatrix", value); }
        /// <summary>
        /// uvNode: ShaderNodeObject<Node> | null;
        /// </summary>
        public ShaderNodeObject<Node> UvNode { get => JSRef!.Get<ShaderNodeObject<Node>>("uvNode"); set => JSRef!.Set("uvNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// uv(uvNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Uv(Node uvNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("uv", uvNode);
        }
        /// <summary>
        /// size(levelNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Size(Node levelNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("size", levelNode);
        }
        /// <summary>
        /// setSampler(value: boolean): this;
        /// </summary>
        public TextureNode SetSampler(bool value)
        {
            return JSRef!.Call<TextureNode>("setSampler", value);
        }
        /// <summary>
        /// sample(uvNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Sample(Node uvNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("sample", uvNode);
        }
        /// <summary>
        /// load(uvNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Load(Node uvNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("load", uvNode);
        }
        /// <summary>
        /// level(levelNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Level(Node levelNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("level", levelNode);
        }
        /// <summary>
        /// grad(gradeNodeX: Node, gradeNodeY: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Grad(Node gradeNodeX, Node gradeNodeY)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("grad", gradeNodeX, gradeNodeY);
        }
        /// <summary>
        /// getSampler(): boolean;
        /// </summary>
        public bool GetSampler()
        {
            return JSRef!.Call<bool>("getSampler");
        }
        /// <summary>
        /// getDefaultUV(): Node;
        /// </summary>
        public Node GetDefaultUV()
        {
            return JSRef!.Call<Node>("getDefaultUV");
        }
        /// <summary>
        /// getBase(): TextureNode;
        /// </summary>
        public TextureNode GetBase()
        {
            return JSRef!.Call<TextureNode>("getBase");
        }
        /// <summary>
        /// depth(depthNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Depth(Node depthNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("depth", depthNode);
        }
        /// <summary>
        /// compare(compareNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Compare(Node compareNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("compare", compareNode);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public TextureNode Clone()
        {
            return JSRef!.Call<TextureNode>("clone");
        }
        /// <summary>
        /// blur(amountNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Blur(Node amountNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("blur", amountNode);
        }
        /// <summary>
        /// bias(biasNode: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> Bias(Node biasNode)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("bias", biasNode);
        }
        #endregion
    }
}
