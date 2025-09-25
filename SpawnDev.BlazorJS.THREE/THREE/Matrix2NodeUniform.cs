
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix2NodeUniform : Matrix2Uniform
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix2NodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeUniform: NodeUniform<Matrix2>);
        /// </summary>
        public Matrix2NodeUniform(NodeUniform<Matrix2> nodeUniform) : base(JS.New("THREE.Matrix2NodeUniform", nodeUniform)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeUniform: NodeUniform<Matrix2>;
        /// </summary>
        public NodeUniform<Matrix2> NodeUniform { get => JSRef!.Get<NodeUniform<Matrix2>>("nodeUniform"); set => JSRef!.Set("nodeUniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getValue(): Matrix2;
        /// </summary>
        public Matrix2 GetValue()
        {
            return JSRef!.Call<Matrix2>("getValue");
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
