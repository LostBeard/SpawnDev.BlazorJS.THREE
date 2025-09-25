
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeBuilderState : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeBuilderState(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         vertexShader: string | null,
        ///         fragmentShader: string | null,
        ///         computeShader: string | null,
        ///         nodeAttributes: NodeAttribute[],
        ///         bindings: BindGroup[],
        ///         updateNodes: Node[],
        ///         updateBeforeNodes: Node[],
        ///         updateAfterNodes: Node[],
        ///         observer: NodeMaterialObserver,
        ///         transforms?: never[],
        ///     );
        /// </summary>
        public NodeBuilderState(string vertexShader, string fragmentShader, string computeShader, Array<NodeAttribute> nodeAttributes, Array<BindGroup> bindings, Array<Node> updateNodes, Array<Node> updateBeforeNodes, Array<Node> updateAfterNodes, NodeMaterialObserver observer, Array<object> transforms) : base(JS.New("THREE.NodeBuilderState", vertexShader, fragmentShader, computeShader, nodeAttributes, bindings, updateNodes, updateBeforeNodes, updateAfterNodes, observer, transforms)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bindings: BindGroup[];
        /// </summary>
        public Array<BindGroup> Bindings { get => JSRef!.Get<Array<BindGroup>>("bindings"); set => JSRef!.Set("bindings", value); }
        /// <summary>
        /// computeShader: string | null;
        /// </summary>
        public string ComputeShader { get => JSRef!.Get<string>("computeShader"); set => JSRef!.Set("computeShader", value); }
        /// <summary>
        /// fragmentShader: string | null;
        /// </summary>
        public string FragmentShader { get => JSRef!.Get<string>("fragmentShader"); set => JSRef!.Set("fragmentShader", value); }
        /// <summary>
        /// nodeAttributes: NodeAttribute[];
        /// </summary>
        public Array<NodeAttribute> NodeAttributes { get => JSRef!.Get<Array<NodeAttribute>>("nodeAttributes"); set => JSRef!.Set("nodeAttributes", value); }
        /// <summary>
        /// observer: NodeMaterialObserver;
        /// </summary>
        public NodeMaterialObserver Observer { get => JSRef!.Get<NodeMaterialObserver>("observer"); set => JSRef!.Set("observer", value); }
        /// <summary>
        /// transforms: never[];
        /// </summary>
        public Array<object> Transforms { get => JSRef!.Get<Array<object>>("transforms"); set => JSRef!.Set("transforms", value); }
        /// <summary>
        /// updateAfterNodes: Node[];
        /// </summary>
        public Array<Node> UpdateAfterNodes { get => JSRef!.Get<Array<Node>>("updateAfterNodes"); set => JSRef!.Set("updateAfterNodes", value); }
        /// <summary>
        /// updateBeforeNodes: Node[];
        /// </summary>
        public Array<Node> UpdateBeforeNodes { get => JSRef!.Get<Array<Node>>("updateBeforeNodes"); set => JSRef!.Set("updateBeforeNodes", value); }
        /// <summary>
        /// updateNodes: Node[];
        /// </summary>
        public Array<Node> UpdateNodes { get => JSRef!.Get<Array<Node>>("updateNodes"); set => JSRef!.Set("updateNodes", value); }
        /// <summary>
        /// usedTimes: number;
        /// </summary>
        public float UsedTimes { get => JSRef!.Get<float>("usedTimes"); set => JSRef!.Set("usedTimes", value); }
        /// <summary>
        /// vertexShader: string | null;
        /// </summary>
        public string VertexShader { get => JSRef!.Get<string>("vertexShader"); set => JSRef!.Set("vertexShader", value); }
        #endregion

        #region Methods
        /// <summary>
        /// createBindings(): BindGroup[];
        /// </summary>
        public Array<BindGroup> CreateBindings()
        {
            return JSRef!.Call<Array<BindGroup>>("createBindings");
        }
        #endregion
    }
}
