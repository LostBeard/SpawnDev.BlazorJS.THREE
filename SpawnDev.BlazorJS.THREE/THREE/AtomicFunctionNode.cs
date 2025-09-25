
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AtomicFunctionNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public AtomicFunctionNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(method: AtomicMethod, pointerNode: Node, valueNode: Node);
        /// </summary>
        public AtomicFunctionNode(AtomicMethod method, Node pointerNode, Node valueNode) : base(JS.New("THREE.AtomicFunctionNode", method, pointerNode, valueNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static ATOMIC_ADD: "atomicAdd";
        /// </summary>
        public static string ATOMIC_ADD { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_ADD"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_ADD", value); }
        /// <summary>
        /// static ATOMIC_AND: "atomicAnd";
        /// </summary>
        public static string ATOMIC_AND { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_AND"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_AND", value); }
        /// <summary>
        /// static ATOMIC_LOAD: "atomicLoad";
        /// </summary>
        public static string ATOMIC_LOAD { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_LOAD"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_LOAD", value); }
        /// <summary>
        /// static ATOMIC_MAX: "atomicMax";
        /// </summary>
        public static string ATOMIC_MAX { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_MAX"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_MAX", value); }
        /// <summary>
        /// static ATOMIC_MIN: "atomicMin";
        /// </summary>
        public static string ATOMIC_MIN { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_MIN"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_MIN", value); }
        /// <summary>
        /// static ATOMIC_OR: "atomicOr";
        /// </summary>
        public static string ATOMIC_OR { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_OR"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_OR", value); }
        /// <summary>
        /// static ATOMIC_STORE: "atomicStore";
        /// </summary>
        public static string ATOMIC_STORE { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_STORE"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_STORE", value); }
        /// <summary>
        /// static ATOMIC_SUB: "atomicSub";
        /// </summary>
        public static string ATOMIC_SUB { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_SUB"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_SUB", value); }
        /// <summary>
        /// static ATOMIC_XOR: "atomicXor";
        /// </summary>
        public static string ATOMIC_XOR { get => JS.Get<string>("THREE.AtomicFunctionNode.ATOMIC_XOR"); set => JS.Set("THREE.AtomicFunctionNode.ATOMIC_XOR", value); }
        /// <summary>
        /// method: AtomicMethod;
        /// </summary>
        public AtomicMethod Method { get => JSRef!.Get<AtomicMethod>("method"); set => JSRef!.Set("method", value); }
        /// <summary>
        /// parents: boolean;
        /// </summary>
        public bool Parents { get => JSRef!.Get<bool>("parents"); set => JSRef!.Set("parents", value); }
        /// <summary>
        /// pointerNode: Node;
        /// </summary>
        public Node PointerNode { get => JSRef!.Get<Node>("pointerNode"); set => JSRef!.Set("pointerNode", value); }
        /// <summary>
        /// valueNode: Node;
        /// </summary>
        public Node ValueNode { get => JSRef!.Get<Node>("valueNode"); set => JSRef!.Set("valueNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
