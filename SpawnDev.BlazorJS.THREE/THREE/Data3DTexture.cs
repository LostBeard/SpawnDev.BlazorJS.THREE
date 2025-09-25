
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Data3DTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public Data3DTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(data?: TypedArray | null, width?: number, height?: number, depth?: number);
        /// </summary>
        public Data3DTexture(TypedArray data, float width, float height, float depth) : base(JS.New("THREE.Data3DTexture", data, width, height, depth)) { }
        
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
        /// get image(): Texture3DImageData;
        /// </summary>
        public Texture3DImageData Image { get => JSRef!.Get<Texture3DImageData>("image"); set => JSRef!.Set("image", value); }
        /// <summary>
        /// readonly isData3DTexture: true;
        /// </summary>
        public bool IsData3DTexture { get => JSRef!.Get<bool>("isData3DTexture"); }
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
        /// <summary>
        /// wrapR: Wrapping;
        /// </summary>
        public Wrapping WrapR { get => JSRef!.Get<Wrapping>("wrapR"); set => JSRef!.Set("wrapR", value); }
        #endregion

        #region Methods

        #endregion
    }
}
