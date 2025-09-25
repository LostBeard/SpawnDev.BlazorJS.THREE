
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class FunctionCallNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public FunctionCallNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        ///// <summary>
        ///// constructor(functionNode?: FunctionNode<P>, parameters?: P);
        ///// </summary>
        //public FunctionCallNode(FunctionNode<P> functionNode, P parameters) : base(JS.New("THREE.FunctionCallNode", functionNode, parameters)) { }
        
        #endregion

        #region Properties
        ///// <summary>
        ///// functionNode: FunctionNode<P>;
        ///// </summary>
        //public FunctionNode<P> FunctionNode { get => JSRef!.Get<FunctionNode<P>>("functionNode"); set => JSRef!.Set("functionNode", value); }
        /// <summary>
        /// parameters: { [name: string]: Node };
        /// </summary>
        public JSObject Parameters { get => JSRef!.Get<JSObject>("parameters"); set => JSRef!.Set("parameters", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setParameters(parameters: P): this;
        /// </summary>
        public FunctionCallNode SetParameters(object parameters)
        {
            return JSRef!.Call<FunctionCallNode>("setParameters", parameters);
        }
        /// <summary>
        /// getParameters(): P;
        /// </summary>
        public JSObject GetParameters()
        {
            return JSRef!.Call<JSObject>("getParameters");
        }
        #endregion
    }
}
