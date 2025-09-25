
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class VelocityNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public VelocityNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public VelocityNode() : base(JS.New("THREE.VelocityNode")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// previousCameraViewMatrix: UniformNode<Matrix4>;
        /// </summary>
        public UniformNode<Matrix4> PreviousCameraViewMatrix { get => JSRef!.Get<UniformNode<Matrix4>>("previousCameraViewMatrix"); set => JSRef!.Set("previousCameraViewMatrix", value); }
        /// <summary>
        /// previousModelWorldMatrix: UniformNode<Matrix4>;
        /// </summary>
        public UniformNode<Matrix4> PreviousModelWorldMatrix { get => JSRef!.Get<UniformNode<Matrix4>>("previousModelWorldMatrix"); set => JSRef!.Set("previousModelWorldMatrix", value); }
        /// <summary>
        /// previousProjectionMatrix: UniformNode<Matrix4>;
        /// </summary>
        public UniformNode<Matrix4> PreviousProjectionMatrix { get => JSRef!.Get<UniformNode<Matrix4>>("previousProjectionMatrix"); set => JSRef!.Set("previousProjectionMatrix", value); }
        /// <summary>
        /// projectionMatrix: Matrix4 | null;
        /// </summary>
        public Matrix4 ProjectionMatrix { get => JSRef!.Get<Matrix4>("projectionMatrix"); set => JSRef!.Set("projectionMatrix", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setProjectionMatrix(projectionMatrix: Matrix4 | null): void;
        /// </summary>
        public void SetProjectionMatrix(Matrix4 projectionMatrix)
        {
            JSRef!.CallVoid("setProjectionMatrix", projectionMatrix);
        }
        #endregion
    }
}
