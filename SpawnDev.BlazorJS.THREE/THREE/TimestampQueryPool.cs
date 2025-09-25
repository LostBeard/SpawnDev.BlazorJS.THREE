
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TimestampQueryPool : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public TimestampQueryPool(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(maxQueries?: number);
        /// </summary>
        public TimestampQueryPool(float maxQueries) : base(JS.New("THREE.TimestampQueryPool", maxQueries)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// currentQueryIndex: number;
        /// </summary>
        public float CurrentQueryIndex { get => JSRef!.Get<float>("currentQueryIndex"); set => JSRef!.Set("currentQueryIndex", value); }
        /// <summary>
        /// isDisposed: boolean;
        /// </summary>
        public bool IsDisposed { get => JSRef!.Get<bool>("isDisposed"); set => JSRef!.Set("isDisposed", value); }
        /// <summary>
        /// lastValue: number;
        /// </summary>
        public float LastValue { get => JSRef!.Get<float>("lastValue"); set => JSRef!.Set("lastValue", value); }
        /// <summary>
        /// maxQueries: number;
        /// </summary>
        public float MaxQueries { get => JSRef!.Get<float>("maxQueries"); set => JSRef!.Set("maxQueries", value); }
        /// <summary>
        /// pendingResolve: boolean;
        /// </summary>
        public bool PendingResolve { get => JSRef!.Get<bool>("pendingResolve"); set => JSRef!.Set("pendingResolve", value); }
        ///// <summary>
        ///// queryOffsets: Map<number, number>;
        ///// </summary>
        //public Map<float> QueryOffsets { get => JSRef!.Get<Map<float>>("queryOffsets"); set => JSRef!.Set("queryOffsets", value); }
        /// <summary>
        /// trackTimestamp: boolean;
        /// </summary>
        public bool TrackTimestamp { get => JSRef!.Get<bool>("trackTimestamp"); set => JSRef!.Set("trackTimestamp", value); }
        #endregion

        #region Methods
        /// <summary>
        /// abstract resolveQueriesAsync(): Promise<number>;
        /// </summary>
        public Task<float> ResolveQueriesAsync()
        {
            return JSRef!.CallAsync<float>("resolveQueriesAsync");
        }
        /// <summary>
        /// abstract dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// abstract allocateQueriesForContext(uid: string): number | null;
        /// </summary>
        public float AllocateQueriesForContext(string uid)
        {
            return JSRef!.Call<float>("allocateQueriesForContext", uid);
        }
        #endregion
    }
}
