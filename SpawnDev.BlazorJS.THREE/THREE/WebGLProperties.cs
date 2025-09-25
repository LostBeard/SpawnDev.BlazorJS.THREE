
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLProperties : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLProperties(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor();
        /// </summary>
        public WebGLProperties() : base(JS.New("THREE.WebGLProperties")) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// (object: unknown, key: unknown, value: unknown) => unknown
        /// </summary>
        public JSObject Update(object obj, object key, object value)
        {
            return JSRef!.Call<JSObject>("update", obj, key, value);
        }
        /// <summary>
        /// (object: unknown) => void
        /// </summary>
        public void Remove(object obj)
        {
            JSRef!.CallVoid("remove", obj);
        }
        /// <summary>
        /// (object: unknown) => boolean
        /// </summary>
        public bool Has(object obj)
        {
            return JSRef!.Call<bool>("has", obj);
        }
        /// <summary>
        /// (object: unknown) => unknown
        /// </summary>
        public JSObject Get(object obj)
        {
            return JSRef!.Call<JSObject>("get", obj);
        }
        /// <summary>
        /// () => void
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
