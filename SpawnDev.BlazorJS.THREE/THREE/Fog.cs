
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Fog : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Fog(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color: ColorRepresentation, near?: number, far?: number);
        /// </summary>
        public Fog(ColorRepresentation color, float near, float far) : base(JS.New("THREE.Fog", color, near, far)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// color: Color;
        /// </summary>
        public Color Color { get => JSRef!.Get<Color>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// far: number;
        /// </summary>
        public float Far { get => JSRef!.Get<float>("far"); set => JSRef!.Set("far", value); }
        /// <summary>
        /// readonly isFog: true;
        /// </summary>
        public bool IsFog { get => JSRef!.Get<bool>("isFog"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// near: number;
        /// </summary>
        public float Near { get => JSRef!.Get<float>("near"); set => JSRef!.Set("near", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(): FogJSON;
        /// </summary>
        public FogJSON ToJSON()
        {
            return JSRef!.Call<FogJSON>("toJSON");
        }
        /// <summary>
        /// clone(): Fog;
        /// </summary>
        public Fog Clone()
        {
            return JSRef!.Call<Fog>("clone");
        }
        #endregion
    }
}
