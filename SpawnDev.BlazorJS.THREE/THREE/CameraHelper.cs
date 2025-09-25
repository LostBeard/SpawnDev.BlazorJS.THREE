
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CameraHelper : LineSegments
    {
        #region Constructors
        /// <inheritdoc/>
        public CameraHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(camera: Camera);
        /// </summary>
        public CameraHelper(Camera camera) : base(JS.New("THREE.CameraHelper", camera)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// camera: Camera;
        /// </summary>
        public Camera Camera { get => JSRef!.Get<Camera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// matrix: Matrix4;
        /// </summary>
        public Matrix4 Matrix { get => JSRef!.Get<Matrix4>("matrix"); set => JSRef!.Set("matrix", value); }
        /// <summary>
        /// override matrixAutoUpdate: boolean;
        /// </summary>
        public bool MatrixAutoUpdate { get => JSRef!.Get<bool>("matrixAutoUpdate"); set => JSRef!.Set("matrixAutoUpdate", value); }
        /// <summary>
        /// pointMap: { [id: string]: number[] };
        /// </summary>
        public object PointMap { get => JSRef!.Get<object>("pointMap"); set => JSRef!.Set("pointMap", value); }
        /// <summary>
        /// override readonly type: string | "CameraHelper";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// update(): void;
        /// </summary>
        public void Update()
        {
            JSRef!.CallVoid("update");
        }
        /// <summary>
        /// setColors(frustum: Color, cone: Color, up: Color, target: Color, cross: Color): this;
        /// </summary>
        public CameraHelper SetColors(Color frustum, Color cone, Color up, Color target, Color cross)
        {
            return JSRef!.Call<CameraHelper>("setColors", frustum, cone, up, target, cross);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
