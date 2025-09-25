
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class FogExp2 : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public FogExp2(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color: ColorRepresentation, density?: number);
        /// </summary>
        public FogExp2(ColorRepresentation color, float density) : base(JS.New("THREE.FogExp2", color, density)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// color: Color;
        /// </summary>
        public Color Color { get => JSRef!.Get<Color>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// density: number;
        /// </summary>
        public float Density { get => JSRef!.Get<float>("density"); set => JSRef!.Set("density", value); }
        /// <summary>
        /// readonly isFogExp2: true;
        /// </summary>
        public bool IsFogExp2 { get => JSRef!.Get<bool>("isFogExp2"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(): FogExp2JSON;
        /// </summary>
        public FogExp2JSON ToJSON()
        {
            return JSRef!.Call<FogExp2JSON>("toJSON");
        }
        /// <summary>
        /// clone(): FogExp2;
        /// </summary>
        public FogExp2 Clone()
        {
            return JSRef!.Call<FogExp2>("clone");
        }
        #endregion
    }
}
