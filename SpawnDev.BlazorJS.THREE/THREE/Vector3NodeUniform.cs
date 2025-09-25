
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector3NodeUniform : Vector3Uniform
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector3NodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeUniform: NodeUniform<Vector3>);
        /// </summary>
        public Vector3NodeUniform(NodeUniform<Vector3> nodeUniform) : base(JS.New("THREE.Vector3NodeUniform", nodeUniform)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeUniform: NodeUniform<Vector3>;
        /// </summary>
        public NodeUniform<Vector3> NodeUniform { get => JSRef!.Get<NodeUniform<Vector3>>("nodeUniform"); set => JSRef!.Set("nodeUniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getValue(): Vector3;
        /// </summary>
        public Vector3 GetValue()
        {
            return JSRef!.Call<Vector3>("getValue");
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
