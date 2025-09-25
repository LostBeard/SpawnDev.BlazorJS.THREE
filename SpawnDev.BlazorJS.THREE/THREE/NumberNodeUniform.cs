
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NumberNodeUniform : NumberUniform
    {
        #region Constructors
        /// <inheritdoc/>
        public NumberNodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeUniform: NodeUniform<number>);
        /// </summary>
        public NumberNodeUniform(NodeUniform<float> nodeUniform) : base(JS.New("THREE.NumberNodeUniform", nodeUniform)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeUniform: NodeUniform<number>;
        /// </summary>
        public NodeUniform<float> NodeUniform { get => JSRef!.Get<NodeUniform<float>>("nodeUniform"); set => JSRef!.Set("nodeUniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getValue(): number;
        /// </summary>
        public float GetValue()
        {
            return JSRef!.Call<float>("getValue");
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
