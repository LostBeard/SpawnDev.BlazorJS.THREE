
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WireframeGeometry : BufferGeometry
    {
        /// <inheritdoc/>
        public WireframeGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class WireframeGeometry<TBufferGeometry> : WireframeGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public WireframeGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(geometry?: TBufferGeometry);
        /// </summary>
        public WireframeGeometry(TBufferGeometry geometry) : base(JS.New("THREE.WireframeGeometry", geometry)) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly parameters: {
        ///         readonly geometry: TBufferGeometry;
        ///     };
        /// </summary>
        public object Parameters { get => JSRef!.Get<object>("parameters"); }
        ///// <summary>
        ///// override readonly type: string | "WireframeGeometry";
        ///// </summary>
        //public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
