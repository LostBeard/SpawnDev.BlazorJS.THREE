
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class VideoTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public VideoTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         video: HTMLVideoElement,
        ///         mapping?: Mapping,
        ///         wrapS?: Wrapping,
        ///         wrapT?: Wrapping,
        ///         magFilter?: MagnificationTextureFilter,
        ///         minFilter?: MinificationTextureFilter,
        ///         format?: PixelFormat,
        ///         type?: TextureDataType,
        ///         anisotropy?: number,
        ///     );
        /// </summary>
        public VideoTexture(HTMLVideoElement video, Mapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, PixelFormat format, TextureDataType type, float anisotropy) : base(JS.New("THREE.VideoTexture", video, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        public bool GenerateMipmaps { get => JSRef!.Get<bool>("generateMipmaps"); set => JSRef!.Set("generateMipmaps", value); }
        /// <summary>
        /// readonly isVideoTexture: true;
        /// </summary>
        public bool IsVideoTexture { get => JSRef!.Get<bool>("isVideoTexture"); }
        /// <summary>
        /// magFilter: MagnificationTextureFilter;
        /// </summary>
        public MagnificationTextureFilter MagFilter { get => JSRef!.Get<MagnificationTextureFilter>("magFilter"); set => JSRef!.Set("magFilter", value); }
        /// <summary>
        /// minFilter: MinificationTextureFilter;
        /// </summary>
        public MinificationTextureFilter MinFilter { get => JSRef!.Get<MinificationTextureFilter>("minFilter"); set => JSRef!.Set("minFilter", value); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(): void;
        /// </summary>
        public void Update()
        {
            JSRef!.CallVoid("update");
        }
        #endregion
    }
}
