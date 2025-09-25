
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CompressedArrayTexture : CompressedTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public CompressedArrayTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         mipmaps: CompressedTextureMipmap[],
        ///         width: number,
        ///         height: number,
        ///         depth: number,
        ///         format: CompressedPixelFormat,
        ///         type?: TextureDataType,
        ///     );
        /// </summary>
        public CompressedArrayTexture(Array<CompressedTextureMipmap> mipmaps, float width, float height, float depth, CompressedPixelFormat format, TextureDataType type) : base(JS.New("THREE.CompressedArrayTexture", mipmaps, width, height, depth, format, type)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get image(): { width: number; height: number; depth: number };
        /// </summary>
        public object Image { get => JSRef!.Get<object>("image"); set => JSRef!.Set("image", value); }
        /// <summary>
        /// readonly isCompressedArrayTexture: true;
        /// </summary>
        public bool IsCompressedArrayTexture { get => JSRef!.Get<bool>("isCompressedArrayTexture"); }
        /// <summary>
        /// layerUpdates: Set<number>;
        /// </summary>
        public Set<float> LayerUpdates { get => JSRef!.Get<Set<float>>("layerUpdates"); set => JSRef!.Set("layerUpdates", value); }
        /// <summary>
        /// wrapR: Wrapping;
        /// </summary>
        public Wrapping WrapR { get => JSRef!.Get<Wrapping>("wrapR"); set => JSRef!.Set("wrapR", value); }
        #endregion

        #region Methods
        /// <summary>
        /// clearLayoutUpdates(): void;
        /// </summary>
        public void ClearLayoutUpdates()
        {
            JSRef!.CallVoid("clearLayoutUpdates");
        }
        /// <summary>
        /// addLayerUpdate(layerIndex: number): void;
        /// </summary>
        public void AddLayerUpdate(float layerIndex)
        {
            JSRef!.CallVoid("addLayerUpdate", layerIndex);
        }
        #endregion
    }
}
