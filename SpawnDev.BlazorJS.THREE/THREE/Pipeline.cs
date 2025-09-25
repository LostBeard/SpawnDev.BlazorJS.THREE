
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Pipeline : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Pipeline(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(cacheKey: string);
        /// </summary>
        public Pipeline(string cacheKey) : base(JS.New("THREE.Pipeline", cacheKey)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// cacheKey: string;
        /// </summary>
        public string CacheKey { get => JSRef!.Get<string>("cacheKey"); set => JSRef!.Set("cacheKey", value); }
        /// <summary>
        /// usedTimes: number;
        /// </summary>
        public float UsedTimes { get => JSRef!.Get<float>("usedTimes"); set => JSRef!.Set("usedTimes", value); }
        #endregion

        #region Methods

        #endregion
    }
}
