
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PosterizeNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public PosterizeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(sourceNode: Node, stepsNode: Node);
        /// </summary>
        public PosterizeNode(Node sourceNode, Node stepsNode) : base(JS.New("THREE.PosterizeNode", sourceNode, stepsNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// sourceNode: Node;
        /// </summary>
        public Node SourceNode { get => JSRef!.Get<Node>("sourceNode"); set => JSRef!.Set("sourceNode", value); }
        /// <summary>
        /// stepsNode: Node;
        /// </summary>
        public Node StepsNode { get => JSRef!.Get<Node>("stepsNode"); set => JSRef!.Set("stepsNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
