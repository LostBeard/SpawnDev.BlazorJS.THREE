
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SampleNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public SampleNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(callback: (uv: Node) => Node, uvNode?: Node | null);
        /// </summary>
        public SampleNode(Callback callback, Node uv, Node uvNode) : base(JS.New("THREE.SampleNode", callback, uv, uvNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// callback: (uv: Node) => Node;
        /// </summary>
        public FuncCallback<Node, Node> Callback { get => JSRef!.Get<FuncCallback<Node, Node>>("callback"); set => JSRef!.Set("callback", value); }
        /// <summary>
        /// readonly isSampleNode: true;
        /// </summary>
        public bool IsSampleNode { get => JSRef!.Get<bool>("isSampleNode"); }
        /// <summary>
        /// uvNode: Node | null;
        /// </summary>
        public Node UvNode { get => JSRef!.Get<Node>("uvNode"); set => JSRef!.Set("uvNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// sample(uv: Node): Node;
        /// </summary>
        public Node Sample(Node uv)
        {
            return JSRef!.Call<Node>("sample", uv);
        }
        #endregion
    }
}
