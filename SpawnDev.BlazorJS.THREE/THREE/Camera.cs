
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Camera : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public Camera(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Camera() : base(JS.New("THREE.Camera")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// coordinateSystem: CoordinateSystem;
        /// </summary>
        public CoordinateSystem CoordinateSystem { get => JSRef!.Get<CoordinateSystem>("coordinateSystem"); set => JSRef!.Set("coordinateSystem", value); }
        /// <summary>
        /// readonly isCamera: true;
        /// </summary>
        public bool IsCamera { get => JSRef!.Get<bool>("isCamera"); }
        /// <summary>
        /// override layers: Layers;
        /// </summary>
        public Layers Layers { get => JSRef!.Get<Layers>("layers"); set => JSRef!.Set("layers", value); }
        /// <summary>
        /// matrixWorldInverse: Matrix4;
        /// </summary>
        public Matrix4 MatrixWorldInverse { get => JSRef!.Get<Matrix4>("matrixWorldInverse"); set => JSRef!.Set("matrixWorldInverse", value); }
        /// <summary>
        /// projectionMatrix: Matrix4;
        /// </summary>
        public Matrix4 ProjectionMatrix { get => JSRef!.Get<Matrix4>("projectionMatrix"); set => JSRef!.Set("projectionMatrix", value); }
        /// <summary>
        /// projectionMatrixInverse: Matrix4;
        /// </summary>
        public Matrix4 ProjectionMatrixInverse { get => JSRef!.Get<Matrix4>("projectionMatrixInverse"); set => JSRef!.Set("projectionMatrixInverse", value); }
        /// <summary>
        /// get reversedDepth(): boolean;
        /// </summary>
        public bool ReversedDepth { get => JSRef!.Get<bool>("reversedDepth"); }
        /// <summary>
        /// override readonly type: string | "Camera";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// viewport?: Vector4;
        /// </summary>
        public Vector4 Viewport { get => JSRef!.Get<Vector4>("viewport"); set => JSRef!.Set("viewport", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getWorldDirection(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetWorldDirection(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getWorldDirection", target);
        }
        #endregion
    }
}
