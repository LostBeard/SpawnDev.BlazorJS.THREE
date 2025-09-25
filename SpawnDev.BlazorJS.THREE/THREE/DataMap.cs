
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DataMap : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public DataMap(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public DataMap() : base(JS.New("THREE.DataMap")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// data: WeakMap<M[keyof M]["key"], M[keyof M]["value"]>;
        /// </summary>
        public JSObject Data { get => JSRef!.Get<JSObject>("data"); set => JSRef!.Set("data", value); }
        #endregion

        #region Methods
        /// <summary>
        /// has(object: M[keyof M]["key"]): boolean;
        /// </summary>
        public bool Has(object obj)
        {
            return JSRef!.Call<bool>("has", obj);
        }
        /// <summary>
        /// get<K extends M[keyof M]["key"]>(object: K): Extract<M[keyof M], {
        ///         key: K;
        ///     }>["value"];
        /// </summary>
        public object Get<K>(K obj)
        {
            return JSRef!.Call<object>("get", obj);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// delete<K extends M[keyof M]["key"]>(object: K): Extract<M[keyof M], {
        ///         key: K;
        ///     }>["value"];
        /// </summary>
        public object Delete<K>(K obj)
        {
            return JSRef!.Call<object>("delete", obj);
        }
        #endregion
    }
}
