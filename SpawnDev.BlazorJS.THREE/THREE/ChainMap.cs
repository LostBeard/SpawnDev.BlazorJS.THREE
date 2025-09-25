
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ChainMap<K, V> : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public ChainMap(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public ChainMap() : base(JS.New("THREE.ChainMap")) { }
        
        #endregion

        #region Properties
        ///// <summary>
        ///// weakMap: RecursiveWeakMap<K, V>;
        ///// </summary>
        //public RecursiveWeakMap<K, V> WeakMap { get => JSRef!.Get<RecursiveWeakMap<K, V>>("weakMap"); set => JSRef!.Set("weakMap", value); }
        #endregion

        #region Methods
        /// <summary>
        /// set(keys: K, value: V): this;
        /// </summary>
        public ChainMap<K, V> Set(K keys, V value)
        {
            JSRef!.CallVoid("set", keys, value);
            return this;
        }
        /// <summary>
        /// get(keys: K): V | undefined;
        /// </summary>
        public V Get(K keys)
        {
            return JSRef!.Call<V>("get", keys);
        }
        /// <summary>
        /// delete(keys: K): boolean;
        /// </summary>
        public bool Delete(K keys)
        {
            return JSRef!.Call<bool>("delete", keys);
        }
        #endregion
    }
}
