
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CubeTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public CubeTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         images?: any[], // HTMLImageElement or HTMLCanvasElement
        ///         mapping?: CubeTextureMapping,
        ///         wrapS?: Wrapping,
        ///         wrapT?: Wrapping,
        ///         magFilter?: MagnificationTextureFilter,
        ///         minFilter?: MinificationTextureFilter,
        ///         format?: PixelFormat,
        ///         type?: TextureDataType,
        ///         anisotropy?: number,
        ///         colorSpace?: string,
        ///     );
        /// </summary>
        public CubeTexture(Array<object> images, CubeTextureMapping mapping, Wrapping wrapS, Wrapping wrapT, MagnificationTextureFilter magFilter, MinificationTextureFilter minFilter, PixelFormat format, TextureDataType type, float anisotropy, string colorSpace) : base(JS.New("THREE.CubeTexture", images, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy, colorSpace)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// flipY: boolean;
        /// </summary>
        public bool FlipY { get => JSRef!.Get<bool>("flipY"); set => JSRef!.Set("flipY", value); }
        /// <summary>
        /// get image(): any;
        /// </summary>
        public object Image { get => JSRef!.Get<object>("image"); set => JSRef!.Set("image", value); }
        /// <summary>
        /// get images(): any;
        /// </summary>
        public object Images { get => JSRef!.Get<object>("images"); set => JSRef!.Set("images", value); }
        /// <summary>
        /// readonly isCubeTexture: true;
        /// </summary>
        public bool IsCubeTexture { get => JSRef!.Get<bool>("isCubeTexture"); }
        /// <summary>
        /// mapping: CubeTextureMapping;
        /// </summary>
        public CubeTextureMapping Mapping { get => JSRef!.Get<CubeTextureMapping>("mapping"); set => JSRef!.Set("mapping", value); }
        #endregion

        #region Methods

        #endregion
    }
}
