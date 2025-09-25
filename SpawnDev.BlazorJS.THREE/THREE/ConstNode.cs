
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ConstNode<Value> : InputNode<Value>
    {
        #region Constructors
        /// <inheritdoc/>
        public ConstNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(value: Value, nodeType?: string | null);
        /// </summary>
        public ConstNode(Value value, string nodeType) : base(JS.New("THREE.ConstNode", value, nodeType)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// isConstNode: true;
        /// </summary>
        public bool IsConstNode { get => JSRef!.Get<bool>("isConstNode"); set => JSRef!.Set("isConstNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// generateConst(builder: NodeBuilder): string;
        /// </summary>
        public string GenerateConst(NodeBuilder builder)
        {
            return JSRef!.Call<string>("generateConst", builder);
        }
        #endregion
    }
}
