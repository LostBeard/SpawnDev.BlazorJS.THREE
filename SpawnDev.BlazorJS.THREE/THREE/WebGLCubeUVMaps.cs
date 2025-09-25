
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLCubeUVMaps : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLCubeUVMaps(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(renderer: WebGLRenderer);
        /// </summary>
        public WebGLCubeUVMaps(WebGLRenderer renderer) : base(JS.New("THREE.WebGLCubeUVMaps", renderer)) { }
        
        #endregion

        #region Properties
        ///// <summary>
        ///// T;
        ///// </summary>
        //public TType T { get => JSRef!.Get<TType>("T"); set => JSRef!.Set("T", value); }
        /// <summary>
        /// Texture ? Texture
        /// </summary>
        public Texture Texture { get => JSRef!.Get<Texture>("Texture"); set => JSRef!.Set("Texture", value); }
        #endregion

        #region Methods
        /// <summary>
        /// get<T>(texture: T): T
        /// </summary>
        public object Get<T>(T texture)
        {
            return JSRef!.Call<object>("get", texture);
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
