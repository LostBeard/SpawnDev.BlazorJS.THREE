
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Material : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public Material(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isMaterial: boolean;
        /// </summary>
        public bool IsMaterial { get => JSRef!.Get<bool>("isMaterial"); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// readonly type: string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// readonly uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); }
        /// <summary>
        /// readonly version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(meta?: JSONMeta): MaterialJSON;
        /// </summary>
        public MaterialJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<MaterialJSON>("toJSON", meta);
        }
        /// <summary>
        /// setValues(values?: MaterialParameters): void;
        /// </summary>
        public void SetValues(MaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// onBeforeRender(
        ///         renderer: WebGLRenderer,
        ///         scene: Scene,
        ///         camera: Camera,
        ///         geometry: BufferGeometry,
        ///         object: Object3D,
        ///         group: Group,
        ///     ): void;
        /// </summary>
        public void OnBeforeRender(WebGLRenderer renderer, Scene scene, Camera camera, BufferGeometry geometry, Object3D obj, Group group)
        {
            JSRef!.CallVoid("onBeforeRender", renderer, scene, camera, geometry, obj, group);
        }
        /// <summary>
        /// onBeforeCompile(parameters: WebGLProgramParametersWithUniforms, renderer: WebGLRenderer): void;
        /// </summary>
        public void OnBeforeCompile(WebGLProgramParametersWithUniforms parameters, WebGLRenderer renderer)
        {
            JSRef!.CallVoid("onBeforeCompile", parameters, renderer);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// customProgramCacheKey(): string;
        /// </summary>
        public string CustomProgramCacheKey()
        {
            return JSRef!.Call<string>("customProgramCacheKey");
        }
        /// <summary>
        /// copy(source: Material): this;
        /// </summary>
        public Material Copy(Material source)
        {
            return JSRef!.Call<Material>("copy", source);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Material Clone()
        {
            return JSRef!.Call<Material>("clone");
        }
        #endregion
    }
}
