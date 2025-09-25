
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StackNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public StackNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public StackNode() : base(JS.New("THREE.StackNode")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// isStackNode: true;
        /// </summary>
        public bool IsStackNode { get => JSRef!.Get<bool>("isStackNode"); set => JSRef!.Set("isStackNode", value); }
        /// <summary>
        /// nodes: Node[];
        /// </summary>
        public Array<Node> Nodes { get => JSRef!.Get<Array<Node>>("nodes"); set => JSRef!.Set("nodes", value); }
        /// <summary>
        /// outputNode: Node | null;
        /// </summary>
        public Node OutputNode { get => JSRef!.Get<Node>("outputNode"); set => JSRef!.Set("outputNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// Switch(expression: Node): this;
        /// </summary>
        public StackNode Switch(Node expression)
        {
            return JSRef!.Call<StackNode>("Switch", expression);
        }
        /// <summary>
        /// If(boolNode: Node, method: () => void): this;
        /// </summary>
        public StackNode If(Node boolNode, Callback method)
        {
            return JSRef!.Call<StackNode>("If", boolNode, method);
        }
        /// <summary>
        /// ElseIf(boolNode: Node, method: () => void): this;
        /// </summary>
        public StackNode ElseIf(Node boolNode, Callback method)
        {
            return JSRef!.Call<StackNode>("ElseIf", boolNode, method);
        }
        /// <summary>
        /// Else(method: () => void): this;
        /// </summary>
        public StackNode Else(Callback method)
        {
            return JSRef!.Call<StackNode>("Else", method);
        }
        /// <summary>
        /// Default(method: () => void): this;
        /// </summary>
        public StackNode Default(Callback method)
        {
            return JSRef!.Call<StackNode>("Default", method);
        }
        /// <summary>
        /// Case(...params: Node[]): this;
        /// </summary>
        public StackNode Case(params Node[] parameters)
        {
            return JSRef!.CallApply<StackNode>("Case", parameters);
        }
        /// <summary>
        /// add(node: Node): this;
        /// </summary>
        public StackNode Add(Node node)
        {
            return JSRef!.Call<StackNode>("add", node);
        }
        #endregion
    }
}
