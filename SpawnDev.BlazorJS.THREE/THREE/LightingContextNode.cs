
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LightingContextNode : ContextNode
    {
        #region Constructors
        /// <inheritdoc/>
        public LightingContextNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         lightsNode: LightsNode,
        ///         lightingModel?: LightingModel | null,
        ///         backdropNode?: Node | null,
        ///         backdropAlphaNode?: Node | null,
        ///     );
        /// </summary>
        public LightingContextNode(LightsNode lightsNode, LightingModel lightingModel, Node backdropNode, Node backdropAlphaNode) : base(JS.New("THREE.LightingContextNode", lightsNode, lightingModel, backdropNode, backdropAlphaNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// backdropAlphaNode: Node | null;
        /// </summary>
        public Node BackdropAlphaNode { get => JSRef!.Get<Node>("backdropAlphaNode"); set => JSRef!.Set("backdropAlphaNode", value); }
        /// <summary>
        /// backdropNode: Node | null;
        /// </summary>
        public Node BackdropNode { get => JSRef!.Get<Node>("backdropNode"); set => JSRef!.Set("backdropNode", value); }
        /// <summary>
        /// lightingModelNode: LightingModel | null;
        /// </summary>
        public LightingModel LightingModelNode { get => JSRef!.Get<LightingModel>("lightingModelNode"); set => JSRef!.Set("lightingModelNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getContext(): LightingContext;
        /// </summary>
        public LightingContext GetContext()
        {
            return JSRef!.Call<LightingContext>("getContext");
        }
        #endregion
    }
}
