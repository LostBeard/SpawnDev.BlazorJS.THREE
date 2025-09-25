
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLProgram : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLProgram(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(renderer: WebGLRenderer, cacheKey: string, parameters: object);
        /// </summary>
        public WebGLProgram(WebGLRenderer renderer, string cacheKey, object parameters) : base(JS.New("THREE.WebGLProgram", renderer, cacheKey, parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// attributes: any;
        /// </summary>
        public object Attributes { get => JSRef!.Get<object>("attributes"); set => JSRef!.Set("attributes", value); }
        /// <summary>
        /// cacheKey: string;
        /// </summary>
        public string CacheKey { get => JSRef!.Get<string>("cacheKey"); set => JSRef!.Set("cacheKey", value); }
        /// <summary>
        /// fragmentShader: WebGLShader;
        /// </summary>
        public WebGLShader FragmentShader { get => JSRef!.Get<WebGLShader>("fragmentShader"); set => JSRef!.Set("fragmentShader", value); }
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// program: any;
        /// </summary>
        public object Program { get => JSRef!.Get<object>("program"); set => JSRef!.Set("program", value); }
        /// <summary>
        /// uniforms: any;
        /// </summary>
        public object Uniforms { get => JSRef!.Get<object>("uniforms"); set => JSRef!.Set("uniforms", value); }
        /// <summary>
        /// usedTimes: number;
        /// </summary>
        public float UsedTimes { get => JSRef!.Get<float>("usedTimes"); set => JSRef!.Set("usedTimes", value); }
        /// <summary>
        /// vertexShader: WebGLShader;
        /// </summary>
        public WebGLShader VertexShader { get => JSRef!.Get<WebGLShader>("vertexShader"); set => JSRef!.Set("vertexShader", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getUniforms(): WebGLUniforms;
        /// </summary>
        public WebGLUniforms GetUniforms()
        {
            return JSRef!.Call<WebGLUniforms>("getUniforms");
        }
        /// <summary>
        /// getAttributes(): any;
        /// </summary>
        public object GetAttributes()
        {
            return JSRef!.Call<object>("getAttributes");
        }
        /// <summary>
        /// destroy(): void;
        /// </summary>
        public void Destroy()
        {
            JSRef!.CallVoid("destroy");
        }
        #endregion
    }
}
