
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MaterialProperties
    {
        #region Properties
        /// <summary>
        /// allowOverride: boolean;
        /// </summary>
        bool? AllowOverride { get; set; }
        /// <summary>
        /// alphaHash: boolean;
        /// </summary>
        bool? AlphaHash { get; set; }
        /// <summary>
        /// alphaToCoverage: boolean;
        /// </summary>
        bool? AlphaToCoverage { get; set; }
        /// <summary>
        /// blendAlpha: number;
        /// </summary>
        float? BlendAlpha { get; set; }
        /// <summary>
        /// blendColor: Color;
        /// </summary>
        Color? BlendColor { get; set; }
        /// <summary>
        /// blendDst: BlendingDstFactor;
        /// </summary>
        BlendingDstFactor? BlendDst { get; set; }
        /// <summary>
        /// blendDstAlpha: BlendingDstFactor | null;
        /// </summary>
        BlendingDstFactor? BlendDstAlpha { get; set; }
        /// <summary>
        /// blendEquation: BlendingEquation;
        /// </summary>
        BlendingEquation? BlendEquation { get; set; }
        /// <summary>
        /// blendEquationAlpha: BlendingEquation | null;
        /// </summary>
        BlendingEquation? BlendEquationAlpha { get; set; }
        /// <summary>
        /// blending: Blending;
        /// </summary>
        Blending? Blending { get; set; }
        /// <summary>
        /// blendSrc: BlendingSrcFactor;
        /// </summary>
        BlendingSrcFactor? BlendSrc { get; set; }
        /// <summary>
        /// blendSrcAlpha: BlendingSrcFactor | null;
        /// </summary>
        BlendingSrcFactor? BlendSrcAlpha { get; set; }
        /// <summary>
        /// clipIntersection: boolean;
        /// </summary>
        bool? ClipIntersection { get; set; }
        /// <summary>
        /// clippingPlanes: Array<Plane> | null;
        /// </summary>
        Array<Plane>? ClippingPlanes { get; set; }
        /// <summary>
        /// clipShadows: boolean;
        /// </summary>
        bool? ClipShadows { get; set; }
        /// <summary>
        /// colorWrite: boolean;
        /// </summary>
        bool? ColorWrite { get; set; }
        /// <summary>
        /// depthFunc: DepthModes;
        /// </summary>
        DepthModes? DepthFunc { get; set; }
        /// <summary>
        /// depthTest: boolean;
        /// </summary>
        bool? DepthTest { get; set; }
        /// <summary>
        /// depthWrite: boolean;
        /// </summary>
        bool? DepthWrite { get; set; }
        /// <summary>
        /// dithering: boolean;
        /// </summary>
        bool? Dithering { get; set; }
        /// <summary>
        /// forceSinglePass: boolean;
        /// </summary>
        bool? ForceSinglePass { get; set; }
        /// <summary>
        /// name: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// opacity: number;
        /// </summary>
        float? Opacity { get; set; }
        /// <summary>
        /// polygonOffset: boolean;
        /// </summary>
        bool? PolygonOffset { get; set; }
        /// <summary>
        /// polygonOffsetFactor: number;
        /// </summary>
        float? PolygonOffsetFactor { get; set; }
        /// <summary>
        /// polygonOffsetUnits: number;
        /// </summary>
        float? PolygonOffsetUnits { get; set; }
        /// <summary>
        /// precision: ("highp" | "mediump" | "lowp") | null;
        /// </summary>
        string? Precision { get; set; }
        /// <summary>
        /// premultipliedAlpha: boolean;
        /// </summary>
        bool? PremultipliedAlpha { get; set; }
        /// <summary>
        /// shadowSide: Side | null;
        /// </summary>
        Side? ShadowSide { get; set; }
        /// <summary>
        /// side: Side;
        /// </summary>
        Side? Side { get; set; }
        /// <summary>
        /// stencilFail: StencilOp;
        /// </summary>
        StencilOp? StencilFail { get; set; }
        /// <summary>
        /// stencilFunc: StencilFunc;
        /// </summary>
        StencilFunc? StencilFunc { get; set; }
        /// <summary>
        /// stencilFuncMask: number;
        /// </summary>
        float? StencilFuncMask { get; set; }
        /// <summary>
        /// stencilRef: number;
        /// </summary>
        float? StencilRef { get; set; }
        /// <summary>
        /// stencilWrite: boolean;
        /// </summary>
        bool? StencilWrite { get; set; }
        /// <summary>
        /// stencilWriteMask: number;
        /// </summary>
        float? StencilWriteMask { get; set; }
        /// <summary>
        /// stencilZFail: StencilOp;
        /// </summary>
        StencilOp? StencilZFail { get; set; }
        /// <summary>
        /// stencilZPass: StencilOp;
        /// </summary>
        StencilOp? StencilZPass { get; set; }
        /// <summary>
        /// toneMapped: boolean;
        /// </summary>
        bool? ToneMapped { get; set; }
        /// <summary>
        /// transparent: boolean;
        /// </summary>
        bool? Transparent { get; set; }
        /// <summary>
        /// userData: Record<string, any>;
        /// </summary>
        Record<string, object>? UserData { get; set; }
        /// <summary>
        /// vertexColors: boolean;
        /// </summary>
        bool? VertexColors { get; set; }
        /// <summary>
        /// visible: boolean;
        /// </summary>
        bool? Visible { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
