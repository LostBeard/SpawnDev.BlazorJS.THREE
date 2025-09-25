
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLPrograms : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLPrograms(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         renderer: WebGLRenderer,
        ///         cubemaps: WebGLCubeMaps,
        ///         extensions: WebGLExtensions,
        ///         capabilities: WebGLCapabilities,
        ///         bindingStates: WebGLBindingStates,
        ///         clipping: WebGLClipping,
        ///     );
        /// </summary>
        public WebGLPrograms(WebGLRenderer renderer, WebGLCubeMaps cubemaps, WebGLExtensions extensions, WebGLCapabilities capabilities, WebGLBindingStates bindingStates, WebGLClipping clipping) : base(JS.New("THREE.WebGLPrograms", renderer, cubemaps, extensions, capabilities, bindingStates, clipping)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// programs: WebGLProgram[];
        /// </summary>
        public Array<WebGLProgram> Programs { get => JSRef!.Get<Array<WebGLProgram>>("programs"); set => JSRef!.Set("programs", value); }
        #endregion

        #region Methods
        /// <summary>
        /// releaseProgram(program: WebGLProgram): void;
        /// </summary>
        public void ReleaseProgram(WebGLProgram program)
        {
            JSRef!.CallVoid("releaseProgram", program);
        }
        /// <summary>
        /// getUniforms(material: Material): { [uniform: string]: IUniform };
        /// </summary>
        public object GetUniforms(Material material, string uniform)
        {
            return JSRef!.Call<object>("getUniforms", material, uniform);
        }
        /// <summary>
        /// getProgramCacheKey(parameters: WebGLProgramParameters): string;
        /// </summary>
        public string GetProgramCacheKey(WebGLProgramParameters parameters)
        {
            return JSRef!.Call<string>("getProgramCacheKey", parameters);
        }
        /// <summary>
        /// getParameters(
        ///         material: Material,
        ///         lights: WebGLLightsState,
        ///         shadows: Light[],
        ///         scene: Scene,
        ///         object: Object3D,
        ///     ): WebGLProgramParameters;
        /// </summary>
        public WebGLProgramParameters GetParameters(Material material, WebGLLightsState lights, Array<Light> shadows, Scene scene, Object3D obj)
        {
            return JSRef!.Call<WebGLProgramParameters>("getParameters", material, lights, shadows, scene, obj);
        }
        /// <summary>
        /// acquireProgram(parameters: WebGLProgramParametersWithUniforms, cacheKey: string): WebGLProgram;
        /// </summary>
        public WebGLProgram AcquireProgram(WebGLProgramParametersWithUniforms parameters, string cacheKey)
        {
            return JSRef!.Call<WebGLProgram>("acquireProgram", parameters, cacheKey);
        }
        #endregion
    }
}
