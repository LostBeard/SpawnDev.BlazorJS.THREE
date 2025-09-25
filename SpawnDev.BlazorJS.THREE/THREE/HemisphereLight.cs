
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class HemisphereLight : Light<object>
    {
        #region Constructors
        /// <inheritdoc/>
        public HemisphereLight(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(skyColor?: ColorRepresentation, groundColor?: ColorRepresentation, intensity?: number);
        /// </summary>
        public HemisphereLight(ColorRepresentation skyColor, ColorRepresentation groundColor, float intensity) : base(JS.New("THREE.HemisphereLight", skyColor, groundColor, intensity)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override color: Color;
        /// </summary>
        public Color Color { get => JSRef!.Get<Color>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// groundColor: Color;
        /// </summary>
        public Color GroundColor { get => JSRef!.Get<Color>("groundColor"); set => JSRef!.Set("groundColor", value); }
        /// <summary>
        /// readonly isHemisphereLight: true;
        /// </summary>
        public bool IsHemisphereLight { get => JSRef!.Get<bool>("isHemisphereLight"); }
        /// <summary>
        /// override readonly position: Vector3;
        /// </summary>
        public Vector3 Position { get => JSRef!.Get<Vector3>("position"); }
        /// <summary>
        /// override readonly type: string | "HemisphereLight";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
