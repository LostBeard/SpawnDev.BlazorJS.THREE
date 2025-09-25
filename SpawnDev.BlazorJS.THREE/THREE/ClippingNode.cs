
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ClippingNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ClippingNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope?: ClippingNodeScope);
        /// </summary>
        public ClippingNode(ClippingNodeScope scope) : base(JS.New("THREE.ClippingNode", scope)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static ALPHA_TO_COVERAGE: "alphaToCoverage";
        /// </summary>
        public static string ALPHA_TO_COVERAGE { get => JS.Get<string>("THREE.ClippingNode.ALPHA_TO_COVERAGE"); set => JS.Set("THREE.ClippingNode.ALPHA_TO_COVERAGE", value); }
        /// <summary>
        /// static DEFAULT: "default";
        /// </summary>
        public static string DEFAULT { get => JS.Get<string>("THREE.ClippingNode.DEFAULT"); set => JS.Set("THREE.ClippingNode.DEFAULT", value); }
        /// <summary>
        /// static HARDWARE: "hardware";
        /// </summary>
        public static string HARDWARE { get => JS.Get<string>("THREE.ClippingNode.HARDWARE"); set => JS.Set("THREE.ClippingNode.HARDWARE", value); }
        /// <summary>
        /// hardwareClipping?: boolean;
        /// </summary>
        public bool HardwareClipping { get => JSRef!.Get<bool>("hardwareClipping"); set => JSRef!.Set("hardwareClipping", value); }
        /// <summary>
        /// scope: ClippingNodeScope;
        /// </summary>
        public ClippingNodeScope Scope { get => JSRef!.Get<ClippingNodeScope>("scope"); set => JSRef!.Set("scope", value); }
        #endregion

        #region Methods

        #endregion
    }
}
