
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLInfo : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLInfo(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(gl: WebGLRenderingContext);
        /// </summary>
        public WebGLInfo(WebGLRenderingContext gl) : base(JS.New("THREE.WebGLInfo", gl)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// autoReset: boolean;
        /// </summary>
        public bool AutoReset { get => JSRef!.Get<bool>("autoReset"); set => JSRef!.Set("autoReset", value); }
        /// <summary>
        /// memory: {
                ///         geometries: number;
                ///         textures: number;
                ///     };
        /// </summary>
        public object Memory { get => JSRef!.Get<object>("memory"); set => JSRef!.Set("memory", value); }
        /// <summary>
        /// programs: WebGLProgram[] | null;
        /// </summary>
        public Array<WebGLProgram> Programs { get => JSRef!.Get<Array<WebGLProgram>>("programs"); set => JSRef!.Set("programs", value); }
        /// <summary>
        /// render: {
                ///         calls: number;
                ///         frame: number;
                ///         lines: number;
                ///         points: number;
                ///         triangles: number;
                ///     };
        /// </summary>
        public object Render { get => JSRef!.Get<object>("render"); set => JSRef!.Set("render", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(count: number, mode: number, instanceCount: number): void;
        /// </summary>
        public void Update(float count, float mode, float instanceCount)
        {
            JSRef!.CallVoid("update", count, mode, instanceCount);
        }
        /// <summary>
        /// reset(): void;
        /// </summary>
        public void Reset()
        {
            JSRef!.CallVoid("reset");
        }
        #endregion
    }
}
