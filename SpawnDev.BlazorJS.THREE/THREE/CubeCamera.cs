
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CubeCamera : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public CubeCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(near: number, far: number, renderTarget: WebGLCubeRenderTarget);
        /// </summary>
        public CubeCamera(float near, float far, WebGLCubeRenderTarget renderTarget) : base(JS.New("THREE.CubeCamera", near, far, renderTarget)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// activeMipmapLevel: number;
        /// </summary>
        public float ActiveMipmapLevel { get => JSRef!.Get<float>("activeMipmapLevel"); set => JSRef!.Set("activeMipmapLevel", value); }
        /// <summary>
        /// coordinateSystem: CoordinateSystem;
        /// </summary>
        public CoordinateSystem CoordinateSystem { get => JSRef!.Get<CoordinateSystem>("coordinateSystem"); set => JSRef!.Set("coordinateSystem", value); }
        /// <summary>
        /// renderTarget: WebGLCubeRenderTarget;
        /// </summary>
        public WebGLCubeRenderTarget RenderTarget { get => JSRef!.Get<WebGLCubeRenderTarget>("renderTarget"); set => JSRef!.Set("renderTarget", value); }
        /// <summary>
        /// override readonly type: string | "CubeCamera";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// updateCoordinateSystem(): void;
        /// </summary>
        public void UpdateCoordinateSystem()
        {
            JSRef!.CallVoid("updateCoordinateSystem");
        }
        /// <summary>
        /// update(renderer: CubeCameraRenderer, scene: Object3D): void;
        /// </summary>
        public void Update(CubeCameraRenderer renderer, Object3D scene)
        {
            JSRef!.CallVoid("update", renderer, scene);
        }
        #endregion
    }
}
