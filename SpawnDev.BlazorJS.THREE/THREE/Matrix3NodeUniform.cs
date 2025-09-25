
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix3NodeUniform : Matrix3Uniform
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix3NodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeUniform: NodeUniform<Matrix3>);
        /// </summary>
        public Matrix3NodeUniform(NodeUniform<Matrix3> nodeUniform) : base(JS.New("THREE.Matrix3NodeUniform", nodeUniform)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeUniform: NodeUniform<Matrix3>;
        /// </summary>
        public NodeUniform<Matrix3> NodeUniform { get => JSRef!.Get<NodeUniform<Matrix3>>("nodeUniform"); set => JSRef!.Set("nodeUniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getValue(): Matrix3;
        /// </summary>
        public Matrix3 GetValue()
        {
            return JSRef!.Call<Matrix3>("getValue");
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
