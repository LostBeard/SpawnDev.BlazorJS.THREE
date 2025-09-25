
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AxesHelper : LineSegments
    {
        #region Constructors
        /// <inheritdoc/>
        public AxesHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(size?: number);
        /// </summary>
        public AxesHelper(float size) : base(JS.New("THREE.AxesHelper", size)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly type: string | "AxesHelper";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// setColors(xAxisColor: ColorRepresentation, yAxisColor: ColorRepresentation, zAxisColor: ColorRepresentation): this;
        /// </summary>
        public AxesHelper SetColors(ColorRepresentation xAxisColor, ColorRepresentation yAxisColor, ColorRepresentation zAxisColor)
        {
            return JSRef!.Call<AxesHelper>("setColors", xAxisColor, yAxisColor, zAxisColor);
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
