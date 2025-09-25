
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SkinningNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public SkinningNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(skinnedMesh: SkinnedMesh);
        /// </summary>
        public SkinningNode(SkinnedMesh skinnedMesh) : base(JS.New("THREE.SkinningNode", skinnedMesh)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bindMatrixInverseNode: Node;
        /// </summary>
        public Node BindMatrixInverseNode { get => JSRef!.Get<Node>("bindMatrixInverseNode"); set => JSRef!.Set("bindMatrixInverseNode", value); }
        /// <summary>
        /// bindMatrixNode: Node;
        /// </summary>
        public Node BindMatrixNode { get => JSRef!.Get<Node>("bindMatrixNode"); set => JSRef!.Set("bindMatrixNode", value); }
        /// <summary>
        /// boneMatricesNode: Node;
        /// </summary>
        public Node BoneMatricesNode { get => JSRef!.Get<Node>("boneMatricesNode"); set => JSRef!.Set("boneMatricesNode", value); }
        /// <summary>
        /// positionNode: Node;
        /// </summary>
        public Node PositionNode { get => JSRef!.Get<Node>("positionNode"); set => JSRef!.Set("positionNode", value); }
        /// <summary>
        /// previousBoneMatricesNode: Node | null;
        /// </summary>
        public Node PreviousBoneMatricesNode { get => JSRef!.Get<Node>("previousBoneMatricesNode"); set => JSRef!.Set("previousBoneMatricesNode", value); }
        /// <summary>
        /// skinIndexNode: Node;
        /// </summary>
        public Node SkinIndexNode { get => JSRef!.Get<Node>("skinIndexNode"); set => JSRef!.Set("skinIndexNode", value); }
        /// <summary>
        /// skinnedMesh: SkinnedMesh;
        /// </summary>
        public SkinnedMesh SkinnedMesh { get => JSRef!.Get<SkinnedMesh>("skinnedMesh"); set => JSRef!.Set("skinnedMesh", value); }
        /// <summary>
        /// skinWeightNode: Node;
        /// </summary>
        public Node SkinWeightNode { get => JSRef!.Get<Node>("skinWeightNode"); set => JSRef!.Set("skinWeightNode", value); }
        /// <summary>
        /// toPositionNode: Node;
        /// </summary>
        public Node ToPositionNode { get => JSRef!.Get<Node>("toPositionNode"); set => JSRef!.Set("toPositionNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// needsPreviousBoneMatrices(builder: NodeBuilder): boolean;
        /// </summary>
        public bool NeedsPreviousBoneMatrices(NodeBuilder builder)
        {
            return JSRef!.Call<bool>("needsPreviousBoneMatrices", builder);
        }
        /// <summary>
        /// getSkinnedPosition(boneMatrices?: Node, position?: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> GetSkinnedPosition(Node boneMatrices, Node position)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("getSkinnedPosition", boneMatrices, position);
        }
        /// <summary>
        /// getSkinnedNormal(boneMatrices?: Node, normal?: Node): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> GetSkinnedNormal(Node boneMatrices, Node normal)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("getSkinnedNormal", boneMatrices, normal);
        }
        /// <summary>
        /// getPreviousSkinnedPosition(builder: NodeBuilder): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> GetPreviousSkinnedPosition(NodeBuilder builder)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("getPreviousSkinnedPosition", builder);
        }
        #endregion
    }
}
