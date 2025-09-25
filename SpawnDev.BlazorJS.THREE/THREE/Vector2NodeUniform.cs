
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector2NodeUniform : Vector2Uniform
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector2NodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeUniform: NodeUniform<Vector2>);
        /// </summary>
        public Vector2NodeUniform(NodeUniform<Vector2> nodeUniform) : base(JS.New("THREE.Vector2NodeUniform", nodeUniform)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeUniform: NodeUniform<Vector2>;
        /// </summary>
        public NodeUniform<Vector2> NodeUniform { get => JSRef!.Get<NodeUniform<Vector2>>("nodeUniform"); set => JSRef!.Set("nodeUniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getValue(): Vector2;
        /// </summary>
        public Vector2 GetValue()
        {
            return JSRef!.Call<Vector2>("getValue");
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
