
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLClipping : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLClipping(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(properties: WebGLProperties);
        /// </summary>
        public WebGLClipping(WebGLProperties properties) : base(JS.New("THREE.WebGLClipping", properties)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// numIntersection: number;
        /// </summary>
        public float NumIntersection { get => JSRef!.Get<float>("numIntersection"); set => JSRef!.Set("numIntersection", value); }
        /// <summary>
        /// numPlanes: number;
        /// </summary>
        public float NumPlanes { get => JSRef!.Get<float>("numPlanes"); set => JSRef!.Set("numPlanes", value); }
        /// <summary>
        /// uniform: { value: any; needsUpdate: boolean };
        /// </summary>
        public object Uniform { get => JSRef!.Get<object>("uniform"); set => JSRef!.Set("uniform", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setState(material: Material, camera: Camera, useCache: boolean): void;
        /// </summary>
        public void SetState(Material material, Camera camera, bool useCache)
        {
            JSRef!.CallVoid("setState", material, camera, useCache);
        }
        /// <summary>
        /// setGlobalState(planes: Plane[], camera: Camera): void;
        /// </summary>
        public void SetGlobalState(Array<Plane> planes, Camera camera)
        {
            JSRef!.CallVoid("setGlobalState", planes, camera);
        }
        /// <summary>
        /// init(planes: any[], enableLocalClipping: boolean): boolean;
        /// </summary>
        public bool Init(Array<object> planes, bool enableLocalClipping)
        {
            return JSRef!.Call<bool>("init", planes, enableLocalClipping);
        }
        /// <summary>
        /// endShadows(): void;
        /// </summary>
        public void EndShadows()
        {
            JSRef!.CallVoid("endShadows");
        }
        /// <summary>
        /// beginShadows(): void;
        /// </summary>
        public void BeginShadows()
        {
            JSRef!.CallVoid("beginShadows");
        }
        #endregion
    }
}
