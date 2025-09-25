
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DataArrayTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public DataArrayTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(data?: BufferSource | null, width?: number, height?: number, depth?: number);
        /// </summary>
        public DataArrayTexture(BufferSource data, float width, float height, float depth) : base(JS.New("THREE.DataArrayTexture", data, width, height, depth)) { }
        
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
        /// readonly isDataArrayTexture: true;
        /// </summary>
        public bool IsDataArrayTexture { get => JSRef!.Get<bool>("isDataArrayTexture"); }
        /// <summary>
        /// layerUpdates: Set<number>;
        /// </summary>
        public Set<float> LayerUpdates { get => JSRef!.Get<Set<float>>("layerUpdates"); set => JSRef!.Set("layerUpdates", value); }
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
        /// wrapR: boolean;
        /// </summary>
        public bool WrapR { get => JSRef!.Get<bool>("wrapR"); set => JSRef!.Set("wrapR", value); }
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
