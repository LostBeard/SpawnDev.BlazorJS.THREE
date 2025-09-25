
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeFunctionInput : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeFunctionInput(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(type: string, name: string, count?: number, qualifier?: string, isConst?: boolean);
        /// </summary>
        public NodeFunctionInput(string type, string name, float count, string qualifier, bool isConst) : base(JS.New("THREE.NodeFunctionInput", type, name, count, qualifier, isConst)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// count: null | number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// isConst: boolean;
        /// </summary>
        public bool IsConst { get => JSRef!.Get<bool>("isConst"); set => JSRef!.Set("isConst", value); }
        /// <summary>
        /// isNodeFunctionInput: true;
        /// </summary>
        public bool IsNodeFunctionInput { get => JSRef!.Get<bool>("isNodeFunctionInput"); set => JSRef!.Set("isNodeFunctionInput", value); }
        /// <summary>
        /// qualifier: string;
        /// </summary>
        public string Qualifier { get => JSRef!.Get<string>("qualifier"); set => JSRef!.Set("qualifier", value); }
        #endregion

        #region Methods

        #endregion
    }
}
