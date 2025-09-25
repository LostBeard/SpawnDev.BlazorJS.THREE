
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ColorSpaceNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ColorSpaceNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         colorNode: Node,
        ///         source: string,
        ///         target: string,
        ///     );
        /// </summary>
        public ColorSpaceNode(Node colorNode, string source, string target) : base(JS.New("THREE.ColorSpaceNode", colorNode, source, target)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// colorNode: Node;
        /// </summary>
        public Node ColorNode { get => JSRef!.Get<Node>("colorNode"); set => JSRef!.Set("colorNode", value); }
        /// <summary>
        /// source: string;
        /// </summary>
        public string Source { get => JSRef!.Get<string>("source"); set => JSRef!.Set("source", value); }
        /// <summary>
        /// target: string;
        /// </summary>
        public string Target { get => JSRef!.Get<string>("target"); set => JSRef!.Set("target", value); }
        #endregion

        #region Methods
        /// <summary>
        /// resolveColorSpace(nodeBuilder: NodeBuilder, colorSpace: WorkingOrOutputColorSpace): string;
        /// </summary>
        public string ResolveColorSpace(NodeBuilder nodeBuilder, WorkingOrOutputColorSpace colorSpace)
        {
            return JSRef!.Call<string>("resolveColorSpace", nodeBuilder, colorSpace);
        }
        #endregion
    }
}
