
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix4NodeUniform : Matrix4Uniform
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix4NodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeUniform: NodeUniform<Matrix4>);
        /// </summary>
        public Matrix4NodeUniform(NodeUniform<Matrix4> nodeUniform) : base(JS.New("THREE.Matrix4NodeUniform", nodeUniform)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeUniform: NodeUniform<Matrix4>;
        /// </summary>
        public NodeUniform<Matrix4> NodeUniform { get => JSRef!.Get<NodeUniform<Matrix4>>("nodeUniform"); set => JSRef!.Set("nodeUniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getValue(): Matrix4;
        /// </summary>
        public Matrix4 GetValue()
        {
            return JSRef!.Call<Matrix4>("getValue");
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
