
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface RendererParameters
    {
        #region Properties
        /// <summary>
        /// alpha?: boolean | undefined;
        /// </summary>
        bool? Alpha { get; set; }
        /// <summary>
        /// antialias?: boolean | undefined;
        /// </summary>
        bool? Antialias { get; set; }
        /// <summary>
        /// colorBufferType?: TextureDataType | undefined;
        /// </summary>
        TextureDataType? ColorBufferType { get; set; }
        /// <summary>
        /// depth?: boolean | undefined;
        /// </summary>
        bool? Depth { get; set; }
        /// <summary>
        /// getFallback?: ((error: object) => Backend) | null | undefined;
        /// </summary>
        Callback? GetFallback { get; set; }
        /// <summary>
        /// logarithmicDepthBuffer?: boolean | undefined;
        /// </summary>
        bool? LogarithmicDepthBuffer { get; set; }
        /// <summary>
        /// multiview?: boolean | undefined;
        /// </summary>
        bool? Multiview { get; set; }
        /// <summary>
        /// samples?: number | undefined;
        /// </summary>
        float? Samples { get; set; }
        /// <summary>
        /// stencil?: boolean | undefined;
        /// </summary>
        bool? Stencil { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
