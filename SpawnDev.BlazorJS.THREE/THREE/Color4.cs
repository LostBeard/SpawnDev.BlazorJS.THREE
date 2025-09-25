
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Color4 : Color
    {
        #region Constructors
        /// <inheritdoc/>
        public Color4(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color?: ColorRepresentation);
        /// </summary>
        public Color4(ColorRepresentation color) : base(JS.New("THREE.Color4", color)) { }
        
        
        /// <summary>
        /// constructor(r: number, g: number, b: number, a?: number);
        /// </summary>
        public Color4(float r, float g, float b, float a) : base(JS.New("THREE.Color4", r, g, b, a)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// a: number;
        /// </summary>
        public float A { get => JSRef!.Get<float>("a"); set => JSRef!.Set("a", value); }
        /// <summary>
        /// this;
        /// </summary>
        public Color4 This { get => JSRef!.Get<Color4>("this"); set => JSRef!.Set("this", value); }
        #endregion

        #region Methods
        ///// <summary>
        ///// set(...args: [color: ColorRepresentation] | [r: number, g: number, b: number, a?: number
        ///// </summary>
        //public object Set(params Union<(color, ColorRepresentation), (r, float, g, float, b, float, a)> args, float )
        //{
        //    return JSRef!.Call<object>("set", args, );
        //}
        /// <summary>
        /// copy(color: Color): this;
        /// </summary>
        public Color4 Copy(Color color)
        {
            return JSRef!.Call<Color4>("copy", color);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Color4 Clone()
        {
            return JSRef!.Call<Color4>("clone");
        }
        #endregion
    }
}
