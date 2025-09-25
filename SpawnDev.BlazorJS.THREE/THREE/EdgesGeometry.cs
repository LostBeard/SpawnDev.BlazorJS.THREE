
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class EdgesGeometry : BufferGeometry
    {
        /// <inheritdoc/>
        public EdgesGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class EdgesGeometry<TBufferGeometry> : EdgesGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public EdgesGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(geometry?: TBufferGeometry | null, thresholdAngle?: number);
        /// </summary>
        public EdgesGeometry(TBufferGeometry geometry, float thresholdAngle) : base(JS.New("THREE.EdgesGeometry", geometry, thresholdAngle)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
                ///         readonly geometry: TBufferGeometry | null;
                ///         readonly thresholdAngle: number;
                ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        /// <summary>
        /// override readonly type: string | "EdgesGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
