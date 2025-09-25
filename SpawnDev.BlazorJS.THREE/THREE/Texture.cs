
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Texture : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public Texture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         image?: TexImageSource | OffscreenCanvas,
        ///         mapping?: Mapping,
        ///         wrapS?: Wrapping,
        ///         wrapT?: Wrapping,
        ///         magFilter?: MagnificationTextureFilter,
        ///         minFilter?: MinificationTextureFilter,
        ///         format?: PixelFormat,
        ///         type?: TextureDataType,
        ///         anisotropy?: number,
        ///         colorSpace?: ColorSpace,
        ///     );
        /// </summary>
        public Texture(Union<TexImageSource, OffscreenCanvas> image, Mapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, PixelFormat format, TextureDataType type, float anisotropy, ColorSpace colorSpace) : base(JS.New("THREE.Texture", image, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy, colorSpace)) { }
        
        
        /// <summary>
        /// constructor(
        ///         image: TexImageSource | OffscreenCanvas,
        ///         mapping: Mapping,
        ///         wrapS: Wrapping,
        ///         wrapT: Wrapping,
        ///         magFilter: MagnificationTextureFilter,
        ///         minFilter: MinificationTextureFilter,
        ///         format: PixelFormat,
        ///         type: TextureDataType,
        ///         anisotropy: number,
        ///     );
        /// </summary>
        public Texture(Union<TexImageSource, OffscreenCanvas> image, Mapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, PixelFormat format, TextureDataType type, float anisotropy) : base(JS.New("THREE.Texture", image, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// anisotropy: number;
        /// </summary>
        public float Anisotropy { get => JSRef!.Get<float>("anisotropy"); set => JSRef!.Set("anisotropy", value); }
        /// <summary>
        /// center: Vector2;
        /// </summary>
        public Vector2 Center { get => JSRef!.Get<Vector2>("center"); set => JSRef!.Set("center", value); }
        /// <summary>
        /// channel: number;
        /// </summary>
        public float Channel { get => JSRef!.Get<float>("channel"); set => JSRef!.Set("channel", value); }
        /// <summary>
        /// colorSpace: string;
        /// </summary>
        public string ColorSpace { get => JSRef!.Get<string>("colorSpace"); set => JSRef!.Set("colorSpace", value); }
        /// <summary>
        /// static DEFAULT_ANISOTROPY: number;
        /// </summary>
        public static float DEFAULT_ANISOTROPY { get => JS.Get<float>("THREE.Texture.DEFAULT_ANISOTROPY"); set => JS.Set("THREE.Texture.DEFAULT_ANISOTROPY", value); }
        /// <summary>
        /// static DEFAULT_IMAGE: any;
        /// </summary>
        public static object DEFAULT_IMAGE { get => JS.Get<object>("THREE.Texture.DEFAULT_IMAGE"); set => JS.Set("THREE.Texture.DEFAULT_IMAGE", value); }
        /// <summary>
        /// static DEFAULT_MAPPING: Mapping;
        /// </summary>
        public static Mapping DEFAULT_MAPPING { get => JS.Get<Mapping>("THREE.Texture.DEFAULT_MAPPING"); set => JS.Set("THREE.Texture.DEFAULT_MAPPING", value); }
        /// <summary>
        /// get depth(): number;
        /// </summary>
        public float Depth { get => JSRef!.Get<float>("depth"); }
        /// <summary>
        /// flipY: boolean;
        /// </summary>
        public bool FlipY { get => JSRef!.Get<bool>("flipY"); set => JSRef!.Set("flipY", value); }
        /// <summary>
        /// format: AnyPixelFormat;
        /// </summary>
        public AnyPixelFormat Format { get => JSRef!.Get<AnyPixelFormat>("format"); set => JSRef!.Set("format", value); }
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        public bool GenerateMipmaps { get => JSRef!.Get<bool>("generateMipmaps"); set => JSRef!.Set("generateMipmaps", value); }
        /// <summary>
        /// get height(): number;
        /// </summary>
        public float Height { get => JSRef!.Get<float>("height"); }
        /// <summary>
        /// readonly id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); }
        /// <summary>
        /// get image(): any;
        /// </summary>
        public object Image { get => JSRef!.Get<object>("image"); set => JSRef!.Set("image", value); }
        /// <summary>
        /// internalFormat: PixelFormatGPU | null;
        /// </summary>
        public PixelFormatGPU InternalFormat { get => JSRef!.Get<PixelFormatGPU>("internalFormat"); set => JSRef!.Set("internalFormat", value); }
        /// <summary>
        /// isArrayTexture: boolean;
        /// </summary>
        public bool IsArrayTexture { get => JSRef!.Get<bool>("isArrayTexture"); set => JSRef!.Set("isArrayTexture", value); }
        /// <summary>
        /// isRenderTargetTexture: boolean;
        /// </summary>
        public bool IsRenderTargetTexture { get => JSRef!.Get<bool>("isRenderTargetTexture"); set => JSRef!.Set("isRenderTargetTexture", value); }
        /// <summary>
        /// readonly isTexture: true;
        /// </summary>
        public bool IsTexture { get => JSRef!.Get<bool>("isTexture"); }
        /// <summary>
        /// magFilter: MagnificationTextureFilter;
        /// </summary>
        public MagnificationTextureFilter MagFilter { get => JSRef!.Get<MagnificationTextureFilter>("magFilter"); set => JSRef!.Set("magFilter", value); }
        /// <summary>
        /// mapping: AnyMapping;
        /// </summary>
        public AnyMapping Mapping { get => JSRef!.Get<AnyMapping>("mapping"); set => JSRef!.Set("mapping", value); }
        /// <summary>
        /// matrix: Matrix3;
        /// </summary>
        public Matrix3 Matrix { get => JSRef!.Get<Matrix3>("matrix"); set => JSRef!.Set("matrix", value); }
        /// <summary>
        /// matrixAutoUpdate: boolean;
        /// </summary>
        public bool MatrixAutoUpdate { get => JSRef!.Get<bool>("matrixAutoUpdate"); set => JSRef!.Set("matrixAutoUpdate", value); }
        /// <summary>
        /// minFilter: MinificationTextureFilter;
        /// </summary>
        public MinificationTextureFilter MinFilter { get => JSRef!.Get<MinificationTextureFilter>("minFilter"); set => JSRef!.Set("minFilter", value); }
        /// <summary>
        /// mipmaps: CompressedTextureMipmap[] | CubeTexture[] | HTMLCanvasElement[];
        /// </summary>
        public Union<Array<CompressedTextureMipmap>, Array<CubeTexture>, Array<HTMLCanvasElement>> Mipmaps { get => JSRef!.Get<Union<Array<CompressedTextureMipmap>, Array<CubeTexture>, Array<HTMLCanvasElement>>>("mipmaps"); set => JSRef!.Set("mipmaps", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// set needsPMREMUpdate(value: boolean);
        /// </summary>
        public bool NeedsPMREMUpdate { get => JSRef!.Get<bool>("needsPMREMUpdate"); set => JSRef!.Set("needsPMREMUpdate", value); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// offset: Vector2;
        /// </summary>
        public Vector2 Offset { get => JSRef!.Get<Vector2>("offset"); set => JSRef!.Set("offset", value); }
        /// <summary>
        /// onUpdate: ((texture: Texture) => void) | null;
        /// </summary>
        public Callback OnUpdate { get => JSRef!.Get<Callback>("onUpdate"); set => JSRef!.Set("onUpdate", value); }
        /// <summary>
        /// pmremVersion: number;
        /// </summary>
        public float PmremVersion { get => JSRef!.Get<float>("pmremVersion"); set => JSRef!.Set("pmremVersion", value); }
        /// <summary>
        /// premultiplyAlpha: boolean;
        /// </summary>
        public bool PremultiplyAlpha { get => JSRef!.Get<bool>("premultiplyAlpha"); set => JSRef!.Set("premultiplyAlpha", value); }
        /// <summary>
        /// renderTarget: RenderTarget | null;
        /// </summary>
        public RenderTarget RenderTarget { get => JSRef!.Get<RenderTarget>("renderTarget"); set => JSRef!.Set("renderTarget", value); }
        /// <summary>
        /// repeat: Vector2;
        /// </summary>
        public Vector2 Repeat { get => JSRef!.Get<Vector2>("repeat"); set => JSRef!.Set("repeat", value); }
        /// <summary>
        /// rotation: number;
        /// </summary>
        public float Rotation { get => JSRef!.Get<float>("rotation"); set => JSRef!.Set("rotation", value); }
        /// <summary>
        /// source: Source;
        /// </summary>
        public Source Source { get => JSRef!.Get<Source>("source"); set => JSRef!.Set("source", value); }
        /// <summary>
        /// type: TextureDataType;
        /// </summary>
        public TextureDataType Type { get => JSRef!.Get<TextureDataType>("type"); set => JSRef!.Set("type", value); }
        /// <summary>
        /// unpackAlignment: number;
        /// </summary>
        public float UnpackAlignment { get => JSRef!.Get<float>("unpackAlignment"); set => JSRef!.Set("unpackAlignment", value); }
        /// <summary>
        /// updateRanges: Array<{ start: number; count: number }>;
        /// </summary>
        public Array<object> UpdateRanges { get => JSRef!.Get<Array<object>>("updateRanges"); set => JSRef!.Set("updateRanges", value); }
        /// <summary>
        /// userData: Record<string, any>;
        /// </summary>
        public Record<string, object> UserData { get => JSRef!.Get<Record<string, object>>("userData"); set => JSRef!.Set("userData", value); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        /// <summary>
        /// get width(): number;
        /// </summary>
        public float Width { get => JSRef!.Get<float>("width"); }
        /// <summary>
        /// wrapS: Wrapping;
        /// </summary>
        public Wrapping WrapS { get => JSRef!.Get<Wrapping>("wrapS"); set => JSRef!.Set("wrapS", value); }
        /// <summary>
        /// wrapT: Wrapping;
        /// </summary>
        public Wrapping WrapT { get => JSRef!.Get<Wrapping>("wrapT"); set => JSRef!.Set("wrapT", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateMatrix(): void;
        /// </summary>
        public void UpdateMatrix()
        {
            JSRef!.CallVoid("updateMatrix");
        }
        /// <summary>
        /// transformUv(uv: Vector2): Vector2;
        /// </summary>
        public Vector2 TransformUv(Vector2 uv)
        {
            return JSRef!.Call<Vector2>("transformUv", uv);
        }
        /// <summary>
        /// toJSON(meta?: string | {}): TextureJSON;
        /// </summary>
        public TextureJSON ToJSON(Union<string, object> meta)
        {
            return JSRef!.Call<TextureJSON>("toJSON", meta);
        }
        /// <summary>
        /// setValues(values: TextureParameters): void;
        /// </summary>
        public void SetValues(TextureParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// copy(source: Texture): this;
        /// </summary>
        public Texture Copy(Texture source)
        {
            return JSRef!.Call<Texture>("copy", source);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Texture Clone()
        {
            return JSRef!.Call<Texture>("clone");
        }
        /// <summary>
        /// clearUpdateRanges(): void;
        /// </summary>
        public void ClearUpdateRanges()
        {
            JSRef!.CallVoid("clearUpdateRanges");
        }
        /// <summary>
        /// addUpdateRange(start: number, count: number): void;
        /// </summary>
        public void AddUpdateRange(float start, float count)
        {
            JSRef!.CallVoid("addUpdateRange", start, count);
        }
        #endregion
    }
}
