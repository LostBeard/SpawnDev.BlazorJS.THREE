
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector4NodeUniform : Vector4Uniform
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector4NodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeUniform: NodeUniform<Vector4>);
        /// </summary>
        public Vector4NodeUniform(NodeUniform<Vector4> nodeUniform) : base(JS.New("THREE.Vector4NodeUniform", nodeUniform)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeUniform: NodeUniform<Vector4>;
        /// </summary>
        public NodeUniform<Vector4> NodeUniform { get => JSRef!.Get<NodeUniform<Vector4>>("nodeUniform"); set => JSRef!.Set("nodeUniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getValue(): Vector4;
        /// </summary>
        public Vector4 GetValue()
        {
            return JSRef!.Call<Vector4>("getValue");
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
