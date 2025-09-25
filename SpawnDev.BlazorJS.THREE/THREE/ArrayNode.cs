
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ArrayNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ArrayNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeType: string, count: number, values: Node[]);
        /// </summary>
        public ArrayNode(string nodeType, float count, Array<Node> values) : base(JS.New("THREE.ArrayNode", nodeType, count, values)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// count: number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// readonly isArrayNode: true;
        /// </summary>
        public bool IsArrayNode { get => JSRef!.Get<bool>("isArrayNode"); }
        /// <summary>
        /// values: Node[];
        /// </summary>
        public Array<Node> Values { get => JSRef!.Get<Array<Node>>("values"); set => JSRef!.Set("values", value); }
        #endregion

        #region Methods

        #endregion
    }
}
