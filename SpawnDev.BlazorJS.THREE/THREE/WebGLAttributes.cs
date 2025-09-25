
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLAttributes : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLAttributes(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(gl: WebGLRenderingContext | WebGL2RenderingContext);
        /// </summary>
        public WebGLAttributes(Union<WebGLRenderingContext, WebGL2RenderingContext> gl) : base(JS.New("THREE.WebGLAttributes", gl)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// update(attribute: BufferAttribute | InterleavedBufferAttribute | GLBufferAttribute, bufferType: number): void;
        /// </summary>
        public void Update(Union<BufferAttribute, InterleavedBufferAttribute, GLBufferAttribute> attribute, float bufferType)
        {
            JSRef!.CallVoid("update", attribute, bufferType);
        }
        /// <summary>
        /// remove(attribute: BufferAttribute | InterleavedBufferAttribute | GLBufferAttribute): void;
        /// </summary>
        public void Remove(Union<BufferAttribute, InterleavedBufferAttribute, GLBufferAttribute> attribute)
        {
            JSRef!.CallVoid("remove", attribute);
        }
        /// <summary>
        /// get(attribute: BufferAttribute | InterleavedBufferAttribute | GLBufferAttribute):
        ///         | {
        ///             buffer: WebGLBuffer;
        ///             type: number;
        ///             bytesPerElement: number;
        ///             version: number;
        ///             size: number;
        ///         }
        ///         | undefined;
        /// </summary>
        public object Get(Union<BufferAttribute, InterleavedBufferAttribute, GLBufferAttribute> attribute)
        {
            return JSRef!.Call<object>("get", attribute);
        }
        #endregion
    }
}
