
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface RenderTargetOptions : TextureParameters
    {
        #region Properties
        /// <summary>
        /// count?: number | undefined;
        /// </summary>
        float? Count { get; set; }
        /// <summary>
        /// depth?: number | undefined;
        /// </summary>
        float? Depth { get; set; }
        /// <summary>
        /// depthBuffer?: boolean | undefined;
        /// </summary>
        bool? DepthBuffer { get; set; }
        /// <summary>
        /// depthTexture?: DepthTexture | null | undefined;
        /// </summary>
        DepthTexture? DepthTexture { get; set; }
        /// <summary>
        /// multiview?: boolean | undefined;
        /// </summary>
        bool? Multiview { get; set; }
        /// <summary>
        /// resolveDepthBuffer?: boolean | undefined;
        /// </summary>
        bool? ResolveDepthBuffer { get; set; }
        /// <summary>
        /// resolveStencilBuffer?: boolean | undefined;
        /// </summary>
        bool? ResolveStencilBuffer { get; set; }
        /// <summary>
        /// samples?: number | undefined;
        /// </summary>
        float? Samples { get; set; }
        /// <summary>
        /// stencilBuffer?: boolean | undefined;
        /// </summary>
        bool? StencilBuffer { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
