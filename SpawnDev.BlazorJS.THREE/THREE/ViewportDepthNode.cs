
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ViewportDepthNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ViewportDepthNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope: ViewportDepthNodeScope, valueNode?: Node | null);
        /// </summary>
        public ViewportDepthNode(ViewportDepthNodeScope scope, Node valueNode) : base(JS.New("THREE.ViewportDepthNode", scope, valueNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static DEPTH: "depth";
        /// </summary>
        public static string DEPTH { get => JS.Get<string>("THREE.ViewportDepthNode.DEPTH"); set => JS.Set("THREE.ViewportDepthNode.DEPTH", value); }
        /// <summary>
        /// static DEPTH_BASE: "depthBase";
        /// </summary>
        public static string DEPTH_BASE { get => JS.Get<string>("THREE.ViewportDepthNode.DEPTH_BASE"); set => JS.Set("THREE.ViewportDepthNode.DEPTH_BASE", value); }
        /// <summary>
        /// readonly isViewportDepthNode: true;
        /// </summary>
        public bool IsViewportDepthNode { get => JSRef!.Get<bool>("isViewportDepthNode"); }
        /// <summary>
        /// static LINEAR_DEPTH: "linearDepth";
        /// </summary>
        public static string LINEAR_DEPTH { get => JS.Get<string>("THREE.ViewportDepthNode.LINEAR_DEPTH"); set => JS.Set("THREE.ViewportDepthNode.LINEAR_DEPTH", value); }
        /// <summary>
        /// scope: ViewportDepthNodeScope;
        /// </summary>
        public ViewportDepthNodeScope Scope { get => JSRef!.Get<ViewportDepthNodeScope>("scope"); set => JSRef!.Set("scope", value); }
        /// <summary>
        /// valueNode: Node;
        /// </summary>
        public Node ValueNode { get => JSRef!.Get<Node>("valueNode"); set => JSRef!.Set("valueNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
