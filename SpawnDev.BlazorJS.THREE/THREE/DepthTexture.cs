
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DepthTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public DepthTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         width: number,
        ///         height: number,
        ///         type?: TextureDataType,
        ///         mapping?: Mapping,
        ///         wrapS?: Wrapping,
        ///         wrapT?: Wrapping,
        ///         magFilter?: MagnificationTextureFilter,
        ///         minFilter?: MinificationTextureFilter,
        ///         anisotropy?: number,
        ///         format?: DepthTexturePixelFormat,
        ///         depth?: number,
        ///     );
        /// </summary>
        public DepthTexture(float width, float height, TextureDataType type, Mapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, float anisotropy, DepthTexturePixelFormat format, float depth) : base(JS.NewApply("THREE.DepthTexture", new object?[] { width, height, type, mapping, wrapS, wrapT, magFilter, minFilter, anisotropy, format, depth })) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// compareFunction: TextureComparisonFunction | null;
        /// </summary>
        public TextureComparisonFunction CompareFunction { get => JSRef!.Get<TextureComparisonFunction>("compareFunction"); set => JSRef!.Set("compareFunction", value); }
        /// <summary>
        /// flipY: boolean;
        /// </summary>
        public bool FlipY { get => JSRef!.Get<bool>("flipY"); set => JSRef!.Set("flipY", value); }
        /// <summary>
        /// format: DepthTexturePixelFormat;
        /// </summary>
        public DepthTexturePixelFormat Format { get => JSRef!.Get<DepthTexturePixelFormat>("format"); set => JSRef!.Set("format", value); }
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        public bool GenerateMipmaps { get => JSRef!.Get<bool>("generateMipmaps"); set => JSRef!.Set("generateMipmaps", value); }
        /// <summary>
        /// get image(): { width: number; height: number; depth: number };
        /// </summary>
        public object Image { get => JSRef!.Get<object>("image"); set => JSRef!.Set("image", value); }
        /// <summary>
        /// readonly isDepthTexture: true;
        /// </summary>
        public bool IsDepthTexture { get => JSRef!.Get<bool>("isDepthTexture"); }
        /// <summary>
        /// magFilter: MagnificationTextureFilter;
        /// </summary>
        public MagnificationTextureFilter MagFilter { get => JSRef!.Get<MagnificationTextureFilter>("magFilter"); set => JSRef!.Set("magFilter", value); }
        /// <summary>
        /// minFilter: MinificationTextureFilter;
        /// </summary>
        public MinificationTextureFilter MinFilter { get => JSRef!.Get<MinificationTextureFilter>("minFilter"); set => JSRef!.Set("minFilter", value); }
        /// <summary>
        /// type: TextureDataType;
        /// </summary>
        public TextureDataType Type { get => JSRef!.Get<TextureDataType>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods

        #endregion
    }
}
