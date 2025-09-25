
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLBufferRenderer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLBufferRenderer(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(
        ///         gl: WebGLRenderingContext,
        ///         extensions: WebGLExtensions,
        ///         info: WebGLInfo,
        ///     );
        /// </summary>
        public WebGLBufferRenderer(WebGLRenderingContext gl, WebGLExtensions extensions, WebGLInfo info) : base(JS.New("THREE.WebGLBufferRenderer", gl, extensions, info)) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// (value: any) => void
        /// </summary>
        public void SetMode(object value)
        {
            JSRef!.CallVoid("setMode", value);
        }
        /// <summary>
        /// (
        ///         starts: Int32Array,
        ///         counts: Int32Array,
        ///         drawCount: number,
        ///         primcount: Int32Array,
        ///     ) => void
        /// </summary>
        public void RenderMultiDrawInstances(Int32Array starts, Int32Array counts, float drawCount, Int32Array primcount)
        {
            JSRef!.CallVoid("renderMultiDrawInstances", starts, counts, drawCount, primcount);
        }
        /// <summary>
        /// (starts: Int32Array, counts: Int32Array, drawCount: number) => void
        /// </summary>
        public void RenderMultiDraw(Int32Array starts, Int32Array counts, float drawCount)
        {
            JSRef!.CallVoid("renderMultiDraw", starts, counts, drawCount);
        }
        /// <summary>
        /// (start: any, count: number, primcount: number) => void
        /// </summary>
        public void RenderInstances(object start, float count, float primcount)
        {
            JSRef!.CallVoid("renderInstances", start, count, primcount);
        }
        /// <summary>
        /// (start: any, count: number) => void
        /// </summary>
        public void Render(object start, float count)
        {
            JSRef!.CallVoid("render", start, count);
        }
        #endregion
    }
}
