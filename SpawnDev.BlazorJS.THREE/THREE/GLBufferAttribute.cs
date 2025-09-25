
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class GLBufferAttribute : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public GLBufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         buffer: WebGLBuffer,
        ///         type: GLenum,
        ///         itemSize: number,
        ///         elementSize: 1 | 2 | 4,
        ///         count: number,
        ///         normalized?: boolean,
        ///     );
        /// </summary>
        public GLBufferAttribute(WebGLBuffer buffer, GLenum type, float itemSize, float elementSize, float count, bool normalized) : base(JS.New("THREE.GLBufferAttribute", buffer, type, itemSize, elementSize, count, normalized)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// buffer: WebGLBuffer;
        /// </summary>
        public WebGLBuffer Buffer { get => JSRef!.Get<WebGLBuffer>("buffer"); set => JSRef!.Set("buffer", value); }
        /// <summary>
        /// count: number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// elementSize: 1 | 2 | 4;
        /// </summary>
        public float ElementSize { get => JSRef!.Get<float>("elementSize"); set => JSRef!.Set("elementSize", value); }
        /// <summary>
        /// readonly isGLBufferAttribute: true;
        /// </summary>
        public bool IsGLBufferAttribute { get => JSRef!.Get<bool>("isGLBufferAttribute"); }
        /// <summary>
        /// itemSize: number;
        /// </summary>
        public float ItemSize { get => JSRef!.Get<float>("itemSize"); set => JSRef!.Set("itemSize", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// normalized: boolean;
        /// </summary>
        public bool Normalized { get => JSRef!.Get<bool>("normalized"); set => JSRef!.Set("normalized", value); }
        /// <summary>
        /// type: GLenum;
        /// </summary>
        public GLenum Type { get => JSRef!.Get<GLenum>("type"); set => JSRef!.Set("type", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setType(type: GLenum, elementSize: 1 | 2 | 4): this;
        /// </summary>
        public GLBufferAttribute SetType(GLenum type, float elementSize)
        {
            return JSRef!.Call<GLBufferAttribute>("setType", type, elementSize);
        }
        /// <summary>
        /// setItemSize(itemSize: number): this;
        /// </summary>
        public GLBufferAttribute SetItemSize(float itemSize)
        {
            return JSRef!.Call<GLBufferAttribute>("setItemSize", itemSize);
        }
        /// <summary>
        /// setCount(count: number): this;
        /// </summary>
        public GLBufferAttribute SetCount(float count)
        {
            return JSRef!.Call<GLBufferAttribute>("setCount", count);
        }
        /// <summary>
        /// setBuffer(buffer: WebGLBuffer): this;
        /// </summary>
        public GLBufferAttribute SetBuffer(WebGLBuffer buffer)
        {
            return JSRef!.Call<GLBufferAttribute>("setBuffer", buffer);
        }
        #endregion
    }
}
