
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderOutputNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderOutputNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(colorNode: Node, toneMapping?: ToneMapping | null, outputColorSpace?: string | null);
        /// </summary>
        public RenderOutputNode(Node colorNode, ToneMapping toneMapping, string outputColorSpace) : base(JS.New("THREE.RenderOutputNode", colorNode, toneMapping, outputColorSpace)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// colorNode: Node;
        /// </summary>
        public Node ColorNode { get => JSRef!.Get<Node>("colorNode"); set => JSRef!.Set("colorNode", value); }
        /// <summary>
        /// readonly isRenderOutput: true;
        /// </summary>
        public bool IsRenderOutput { get => JSRef!.Get<bool>("isRenderOutput"); }
        /// <summary>
        /// outputColorSpace: string | null;
        /// </summary>
        public string OutputColorSpace { get => JSRef!.Get<string>("outputColorSpace"); set => JSRef!.Set("outputColorSpace", value); }
        /// <summary>
        /// toneMapping: ToneMapping | null;
        /// </summary>
        public ToneMapping ToneMapping { get => JSRef!.Get<ToneMapping>("toneMapping"); set => JSRef!.Set("toneMapping", value); }
        #endregion

        #region Methods

        #endregion
    }
}
