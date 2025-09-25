
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MRTNode : OutputStructNode
    {
        #region Constructors
        /// <inheritdoc/>
        public MRTNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(outputNodes: { [name: string]: Node });
        /// </summary>
        public MRTNode(object outputNodes, string name) : base(JS.New("THREE.MRTNode", outputNodes, name)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMRTNode: true;
        /// </summary>
        public bool IsMRTNode { get => JSRef!.Get<bool>("isMRTNode"); }
        /// <summary>
        /// outputNodes: { [name: string]: Node };
        /// </summary>
        public object OutputNodes { get => JSRef!.Get<object>("outputNodes"); set => JSRef!.Set("outputNodes", value); }
        #endregion

        #region Methods
        /// <summary>
        /// merge(mrtNode: MRTNode): ShaderNodeObject<MRTNode>;
        /// </summary>
        public ShaderNodeObject<MRTNode> Merge(MRTNode mrtNode)
        {
            return JSRef!.Call<ShaderNodeObject<MRTNode>>("merge", mrtNode);
        }
        /// <summary>
        /// has(name: string): boolean;
        /// </summary>
        public bool Has(string name)
        {
            return JSRef!.Call<bool>("has", name);
        }
        /// <summary>
        /// get(name: string): Node;
        /// </summary>
        public Node Get(string name)
        {
            return JSRef!.Call<Node>("get", name);
        }
        #endregion
    }
}
