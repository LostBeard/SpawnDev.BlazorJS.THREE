
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CanvasTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public CanvasTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         canvas?: TexImageSource | OffscreenCanvas,
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
        public CanvasTexture(TexImageSource canvas, Mapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, PixelFormat format, TextureDataType type, float anisotropy) : base(JS.New("THREE.CanvasTexture", canvas, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isCanvasTexture: true;
        /// </summary>
        public bool IsCanvasTexture { get => JSRef!.Get<bool>("isCanvasTexture"); }
        #endregion

        #region Methods

        #endregion
    }
}
