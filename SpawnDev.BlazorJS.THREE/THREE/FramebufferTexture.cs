
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class FramebufferTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public FramebufferTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width: number, height: number);
        /// </summary>
        public FramebufferTexture(float width, float height) : base(JS.New("THREE.FramebufferTexture", width, height)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        public bool GenerateMipmaps { get => JSRef!.Get<bool>("generateMipmaps"); set => JSRef!.Set("generateMipmaps", value); }
        /// <summary>
        /// readonly isFramebufferTexture: true;
        /// </summary>
        public bool IsFramebufferTexture { get => JSRef!.Get<bool>("isFramebufferTexture"); }
        /// <summary>
        /// magFilter: MagnificationTextureFilter;
        /// </summary>
        public MagnificationTextureFilter MagFilter { get => JSRef!.Get<MagnificationTextureFilter>("magFilter"); set => JSRef!.Set("magFilter", value); }
        /// <summary>
        /// minFilter: MinificationTextureFilter;
        /// </summary>
        public MinificationTextureFilter MinFilter { get => JSRef!.Get<MinificationTextureFilter>("minFilter"); set => JSRef!.Set("minFilter", value); }
        #endregion

        #region Methods

        #endregion
    }
}
