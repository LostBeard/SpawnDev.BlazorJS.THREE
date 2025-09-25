
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface TextureParameters
    {
        #region Properties
        /// <summary>
        /// anisotropy?: number | undefined;
        /// </summary>
        float? Anisotropy { get; set; }
        /// <summary>
        /// colorSpace?: ColorSpace | undefined;
        /// </summary>
        ColorSpace? ColorSpace { get; set; }
        /// <summary>
        /// flipY?: boolean | undefined;
        /// </summary>
        bool? FlipY { get; set; }
        /// <summary>
        /// format?: PixelFormat | undefined;
        /// </summary>
        PixelFormat? Format { get; set; }
        /// <summary>
        /// generateMipmaps?: boolean | undefined;
        /// </summary>
        bool? GenerateMipmaps { get; set; }
        /// <summary>
        /// internalFormat?: PixelFormatGPU | null | undefined;
        /// </summary>
        PixelFormatGPU? InternalFormat { get; set; }
        /// <summary>
        /// magFilter?: MagnificationTextureFilter | undefined;
        /// </summary>
        MagnificationTextureFilter? MagFilter { get; set; }
        /// <summary>
        /// mapping?: AnyMapping | undefined;
        /// </summary>
        AnyMapping? Mapping { get; set; }
        /// <summary>
        /// minFilter?: MinificationTextureFilter | undefined;
        /// </summary>
        MinificationTextureFilter? MinFilter { get; set; }
        /// <summary>
        /// type?: TextureDataType | undefined;
        /// </summary>
        TextureDataType? Type { get; set; }
        /// <summary>
        /// wrapR?: Wrapping | undefined;
        /// </summary>
        Wrapping? WrapR { get; set; }
        /// <summary>
        /// wrapS?: Wrapping | undefined;
        /// </summary>
        Wrapping? WrapS { get; set; }
        /// <summary>
        /// wrapT?: Wrapping | undefined;
        /// </summary>
        Wrapping? WrapT { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
