
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderLists : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderLists(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(lighting: Lighting);
        /// </summary>
        public RenderLists(Lighting lighting) : base(JS.New("THREE.RenderLists", lighting)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// lighting: Lighting;
        /// </summary>
        public Lighting Lighting { get => JSRef!.Get<Lighting>("lighting"); set => JSRef!.Set("lighting", value); }
        /// <summary>
        /// lists: ChainMap<readonly[Object3D, Camera
        /// </summary>
        public ChainMap<object, Camera> Lists { get => JSRef!.Get<ChainMap<object, Camera>>("lists"); set => JSRef!.Set("lists", value); }
        /// <summary>
        /// RenderList>;
        /// </summary>
        public JSObject RenderList { get => JSRef!.Get<JSObject>("RenderList"); set => JSRef!.Set("RenderList", value); }
        #endregion

        #region Methods
        /// <summary>
        /// get(scene: Object3D, camera: Camera): RenderList;
        /// </summary>
        public RenderList Get(Object3D scene, Camera camera)
        {
            return JSRef!.Call<RenderList>("get", scene, camera);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
