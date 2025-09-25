
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SpotLightHelper : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public SpotLightHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light: Light, color?: ColorRepresentation);
        /// </summary>
        public SpotLightHelper(Light light, ColorRepresentation color) : base(JS.New("THREE.SpotLightHelper", light, color)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// color: ColorRepresentation | undefined;
        /// </summary>
        public ColorRepresentation Color { get => JSRef!.Get<ColorRepresentation>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// cone: LineSegments;
        /// </summary>
        public LineSegments Cone { get => JSRef!.Get<LineSegments>("cone"); set => JSRef!.Set("cone", value); }
        /// <summary>
        /// light: Light;
        /// </summary>
        public Light Light { get => JSRef!.Get<Light>("light"); set => JSRef!.Set("light", value); }
        /// <summary>
        /// matrix: Matrix4;
        /// </summary>
        public Matrix4 Matrix { get => JSRef!.Get<Matrix4>("matrix"); set => JSRef!.Set("matrix", value); }
        /// <summary>
        /// override matrixAutoUpdate: boolean;
        /// </summary>
        public bool MatrixAutoUpdate { get => JSRef!.Get<bool>("matrixAutoUpdate"); set => JSRef!.Set("matrixAutoUpdate", value); }
        /// <summary>
        /// override readonly type: string | "SpotLightHelper";
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
