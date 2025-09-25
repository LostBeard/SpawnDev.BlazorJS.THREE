
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DataTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public DataTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         data?: TypedArray | null,
        ///         width?: number,
        ///         height?: number,
        ///         format?: PixelFormat,
        ///         type?: TextureDataType,
        ///         mapping?: Mapping,
        ///         wrapS?: Wrapping,
        ///         wrapT?: Wrapping,
        ///         magFilter?: MagnificationTextureFilter,
        ///         minFilter?: MinificationTextureFilter,
        ///         anisotropy?: number,
        ///         colorSpace?: string,
        ///     );
        /// </summary>
        public DataTexture(TypedArray data, float width, float height, PixelFormat format, TextureDataType type, Mapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, float anisotropy, string colorSpace) : base(JS.NewApply("THREE.DataTexture", new object[] { data, width, height, format, type, mapping, wrapS, wrapT, magFilter, minFilter, anisotropy, colorSpace })) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// flipY: boolean;
        /// </summary>
        public bool FlipY { get => JSRef!.Get<bool>("flipY"); set => JSRef!.Set("flipY", value); }
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        public bool GenerateMipmaps { get => JSRef!.Get<bool>("generateMipmaps"); set => JSRef!.Set("generateMipmaps", value); }
        /// <summary>
        /// get image(): TextureImageData;
        /// </summary>
        public TextureImageData Image { get => JSRef!.Get<TextureImageData>("image"); set => JSRef!.Set("image", value); }
        /// <summary>
        /// readonly isDataTexture: true;
        /// </summary>
        public bool IsDataTexture { get => JSRef!.Get<bool>("isDataTexture"); }
        /// <summary>
        /// magFilter: MagnificationTextureFilter;
        /// </summary>
        public MagnificationTextureFilter MagFilter { get => JSRef!.Get<MagnificationTextureFilter>("magFilter"); set => JSRef!.Set("magFilter", value); }
        /// <summary>
        /// minFilter: MinificationTextureFilter;
        /// </summary>
        public MinificationTextureFilter MinFilter { get => JSRef!.Get<MinificationTextureFilter>("minFilter"); set => JSRef!.Set("minFilter", value); }
        /// <summary>
        /// unpackAlignment: number;
        /// </summary>
        public float UnpackAlignment { get => JSRef!.Get<float>("unpackAlignment"); set => JSRef!.Set("unpackAlignment", value); }
        #endregion

        #region Methods

        #endregion
    }
}
