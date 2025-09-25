
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SplitNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public SplitNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, components?: SwizzleOption);
        /// </summary>
        public SplitNode(Node node, SwizzleOption components) : base(JS.New("THREE.SplitNode", node, components)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// components: string;
        /// </summary>
        public string Components { get => JSRef!.Get<string>("components"); set => JSRef!.Set("components", value); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getVectorLength(): number;
        /// </summary>
        public float GetVectorLength()
        {
            return JSRef!.Call<float>("getVectorLength");
        }
        #endregion
    }
}
