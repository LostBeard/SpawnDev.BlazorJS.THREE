
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class VideoFrameTexture : VideoTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public VideoFrameTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
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
        public VideoFrameTexture(Mapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, PixelFormat format, TextureDataType type, float anisotropy) : base(JS.New("THREE.VideoFrameTexture", mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// setFrame(frame: object): void;
        /// </summary>
        public void SetFrame(object frame)
        {
            JSRef!.CallVoid("setFrame", frame);
        }
        #endregion
    }
}
