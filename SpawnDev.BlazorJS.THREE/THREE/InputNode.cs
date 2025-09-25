
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InputNode : Node
    {
        /// <inheritdoc/>
        public InputNode(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class InputNode<TValue> : InputNode
    {
        #region Constructors
        /// <inheritdoc/>
        public InputNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(value: Value, nodeType?: string | null);
        /// </summary>
        public InputNode(TValue value, string nodeType) : base(JS.New("THREE.InputNode", value, nodeType)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// isInputNode: true;
        /// </summary>
        public bool IsInputNode { get => JSRef!.Get<bool>("isInputNode"); set => JSRef!.Set("isInputNode", value); }
        /// <summary>
        /// precision: Precision | null;
        /// </summary>
        public Precision Precision { get => JSRef!.Get<Precision>("precision"); set => JSRef!.Set("precision", value); }
        /// <summary>
        /// value: Value;
        /// </summary>
        public TValue Value { get => JSRef!.Get<TValue>("value"); set => JSRef!.Set("value", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setPrecision(precision: Precision): this;
        /// </summary>
        public InputNode SetPrecision(Precision precision)
        {
            return JSRef!.Call<InputNode>("setPrecision", precision);
        }
        /// <summary>
        /// getInputType(builder: NodeBuilder): string | null;
        /// </summary>
        public string GetInputType(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getInputType", builder);
        }
        #endregion
    }
}
