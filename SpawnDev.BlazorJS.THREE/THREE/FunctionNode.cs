
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class FunctionNode : CodeNode
    {
        #region Constructors
        /// <inheritdoc/>
        public FunctionNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(code?: string, includes?: CodeNodeInclude[], language?: string);
        /// </summary>
        public FunctionNode(string code, Array<CodeNodeInclude> includes, string language) : base(JS.New("THREE.FunctionNode", code, includes, language)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// getNodeFunction(builder: NodeBuilder): NodeFunction;
        /// </summary>
        public NodeFunction GetNodeFunction(NodeBuilder builder)
        {
            return JSRef!.Call<NodeFunction>("getNodeFunction", builder);
        }
        /// <summary>
        /// getInputs(builder: NodeBuilder): NodeFunctionInput[];
        /// </summary>
        public Array<NodeFunctionInput> GetInputs(NodeBuilder builder)
        {
            return JSRef!.Call<Array<NodeFunctionInput>>("getInputs", builder);
        }
        /// <summary>
        /// call(parameters: P): FunctionCallNode<P>;
        /// </summary>
        public FunctionCallNode Call(object parameters)
        {
            return JSRef!.Call<FunctionCallNode>("call", parameters);
        }
        #endregion
    }
}
