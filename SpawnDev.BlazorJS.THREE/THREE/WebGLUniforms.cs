
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLUniforms : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLUniforms(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(gl: WebGLRenderingContext, program: WebGLProgram);
        /// </summary>
        public WebGLUniforms(WebGLRenderingContext gl, WebGLProgram program) : base(JS.New("THREE.WebGLUniforms", gl, program)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// static upload(gl: WebGLRenderingContext, seq: any, values: any[], textures: WebGLTextures): void;
        /// </summary>
        public void Upload(WebGLRenderingContext gl, object seq, Array<object> values, WebGLTextures textures)
        {
            JSRef!.CallVoid("upload", gl, seq, values, textures);
        }
        /// <summary>
        /// setValue(gl: WebGLRenderingContext, name: string, value: any, textures: WebGLTextures): void;
        /// </summary>
        public void SetValue(WebGLRenderingContext gl, string name, object value, WebGLTextures textures)
        {
            JSRef!.CallVoid("setValue", gl, name, value, textures);
        }
        /// <summary>
        /// setOptional(gl: WebGLRenderingContext, object: any, name: string): void;
        /// </summary>
        public void SetOptional(WebGLRenderingContext gl, object obj, string name)
        {
            JSRef!.CallVoid("setOptional", gl, obj, name);
        }
        /// <summary>
        /// static seqWithValue(seq: any, values: any[]): any[];
        /// </summary>
        public Array<object> SeqWithValue(object seq, Array<object> values)
        {
            return JSRef!.Call<Array<object>>("seqWithValue", seq, values);
        }
        #endregion
    }
}
