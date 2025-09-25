
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ColorNodeUniform : ColorUniform
    {
        #region Constructors
        /// <inheritdoc/>
        public ColorNodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeUniform: NodeUniform<Color>);
        /// </summary>
        public ColorNodeUniform(NodeUniform<Color> nodeUniform) : base(JS.New("THREE.ColorNodeUniform", nodeUniform)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeUniform: NodeUniform<Color>;
        /// </summary>
        public NodeUniform<Color> NodeUniform { get => JSRef!.Get<NodeUniform<Color>>("nodeUniform"); set => JSRef!.Set("nodeUniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getValue(): Color;
        /// </summary>
        public Color GetValue()
        {
            return JSRef!.Call<Color>("getValue");
        }
        /// <summary>
        /// getType(): string | null;
        /// </summary>
        public string GetType()
        {
            return JSRef!.Call<string>("getType");
        }
        #endregion
    }
}
