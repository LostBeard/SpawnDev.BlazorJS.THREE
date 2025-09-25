
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PointLight : Light<PointLightShadow>
    {
        #region Constructors
        /// <inheritdoc/>
        public PointLight(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color?: ColorRepresentation, intensity?: number, distance?: number, decay?: number);
        /// </summary>
        public PointLight(ColorRepresentation color, float intensity, float distance, float decay) : base(JS.New("THREE.PointLight", color, intensity, distance, decay)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// castShadow: boolean;
        /// </summary>
        public bool CastShadow { get => JSRef!.Get<bool>("castShadow"); set => JSRef!.Set("castShadow", value); }
        /// <summary>
        /// decay: number;
        /// </summary>
        public float Decay { get => JSRef!.Get<float>("decay"); set => JSRef!.Set("decay", value); }
        /// <summary>
        /// distance: number;
        /// </summary>
        public float Distance { get => JSRef!.Get<float>("distance"); set => JSRef!.Set("distance", value); }
        /// <summary>
        /// intensity: number;
        /// </summary>
        public float Intensity { get => JSRef!.Get<float>("intensity"); set => JSRef!.Set("intensity", value); }
        /// <summary>
        /// readonly isPointLight: true;
        /// </summary>
        public bool IsPointLight { get => JSRef!.Get<bool>("isPointLight"); }
        /// <summary>
        /// power: number;
        /// </summary>
        public float Power { get => JSRef!.Get<float>("power"); set => JSRef!.Set("power", value); }
        /// <summary>
        /// shadow: PointLightShadow;
        /// </summary>
        public PointLightShadow Shadow { get => JSRef!.Get<PointLightShadow>("shadow"); set => JSRef!.Set("shadow", value); }
        /// <summary>
        /// type: string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods

        #endregion
    }
}
