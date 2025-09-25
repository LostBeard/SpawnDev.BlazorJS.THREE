
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class FunctionOverloadingNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public FunctionOverloadingNode(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(functionNodes?: Node[], ...parameterNodes: Node[]);
        /// </summary>
        public FunctionOverloadingNode(Array<Node> functionNodes, params Node[] parameterNodes) : base(JS.NewApply("THREE.FunctionOverloadingNode", new object[] { functionNodes }.Concat(parameterNodes).ToArray())) { }

        #endregion

        #region Properties
        /// <summary>
        /// functionNodes: Node[];
        /// </summary>
        public Array<Node> FunctionNodes { get => JSRef!.Get<Array<Node>>("functionNodes"); set => JSRef!.Set("functionNodes", value); }
        /// <summary>
        /// parameterNodes: Node[];
        /// </summary>
        public Array<Node> ParameterNodes { get => JSRef!.Get<Array<Node>>("parameterNodes"); set => JSRef!.Set("parameterNodes", value); }
        #endregion

        #region Methods

        #endregion
    }
}
