
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class VaryingNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public VaryingNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, name?: string | null);
        /// </summary>
        public VaryingNode(Node node, string name) : base(JS.New("THREE.VaryingNode", node, name)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// interpolationSampling: InterpolationSamplingMode | null;
        /// </summary>
        public InterpolationSamplingMode InterpolationSampling { get => JSRef!.Get<InterpolationSamplingMode>("interpolationSampling"); set => JSRef!.Set("interpolationSampling", value); }
        /// <summary>
        /// interpolationType: InterpolationSamplingType | null;
        /// </summary>
        public InterpolationSamplingType InterpolationType { get => JSRef!.Get<InterpolationSamplingType>("interpolationType"); set => JSRef!.Set("interpolationType", value); }
        /// <summary>
        /// readonly isVaryingNode: true;
        /// </summary>
        public bool IsVaryingNode { get => JSRef!.Get<bool>("isVaryingNode"); }
        /// <summary>
        /// name: string | null;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setupVarying(builder: NodeBuilder): NodeVarying;
        /// </summary>
        public NodeVarying SetupVarying(NodeBuilder builder)
        {
            return JSRef!.Call<NodeVarying>("setupVarying", builder);
        }
        /// <summary>
        /// setInterpolation(type: InterpolationSamplingType | null, sampling?: InterpolationSamplingMode | null): this;
        /// </summary>
        public VaryingNode SetInterpolation(InterpolationSamplingType type, InterpolationSamplingMode sampling)
        {
            return JSRef!.Call<VaryingNode>("setInterpolation", type, sampling);
        }
        #endregion
    }
}
