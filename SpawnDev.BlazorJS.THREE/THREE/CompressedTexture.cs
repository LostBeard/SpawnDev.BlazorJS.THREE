
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CompressedTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public CompressedTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         mipmaps: CompressedTextureMipmap[],
        ///         width: number,
        ///         height: number,
        ///         format?: CompressedPixelFormat,
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
        public CompressedTexture(Array<CompressedTextureMipmap> mipmaps, float width, float height, CompressedPixelFormat format, TextureDataType type, Mapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, float anisotropy, string colorSpace) : base(JS.NewApply("THREE.CompressedTexture", new object?[] { mipmaps, width, height, format, type, mapping, wrapS, wrapT, magFilter, minFilter, anisotropy, colorSpace })) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// flipY: boolean;
        /// </summary>
        public bool FlipY { get => JSRef!.Get<bool>("flipY"); set => JSRef!.Set("flipY", value); }
        /// <summary>
        /// format: CompressedPixelFormat;
        /// </summary>
        public CompressedPixelFormat Format { get => JSRef!.Get<CompressedPixelFormat>("format"); set => JSRef!.Set("format", value); }
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        public bool GenerateMipmaps { get => JSRef!.Get<bool>("generateMipmaps"); set => JSRef!.Set("generateMipmaps", value); }
        /// <summary>
        /// get image(): { width: number; height: number };
        /// </summary>
        public object Image { get => JSRef!.Get<object>("image"); set => JSRef!.Set("image", value); }
        /// <summary>
        /// readonly isCompressedTexture: true;
        /// </summary>
        public bool IsCompressedTexture { get => JSRef!.Get<bool>("isCompressedTexture"); }
        /// <summary>
        /// mipmaps: CompressedTextureMipmap[];
        /// </summary>
        public Array<CompressedTextureMipmap> Mipmaps { get => JSRef!.Get<Array<CompressedTextureMipmap>>("mipmaps"); set => JSRef!.Set("mipmaps", value); }
        #endregion

        #region Methods

        #endregion
    }
}
