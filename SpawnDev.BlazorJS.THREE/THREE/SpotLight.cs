
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SpotLight : Light
    {
        #region Constructors
        /// <inheritdoc/>
        public SpotLight(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         color?: ColorRepresentation,
        ///         intensity?: number,
        ///         distance?: number,
        ///         angle?: number,
        ///         penumbra?: number,
        ///         decay?: number,
        ///     );
        /// </summary>
        public SpotLight(ColorRepresentation color, float intensity, float distance, float angle, float penumbra, float decay) : base(JS.New("THREE.SpotLight", color, intensity, distance, angle, penumbra, decay)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// angle: number;
        /// </summary>
        public float Angle { get => JSRef!.Get<float>("angle"); set => JSRef!.Set("angle", value); }
        /// <summary>
        /// override castShadow: boolean;
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
        /// readonly isSpotLight: true;
        /// </summary>
        public bool IsSpotLight { get => JSRef!.Get<bool>("isSpotLight"); }
        /// <summary>
        /// map: Texture | null;
        /// </summary>
        public Texture Map { get => JSRef!.Get<Texture>("map"); set => JSRef!.Set("map", value); }
        /// <summary>
        /// penumbra: number;
        /// </summary>
        public float Penumbra { get => JSRef!.Get<float>("penumbra"); set => JSRef!.Set("penumbra", value); }
        /// <summary>
        /// readonly position: Vector3;
        /// </summary>
        public Vector3 Position { get => JSRef!.Get<Vector3>("position"); }
        /// <summary>
        /// power: number;
        /// </summary>
        public float Power { get => JSRef!.Get<float>("power"); set => JSRef!.Set("power", value); }
        /// <summary>
        /// shadow: SpotLightShadow;
        /// </summary>
        public SpotLightShadow Shadow { get => JSRef!.Get<SpotLightShadow>("shadow"); set => JSRef!.Set("shadow", value); }
        /// <summary>
        /// target: Object3D;
        /// </summary>
        public Object3D Target { get => JSRef!.Get<Object3D>("target"); set => JSRef!.Set("target", value); }
        /// <summary>
        /// override readonly type: string | "SpotLight";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
