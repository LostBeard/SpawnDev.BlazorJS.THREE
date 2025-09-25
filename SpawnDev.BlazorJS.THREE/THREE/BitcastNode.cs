
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BitcastNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public BitcastNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(valueNode: Node, conversionType: string, inputType: string | null);
        /// </summary>
        public BitcastNode(Node valueNode, string conversionType, string inputType) : base(JS.New("THREE.BitcastNode", valueNode, conversionType, inputType)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// conversionType: string;
        /// </summary>
        public string ConversionType { get => JSRef!.Get<string>("conversionType"); set => JSRef!.Set("conversionType", value); }
        /// <summary>
        /// inputType: string | null;
        /// </summary>
        public string InputType { get => JSRef!.Get<string>("inputType"); set => JSRef!.Set("inputType", value); }
        /// <summary>
        /// readonly isBitcastNode: true;
        /// </summary>
        public bool IsBitcastNode { get => JSRef!.Get<bool>("isBitcastNode"); }
        /// <summary>
        /// valueNode: Node;
        /// </summary>
        public Node ValueNode { get => JSRef!.Get<Node>("valueNode"); set => JSRef!.Set("valueNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
