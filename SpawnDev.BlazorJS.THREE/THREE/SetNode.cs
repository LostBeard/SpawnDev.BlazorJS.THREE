
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SetNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public SetNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(sourceNode: Node, components: string[], targetNode: Node);
        /// </summary>
        public SetNode(Node sourceNode, Array<string> components, Node targetNode) : base(JS.New("THREE.SetNode", sourceNode, components, targetNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// components: string[];
        /// </summary>
        public Array<string> Components { get => JSRef!.Get<Array<string>>("components"); set => JSRef!.Set("components", value); }
        /// <summary>
        /// sourceNode: Node;
        /// </summary>
        public Node SourceNode { get => JSRef!.Get<Node>("sourceNode"); set => JSRef!.Set("sourceNode", value); }
        /// <summary>
        /// targetNode: Node;
        /// </summary>
        public Node TargetNode { get => JSRef!.Get<Node>("targetNode"); set => JSRef!.Set("targetNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
