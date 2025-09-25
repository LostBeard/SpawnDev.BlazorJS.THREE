
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface TextureJSON
    {
        #region Properties
        /// <summary>
        /// anisotropy: number;
        /// </summary>
        float? Anisotropy { get; set; }
        /// <summary>
        /// center: [x: number, y: number];
        /// </summary>
        (float x, float y)? Center { get; set; }
        /// <summary>
        /// channel: number;
        /// </summary>
        float? Channel { get; set; }
        /// <summary>
        /// colorSpace: string;
        /// </summary>
        string? ColorSpace { get; set; }
        /// <summary>
        /// flipY: boolean;
        /// </summary>
        bool? FlipY { get; set; }
        /// <summary>
        /// format: AnyPixelFormat;
        /// </summary>
        AnyPixelFormat? Format { get; set; }
        /// <summary>
        /// generateMipmaps: boolean;
        /// </summary>
        bool? GenerateMipmaps { get; set; }
        /// <summary>
        /// image: string;
        /// </summary>
        string? Image { get; set; }
        /// <summary>
        /// internalFormat: PixelFormatGPU | null;
        /// </summary>
        PixelFormatGPU? InternalFormat { get; set; }
        /// <summary>
        /// magFilter: MagnificationTextureFilter;
        /// </summary>
        MagnificationTextureFilter? MagFilter { get; set; }
        /// <summary>
        /// mapping: AnyMapping;
        /// </summary>
        AnyMapping? Mapping { get; set; }
        /// <summary>
        /// metadata: { version: number; type: string; generator: string };
        /// </summary>
        object? Metadata { get; set; }
        /// <summary>
        /// minFilter: MinificationTextureFilter;
        /// </summary>
        MinificationTextureFilter? MinFilter { get; set; }
        /// <summary>
        /// name: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// offset: [x: number, y: number];
        /// </summary>
        (float x, float y)? Offset { get; set; }
        /// <summary>
        /// premultiplyAlpha: boolean;
        /// </summary>
        bool? PremultiplyAlpha { get; set; }
        /// <summary>
        /// repeat: [x: number, y: number];
        /// </summary>
        (float x, float y)? Repeat { get; set; }
        /// <summary>
        /// rotation: number;
        /// </summary>
        float? Rotation { get; set; }
        /// <summary>
        /// type: TextureDataType;
        /// </summary>
        TextureDataType? Type { get; set; }
        /// <summary>
        /// unpackAlignment: number;
        /// </summary>
        float? UnpackAlignment { get; set; }
        /// <summary>
        /// userData?: Record<string, object>;
        /// </summary>
        Record<string, object>? UserData { get; set; }
        /// <summary>
        /// uuid: string;
        /// </summary>
        string? Uuid { get; set; }
        /// <summary>
        /// wrap: [wrapS: number, wrapT: number];
        /// </summary>
        (float wrapS, float wrapT)? Wrap { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
