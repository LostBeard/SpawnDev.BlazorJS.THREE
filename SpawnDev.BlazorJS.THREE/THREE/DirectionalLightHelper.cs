
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DirectionalLightHelper : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public DirectionalLightHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light: DirectionalLight, size?: number, color?: ColorRepresentation);
        /// </summary>
        public DirectionalLightHelper(DirectionalLight light, float size, ColorRepresentation color) : base(JS.New("THREE.DirectionalLightHelper", light, size, color)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// color: ColorRepresentation | undefined;
        /// </summary>
        public ColorRepresentation Color { get => JSRef!.Get<ColorRepresentation>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// light: DirectionalLight;
        /// </summary>
        public DirectionalLight Light { get => JSRef!.Get<DirectionalLight>("light"); set => JSRef!.Set("light", value); }
        /// <summary>
        /// lightPlane: Line;
        /// </summary>
        public Line LightPlane { get => JSRef!.Get<Line>("lightPlane"); set => JSRef!.Set("lightPlane", value); }
        /// <summary>
        /// matrix: Matrix4;
        /// </summary>
        public Matrix4 Matrix { get => JSRef!.Get<Matrix4>("matrix"); set => JSRef!.Set("matrix", value); }
        /// <summary>
        /// override matrixAutoUpdate: boolean;
        /// </summary>
        public bool MatrixAutoUpdate { get => JSRef!.Get<bool>("matrixAutoUpdate"); set => JSRef!.Set("matrixAutoUpdate", value); }
        /// <summary>
        /// targetLine: Line;
        /// </summary>
        public Line TargetLine { get => JSRef!.Get<Line>("targetLine"); set => JSRef!.Set("targetLine", value); }
        /// <summary>
        /// override readonly type: string | "DirectionalLightHelper";
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
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
