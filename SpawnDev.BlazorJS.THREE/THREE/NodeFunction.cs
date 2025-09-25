
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeFunction : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeFunction(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(type: string, inputs: NodeFunctionInput[], name?: string, precision?: string);
        /// </summary>
        public NodeFunction(string type, Array<NodeFunctionInput> inputs, string name, string precision) : base(JS.New("THREE.NodeFunction", type, inputs, name, precision)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// inputs: NodeFunctionInput[];
        /// </summary>
        public Array<NodeFunctionInput> Inputs { get => JSRef!.Get<Array<NodeFunctionInput>>("inputs"); set => JSRef!.Set("inputs", value); }
        /// <summary>
        /// isNodeFunction: true;
        /// </summary>
        public bool IsNodeFunction { get => JSRef!.Get<bool>("isNodeFunction"); set => JSRef!.Set("isNodeFunction", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// precision: string;
        /// </summary>
        public string Precision { get => JSRef!.Get<string>("precision"); set => JSRef!.Set("precision", value); }
        /// <summary>
        /// type: string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods
        /// <summary>
        /// abstract getCode(name?: string): string;
        /// </summary>
        public string GetCode(string name)
        {
            return JSRef!.Call<string>("getCode", name);
        }
        #endregion
    }
}
