
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface RenderTargetData
    {
        #region Properties
        /// <summary>
        /// depth?: boolean;
        /// </summary>
        bool? Depth { get; set; }
        /// <summary>
        /// depthTexture?: DepthTexture;
        /// </summary>
        DepthTexture? DepthTexture { get; set; }
        /// <summary>
        /// depthTextureMips?: {
                ///         [activeMipmapLevel: number]: DepthTexture;
                ///     };
        /// </summary>
        object? DepthTextureMips { get; set; }
        /// <summary>
        /// height?: number;
        /// </summary>
        float? Height { get; set; }
        /// <summary>
        /// initialized?: boolean;
        /// </summary>
        bool? Initialized { get; set; }
        /// <summary>
        /// renderTarget?: RenderTarget;
        /// </summary>
        RenderTarget? RenderTarget { get; set; }
        /// <summary>
        /// sampleCount?: number;
        /// </summary>
        float? SampleCount { get; set; }
        /// <summary>
        /// stencil?: boolean;
        /// </summary>
        bool? Stencil { get; set; }
        /// <summary>
        /// textures?: Texture[];
        /// </summary>
        Array<Texture>? Textures { get; set; }
        /// <summary>
        /// width?: number;
        /// </summary>
        float? Width { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
