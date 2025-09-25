
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Color : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Color(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color?: ColorRepresentation);
        /// </summary>
        public Color(ColorRepresentation color) : base(JS.New("THREE.Color", color)) { }
        
        
        /// <summary>
        /// constructor(r: number, g: number, b: number);
        /// </summary>
        public Color(float r, float g, float b) : base(JS.New("THREE.Color", r, g, b)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// b: number;
        /// </summary>
        public float B { get => JSRef!.Get<float>("b"); set => JSRef!.Set("b", value); }
        /// <summary>
        /// g: number;
        /// </summary>
        public float G { get => JSRef!.Get<float>("g"); set => JSRef!.Set("g", value); }
        /// <summary>
        /// readonly isColor: true;
        /// </summary>
        public bool IsColor { get => JSRef!.Get<bool>("isColor"); }
        ///// <summary>
        ///// static NAMES: typeof _colorKeywords;
        ///// </summary>
        //public static _colorKeywords NAMES { get => JS.Get<_colorKeywords>("THREE.Color.NAMES"); set => JS.Set("THREE.Color.NAMES", value); }
        /// <summary>
        /// r: number;
        /// </summary>
        public float R { get => JSRef!.Get<float>("r"); set => JSRef!.Set("r", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(): number;
        /// </summary>
        public float ToJSON()
        {
            return JSRef!.Call<float>("toJSON");
        }
        /// <summary>
        /// toArray(array?: number[], offset?: number): number[];
        /// </summary>
        public Array<float> ToArray(Array<float> array, float offset)
        {
            return JSRef!.Call<Array<float>>("toArray", array, offset);
        }
        /// <summary>
        /// toArray(xyz: ArrayLike<number>, offset?: number): ArrayLike<number>;
        /// </summary>
        public ArrayLikeFloat ToArray(ArrayLikeFloat xyz, float offset)
        {
            return JSRef!.Call<ArrayLikeFloat>("toArray", xyz, offset);
        }
        /// <summary>
        /// sub(color: Color): this;
        /// </summary>
        public Color Sub(Color color)
        {
            return JSRef!.Call<Color>("sub", color);
        }
        /// <summary>
        /// setStyle(style: string, colorSpace?: string): Color;
        /// </summary>
        public Color SetStyle(string style, string colorSpace)
        {
            return JSRef!.Call<Color>("setStyle", style, colorSpace);
        }
        /// <summary>
        /// setScalar(scalar: number): Color;
        /// </summary>
        public Color SetScalar(float scalar)
        {
            return JSRef!.Call<Color>("setScalar", scalar);
        }
        /// <summary>
        /// setRGB(r: number, g: number, b: number, colorSpace?: string): Color;
        /// </summary>
        public Color SetRGB(float r, float g, float b, string colorSpace)
        {
            return JSRef!.Call<Color>("setRGB", r, g, b, colorSpace);
        }
        /// <summary>
        /// setHSL(h: number, s: number, l: number, colorSpace?: string): Color;
        /// </summary>
        public Color SetHSL(float h, float s, float l, string colorSpace)
        {
            return JSRef!.Call<Color>("setHSL", h, s, l, colorSpace);
        }
        /// <summary>
        /// setHex(hex: number, colorSpace?: string): Color;
        /// </summary>
        public Color SetHex(float hex, string colorSpace)
        {
            return JSRef!.Call<Color>("setHex", hex, colorSpace);
        }
        /// <summary>
        /// setFromVector3(vector: Vector3): this;
        /// </summary>
        public Color SetFromVector3(Vector3 vector)
        {
            return JSRef!.Call<Color>("setFromVector3", vector);
        }
        /// <summary>
        /// setColorName(style: string, colorSpace?: string): Color;
        /// </summary>
        public Color SetColorName(string style, string colorSpace)
        {
            return JSRef!.Call<Color>("setColorName", style, colorSpace);
        }
        ///// <summary>
        ///// set(...args: [color: ColorRepresentation] | [r: number, g: number, b: number]): this;
        ///// </summary>
        //public Color Set(params Union<(color, ColorRepresentation), (r, float, g, float, b, float)> args)
        //{
        //    return JSRef!.Call<Color>("set", args);
        //}
        /// <summary>
        /// offsetHSL(h: number, s: number, l: number): this;
        /// </summary>
        public Color OffsetHSL(float h, float s, float l)
        {
            return JSRef!.Call<Color>("offsetHSL", h, s, l);
        }
        /// <summary>
        /// multiplyScalar(s: number): this;
        /// </summary>
        public Color MultiplyScalar(float s)
        {
            return JSRef!.Call<Color>("multiplyScalar", s);
        }
        /// <summary>
        /// multiply(color: Color): this;
        /// </summary>
        public Color Multiply(Color color)
        {
            return JSRef!.Call<Color>("multiply", color);
        }
        /// <summary>
        /// lerpHSL(color: Color, alpha: number): this;
        /// </summary>
        public Color LerpHSL(Color color, float alpha)
        {
            return JSRef!.Call<Color>("lerpHSL", color, alpha);
        }
        /// <summary>
        /// lerpColors(color1: Color, color2: Color, alpha: number): this;
        /// </summary>
        public Color LerpColors(Color color1, Color color2, float alpha)
        {
            return JSRef!.Call<Color>("lerpColors", color1, color2, alpha);
        }
        /// <summary>
        /// lerp(color: Color, alpha: number): this;
        /// </summary>
        public Color Lerp(Color color, float alpha)
        {
            return JSRef!.Call<Color>("lerp", color, alpha);
        }
        /// <summary>
        /// getStyle(colorSpace?: string): string;
        /// </summary>
        public string GetStyle(string colorSpace)
        {
            return JSRef!.Call<string>("getStyle", colorSpace);
        }
        /// <summary>
        /// getRGB(target: RGB, colorSpace?: string): RGB;
        /// </summary>
        public RGB GetRGB(RGB target, string colorSpace)
        {
            return JSRef!.Call<RGB>("getRGB", target, colorSpace);
        }
        /// <summary>
        /// getHSL(target: HSL, colorSpace?: string): HSL;
        /// </summary>
        public HSL GetHSL(HSL target, string colorSpace)
        {
            return JSRef!.Call<HSL>("getHSL", target, colorSpace);
        }
        /// <summary>
        /// getHexString(colorSpace?: string): string;
        /// </summary>
        public string GetHexString(string colorSpace)
        {
            return JSRef!.Call<string>("getHexString", colorSpace);
        }
        /// <summary>
        /// getHex(colorSpace?: string): number;
        /// </summary>
        public float GetHex(string colorSpace)
        {
            return JSRef!.Call<float>("getHex", colorSpace);
        }
        /// <summary>
        /// fromBufferAttribute(attribute: BufferAttribute | InterleavedBufferAttribute, index: number): this;
        /// </summary>
        public Color FromBufferAttribute(Union<BufferAttribute, InterleavedBufferAttribute> attribute, float index)
        {
            return JSRef!.Call<Color>("fromBufferAttribute", attribute, index);
        }
        /// <summary>
        /// fromArray(array: number[] | ArrayLike<number>, offset?: number): this;
        /// </summary>
        public Color FromArray(Union<Array<float>, ArrayLikeFloat> array, float offset)
        {
            return JSRef!.Call<Color>("fromArray", array, offset);
        }
        /// <summary>
        /// equals(color: Color): boolean;
        /// </summary>
        public bool Equals(Color color)
        {
            return JSRef!.Call<bool>("equals", color);
        }
        /// <summary>
        /// copySRGBToLinear(color: Color): Color;
        /// </summary>
        public Color CopySRGBToLinear(Color color)
        {
            return JSRef!.Call<Color>("copySRGBToLinear", color);
        }
        /// <summary>
        /// copyLinearToSRGB(color: Color): Color;
        /// </summary>
        public Color CopyLinearToSRGB(Color color)
        {
            return JSRef!.Call<Color>("copyLinearToSRGB", color);
        }
        /// <summary>
        /// copy(color: Color): this;
        /// </summary>
        public Color Copy(Color color)
        {
            return JSRef!.Call<Color>("copy", color);
        }
        /// <summary>
        /// convertSRGBToLinear(): Color;
        /// </summary>
        public Color ConvertSRGBToLinear()
        {
            return JSRef!.Call<Color>("convertSRGBToLinear");
        }
        /// <summary>
        /// convertLinearToSRGB(): Color;
        /// </summary>
        public Color ConvertLinearToSRGB()
        {
            return JSRef!.Call<Color>("convertLinearToSRGB");
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Color Clone()
        {
            return JSRef!.Call<Color>("clone");
        }
        /// <summary>
        /// applyMatrix3(m: Matrix3): this;
        /// </summary>
        public Color ApplyMatrix3(Matrix3 m)
        {
            return JSRef!.Call<Color>("applyMatrix3", m);
        }
        /// <summary>
        /// addScalar(s: number): this;
        /// </summary>
        public Color AddScalar(float s)
        {
            return JSRef!.Call<Color>("addScalar", s);
        }
        /// <summary>
        /// addColors(color1: Color, color2: Color): this;
        /// </summary>
        public Color AddColors(Color color1, Color color2)
        {
            return JSRef!.Call<Color>("addColors", color1, color2);
        }
        /// <summary>
        /// add(color: Color): this;
        /// </summary>
        public Color Add(Color color)
        {
            return JSRef!.Call<Color>("add", color);
        }
        #endregion
    }
}
