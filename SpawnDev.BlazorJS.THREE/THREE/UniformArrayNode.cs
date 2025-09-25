
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class UniformArrayNode : BufferNode<Array<object>>
    {
        #region Constructors
        /// <inheritdoc/>
        public UniformArrayNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(value: object[], elementType?: string | null);
        /// </summary>
        public UniformArrayNode(Array<object> value, string elementType) : base(JS.New("THREE.UniformArrayNode", value, elementType)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// array: object[];
        /// </summary>
        public Array<object> Array { get => JSRef!.Get<Array<object>>("array"); set => JSRef!.Set("array", value); }
        /// <summary>
        /// elementType: string | null;
        /// </summary>
        public string ElementType { get => JSRef!.Get<string>("elementType"); set => JSRef!.Set("elementType", value); }
        /// <summary>
        /// readonly isArrayBufferNode: true;
        /// </summary>
        public bool IsArrayBufferNode { get => JSRef!.Get<bool>("isArrayBufferNode"); }
        /// <summary>
        /// paddedType: string;
        /// </summary>
        public string PaddedType { get => JSRef!.Get<string>("paddedType"); set => JSRef!.Set("paddedType", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getPaddedType(): string;
        /// </summary>
        public string GetPaddedType()
        {
            return JSRef!.Call<string>("getPaddedType");
        }
        /// <summary>
        /// element(indexNode: Node): ShaderNodeObject<UniformArrayElementNode>;
        /// </summary>
        public ShaderNodeObject<UniformArrayElementNode> Element(Node indexNode)
        {
            return JSRef!.Call<ShaderNodeObject<UniformArrayElementNode>>("element", indexNode);
        }
        #endregion
    }
}
