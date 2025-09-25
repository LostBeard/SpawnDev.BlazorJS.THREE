
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ArrowHelper : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public ArrowHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         dir?: Vector3,
        ///         origin?: Vector3,
        ///         length?: number,
        ///         color?: ColorRepresentation,
        ///         headLength?: number,
        ///         headWidth?: number,
        ///     );
        /// </summary>
        public ArrowHelper(Vector3 dir, Vector3 origin, float length, ColorRepresentation color, float headLength, float headWidth) : base(JS.New("THREE.ArrowHelper", dir, origin, length, color, headLength, headWidth)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// cone: Mesh;
        /// </summary>
        public Mesh Cone { get => JSRef!.Get<Mesh>("cone"); set => JSRef!.Set("cone", value); }
        /// <summary>
        /// line: Line;
        /// </summary>
        public Line Line { get => JSRef!.Get<Line>("line"); set => JSRef!.Set("line", value); }
        /// <summary>
        /// override readonly type: string | "ArrowHelper";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// setLength(length: number, headLength?: number, headWidth?: number): void;
        /// </summary>
        public void SetLength(float length, float headLength, float headWidth)
        {
            JSRef!.CallVoid("setLength", length, headLength, headWidth);
        }
        /// <summary>
        /// setDirection(dir: Vector3): void;
        /// </summary>
        public void SetDirection(Vector3 dir)
        {
            JSRef!.CallVoid("setDirection", dir);
        }
        /// <summary>
        /// setColor(color: ColorRepresentation): void;
        /// </summary>
        public void SetColor(ColorRepresentation color)
        {
            JSRef!.CallVoid("setColor", color);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// override copy(source: this): this;
        /// </summary>
        public ArrowHelper Copy(ArrowHelper source)
        {
            return JSRef!.Call<ArrowHelper>("copy", source);
        }
        #endregion
    }
}
