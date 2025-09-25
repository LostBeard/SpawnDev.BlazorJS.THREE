
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CompressedCubeTexture : CompressedTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public CompressedCubeTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         images: Array<{ width: number; height: number }>,
        ///         format?: CompressedPixelFormat,
        ///         type?: TextureDataType,
        ///     );
        /// </summary>
        public CompressedCubeTexture(Array<object> images, CompressedPixelFormat format, TextureDataType type) : base(JS.New("THREE.CompressedCubeTexture", images, format, type)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isCompressedCubeTexture: true;
        /// </summary>
        public bool IsCompressedCubeTexture { get => JSRef!.Get<bool>("isCompressedCubeTexture"); }
        /// <summary>
        /// readonly isCubeTexture: true;
        /// </summary>
        public bool IsCubeTexture { get => JSRef!.Get<bool>("isCubeTexture"); }
        #endregion

        #region Methods

        #endregion
    }
}
