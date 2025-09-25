
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SubgroupFunctionNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public SubgroupFunctionNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(method: SubgroupFunctionNodeMethod0);
        /// </summary>
        public SubgroupFunctionNode(SubgroupFunctionNodeMethod0 method) : base(JS.New("THREE.SubgroupFunctionNode", method)) { }
        
        
        /// <summary>
        /// constructor(method: SubgroupFunctionNodeMethod1, aNode: Node);
        /// </summary>
        public SubgroupFunctionNode(SubgroupFunctionNodeMethod1 method, Node aNode) : base(JS.New("THREE.SubgroupFunctionNode", method, aNode)) { }
        
        
        /// <summary>
        /// constructor(method: SubgroupFunctionNodeMethod2, aNode: Node, bNode: Node);
        /// </summary>
        public SubgroupFunctionNode(SubgroupFunctionNodeMethod2 method, Node aNode, Node bNode) : base(JS.New("THREE.SubgroupFunctionNode", method, aNode, bNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static QUAD_BROADCAST: "quadBroadcast";
        /// </summary>
        public static string QUAD_BROADCAST { get => JS.Get<string>("THREE.SubgroupFunctionNode.QUAD_BROADCAST"); set => JS.Set("THREE.SubgroupFunctionNode.QUAD_BROADCAST", value); }
        /// <summary>
        /// static QUAD_SWAP_DIAGONAL: "quadSwapDiagonal";
        /// </summary>
        public static string QUAD_SWAP_DIAGONAL { get => JS.Get<string>("THREE.SubgroupFunctionNode.QUAD_SWAP_DIAGONAL"); set => JS.Set("THREE.SubgroupFunctionNode.QUAD_SWAP_DIAGONAL", value); }
        /// <summary>
        /// static QUAD_SWAP_X: "quadSwapX";
        /// </summary>
        public static string QUAD_SWAP_X { get => JS.Get<string>("THREE.SubgroupFunctionNode.QUAD_SWAP_X"); set => JS.Set("THREE.SubgroupFunctionNode.QUAD_SWAP_X", value); }
        /// <summary>
        /// static QUAD_SWAP_Y: "quadSwapY";
        /// </summary>
        public static string QUAD_SWAP_Y { get => JS.Get<string>("THREE.SubgroupFunctionNode.QUAD_SWAP_Y"); set => JS.Set("THREE.SubgroupFunctionNode.QUAD_SWAP_Y", value); }
        /// <summary>
        /// static SUBGROUP_ADD: "subgroupAdd";
        /// </summary>
        public static string SUBGROUP_ADD { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_ADD"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_ADD", value); }
        /// <summary>
        /// static SUBGROUP_ALL: "subgroupAll";
        /// </summary>
        public static string SUBGROUP_ALL { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_ALL"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_ALL", value); }
        /// <summary>
        /// static SUBGROUP_AND: "subgroupAnd";
        /// </summary>
        public static string SUBGROUP_AND { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_AND"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_AND", value); }
        /// <summary>
        /// static SUBGROUP_ANY: "subgroupAny";
        /// </summary>
        public static string SUBGROUP_ANY { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_ANY"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_ANY", value); }
        /// <summary>
        /// static SUBGROUP_BALLOT: "subgroupBallot";
        /// </summary>
        public static string SUBGROUP_BALLOT { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_BALLOT"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_BALLOT", value); }
        /// <summary>
        /// static SUBGROUP_BROADCAST: "subgroupBroadcast";
        /// </summary>
        public static string SUBGROUP_BROADCAST { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_BROADCAST"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_BROADCAST", value); }
        /// <summary>
        /// static SUBGROUP_BROADCAST_FIRST: "subgroupBroadcastFirst";
        /// </summary>
        public static string SUBGROUP_BROADCAST_FIRST { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_BROADCAST_FIRST"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_BROADCAST_FIRST", value); }
        /// <summary>
        /// static SUBGROUP_ELECT: "subgroupElect";
        /// </summary>
        public static string SUBGROUP_ELECT { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_ELECT"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_ELECT", value); }
        /// <summary>
        /// static SUBGROUP_EXCLUSIVE_AND: "subgroupExclusiveAdd";
        /// </summary>
        public static string SUBGROUP_EXCLUSIVE_AND { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_EXCLUSIVE_AND"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_EXCLUSIVE_AND", value); }
        /// <summary>
        /// static SUBGROUP_EXCLUSIVE_MUL: "subgroupExclusiveMul";
        /// </summary>
        public static string SUBGROUP_EXCLUSIVE_MUL { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_EXCLUSIVE_MUL"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_EXCLUSIVE_MUL", value); }
        /// <summary>
        /// static SUBGROUP_INCLUSIVE_ADD: "subgroupInclusiveAdd";
        /// </summary>
        public static string SUBGROUP_INCLUSIVE_ADD { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_INCLUSIVE_ADD"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_INCLUSIVE_ADD", value); }
        /// <summary>
        /// static SUBGROUP_INCLUSIVE_MUL: "subgroupInclusiveMul";
        /// </summary>
        public static string SUBGROUP_INCLUSIVE_MUL { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_INCLUSIVE_MUL"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_INCLUSIVE_MUL", value); }
        /// <summary>
        /// static SUBGROUP_MAX: "subgroupMax";
        /// </summary>
        public static string SUBGROUP_MAX { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_MAX"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_MAX", value); }
        /// <summary>
        /// static SUBGROUP_MIN: "subgroupMin";
        /// </summary>
        public static string SUBGROUP_MIN { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_MIN"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_MIN", value); }
        /// <summary>
        /// static SUBGROUP_MUL: "subgroupMul";
        /// </summary>
        public static string SUBGROUP_MUL { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_MUL"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_MUL", value); }
        /// <summary>
        /// static SUBGROUP_OR: "subgroupOr";
        /// </summary>
        public static string SUBGROUP_OR { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_OR"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_OR", value); }
        /// <summary>
        /// static SUBGROUP_SHUFFLE: "subgroupShuffle";
        /// </summary>
        public static string SUBGROUP_SHUFFLE { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_SHUFFLE"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_SHUFFLE", value); }
        /// <summary>
        /// static SUBGROUP_SHUFFLE_DOWN: "subgroupShuffleDown";
        /// </summary>
        public static string SUBGROUP_SHUFFLE_DOWN { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_SHUFFLE_DOWN"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_SHUFFLE_DOWN", value); }
        /// <summary>
        /// static SUBGROUP_SHUFFLE_UP: "subgroupShuffleUp";
        /// </summary>
        public static string SUBGROUP_SHUFFLE_UP { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_SHUFFLE_UP"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_SHUFFLE_UP", value); }
        /// <summary>
        /// static SUBGROUP_SHUFFLE_XOR: "subgroupShuffleXor";
        /// </summary>
        public static string SUBGROUP_SHUFFLE_XOR { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_SHUFFLE_XOR"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_SHUFFLE_XOR", value); }
        /// <summary>
        /// static SUBGROUP_XOR: "subgroupXor";
        /// </summary>
        public static string SUBGROUP_XOR { get => JS.Get<string>("THREE.SubgroupFunctionNode.SUBGROUP_XOR"); set => JS.Set("THREE.SubgroupFunctionNode.SUBGROUP_XOR", value); }
        #endregion

        #region Methods

        #endregion
    }
}
