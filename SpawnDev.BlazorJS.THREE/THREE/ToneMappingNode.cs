
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ToneMappingNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ToneMappingNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(toneMapping: ToneMapping, exposureNode?: Node, colorNode?: Node | null);
        /// </summary>
        public ToneMappingNode(ToneMapping toneMapping, Node exposureNode, Node colorNode) : base(JS.New("THREE.ToneMappingNode", toneMapping, exposureNode, colorNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// colorNode: Node | null;
        /// </summary>
        public Node ColorNode { get => JSRef!.Get<Node>("colorNode"); set => JSRef!.Set("colorNode", value); }
        /// <summary>
        /// exposureNode: Node;
        /// </summary>
        public Node ExposureNode { get => JSRef!.Get<Node>("exposureNode"); set => JSRef!.Set("exposureNode", value); }
        /// <summary>
        /// toneMapping: ToneMapping;
        /// </summary>
        public ToneMapping ToneMapping { get => JSRef!.Get<ToneMapping>("toneMapping"); set => JSRef!.Set("toneMapping", value); }
        #endregion

        #region Methods

        #endregion
    }
}
