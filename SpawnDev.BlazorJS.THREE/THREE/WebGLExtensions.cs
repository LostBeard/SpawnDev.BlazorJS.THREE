
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLExtensions : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLExtensions(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(gl: WebGLRenderingContext);
        /// </summary>
        public WebGLExtensions(WebGLRenderingContext gl) : base(JS.New("THREE.WebGLExtensions", gl)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// init(): void;
        /// </summary>
        public void Init()
        {
            JSRef!.CallVoid("init");
        }
        /// <summary>
        /// has(name: string): boolean;
        /// </summary>
        public bool Has(string name)
        {
            return JSRef!.Call<bool>("has", name);
        }
        /// <summary>
        /// get(name: string): any;
        /// </summary>
        public object Get(string name)
        {
            return JSRef!.Call<object>("get", name);
        }
        #endregion
    }
}
