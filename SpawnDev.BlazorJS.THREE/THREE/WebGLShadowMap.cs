
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLShadowMap : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLShadowMap(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(_renderer: WebGLRenderer, _objects: WebGLObjects, _capabilities: WebGLCapabilities);
        /// </summary>
        public WebGLShadowMap(WebGLRenderer _renderer, WebGLObjects _objects, WebGLCapabilities _capabilities) : base(JS.New("THREE.WebGLShadowMap", _renderer, _objects, _capabilities)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// autoUpdate: boolean;
        /// </summary>
        public bool AutoUpdate { get => JSRef!.Get<bool>("autoUpdate"); set => JSRef!.Set("autoUpdate", value); }
        /// <summary>
        /// cullFace: any;
        /// </summary>
        public object CullFace { get => JSRef!.Get<object>("cullFace"); set => JSRef!.Set("cullFace", value); }
        /// <summary>
        /// enabled: boolean;
        /// </summary>
        public bool Enabled { get => JSRef!.Get<bool>("enabled"); set => JSRef!.Set("enabled", value); }
        /// <summary>
        /// needsUpdate: boolean;
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// type: ShadowMapType;
        /// </summary>
        public ShadowMapType Type { get => JSRef!.Get<ShadowMapType>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods
        /// <summary>
        /// render(shadowsArray: Light[], scene: Scene, camera: Camera): void;
        /// </summary>
        public void Render(Array<Light> shadowsArray, Scene scene, Camera camera)
        {
            JSRef!.CallVoid("render", shadowsArray, scene, camera);
        }
        #endregion
    }
}
