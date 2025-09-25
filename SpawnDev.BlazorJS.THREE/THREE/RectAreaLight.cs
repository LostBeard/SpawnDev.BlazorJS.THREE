
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RectAreaLight : Light<object>
    {
        #region Constructors
        /// <inheritdoc/>
        public RectAreaLight(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color?: ColorRepresentation, intensity?: number, width?: number, height?: number);
        /// </summary>
        public RectAreaLight(ColorRepresentation color, float intensity, float width, float height) : base(JS.New("THREE.RectAreaLight", color, intensity, width, height)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// height: number;
        /// </summary>
        public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
        /// <summary>
        /// intensity: number;
        /// </summary>
        public float Intensity { get => JSRef!.Get<float>("intensity"); set => JSRef!.Set("intensity", value); }
        /// <summary>
        /// readonly isRectAreaLight: true;
        /// </summary>
        public bool IsRectAreaLight { get => JSRef!.Get<bool>("isRectAreaLight"); }
        /// <summary>
        /// power: number;
        /// </summary>
        public float Power { get => JSRef!.Get<float>("power"); set => JSRef!.Set("power", value); }
        /// <summary>
        /// override readonly type: string | "RectAreaLight";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// width: number;
        /// </summary>
        public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
        #endregion

        #region Methods

        #endregion
    }
}
