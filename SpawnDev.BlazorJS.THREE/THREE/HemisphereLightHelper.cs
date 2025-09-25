
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class HemisphereLightHelper : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public HemisphereLightHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(light: HemisphereLight, size: number, color?: ColorRepresentation);
        /// </summary>
        public HemisphereLightHelper(HemisphereLight light, float size, ColorRepresentation color) : base(JS.New("THREE.HemisphereLightHelper", light, size, color)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// color: ColorRepresentation | undefined;
        /// </summary>
        public ColorRepresentation Color { get => JSRef!.Get<ColorRepresentation>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// light: HemisphereLight;
        /// </summary>
        public HemisphereLight Light { get => JSRef!.Get<HemisphereLight>("light"); set => JSRef!.Set("light", value); }
        /// <summary>
        /// material: MeshBasicMaterial;
        /// </summary>
        public MeshBasicMaterial Material { get => JSRef!.Get<MeshBasicMaterial>("material"); set => JSRef!.Set("material", value); }
        /// <summary>
        /// matrix: Matrix4;
        /// </summary>
        public Matrix4 Matrix { get => JSRef!.Get<Matrix4>("matrix"); set => JSRef!.Set("matrix", value); }
        /// <summary>
        /// override matrixAutoUpdate: boolean;
        /// </summary>
        public bool MatrixAutoUpdate { get => JSRef!.Get<bool>("matrixAutoUpdate"); set => JSRef!.Set("matrixAutoUpdate", value); }
        /// <summary>
        /// override readonly type: string | "HemisphereLightHelper";
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
