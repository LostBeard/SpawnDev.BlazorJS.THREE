
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface RendererState
    {
        #region Properties
        /// <summary>
        /// activeCubeFace: number;
        /// </summary>
        float? ActiveCubeFace { get; set; }
        /// <summary>
        /// activeMipmapLevel: number;
        /// </summary>
        float? ActiveMipmapLevel { get; set; }
        /// <summary>
        /// autoClear: boolean;
        /// </summary>
        bool? AutoClear { get; set; }
        /// <summary>
        /// clearAlpha: number;
        /// </summary>
        float? ClearAlpha { get; set; }
        /// <summary>
        /// clearColor: Color4;
        /// </summary>
        Color4? ClearColor { get; set; }
        /// <summary>
        /// mrt: MRTNode | null;
        /// </summary>
        MRTNode? Mrt { get; set; }
        /// <summary>
        /// outputColorSpace: string;
        /// </summary>
        string? OutputColorSpace { get; set; }
        /// <summary>
        /// pixelRatio: number;
        /// </summary>
        float? PixelRatio { get; set; }
        /// <summary>
        /// renderObjectFunction:
                ///         | ((
                ///             object: Object3D,
                ///             scene: Scene,
                ///             camera: Camera,
                ///             geometry: BufferGeometry,
                ///             material: Material,
                ///             group: GeometryGroup,
                ///             lightsNode: LightsNode,
                ///         ) => void)
                ///         | null;
        /// </summary>
        Callback? RenderObjectFunction { get; set; }
        /// <summary>
        /// renderTarget: RenderTarget | null;
        /// </summary>
        RenderTarget? RenderTarget { get; set; }
        /// <summary>
        /// scissorTest: boolean;
        /// </summary>
        bool? ScissorTest { get; set; }
        /// <summary>
        /// toneMapping: ToneMapping;
        /// </summary>
        ToneMapping? ToneMapping { get; set; }
        /// <summary>
        /// toneMappingExposure: number;
        /// </summary>
        float? ToneMappingExposure { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
