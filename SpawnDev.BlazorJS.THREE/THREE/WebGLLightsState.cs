
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebGLLightsState
    {
        #region Properties
        /// <summary>
        /// ambient: number[];
        /// </summary>
        Array<float>? Ambient { get; set; }
        /// <summary>
        /// directional: any[];
        /// </summary>
        Array<object>? Directional { get; set; }
        /// <summary>
        /// directionalShadow: any[];
        /// </summary>
        Array<object>? DirectionalShadow { get; set; }
        /// <summary>
        /// directionalShadowMap: any[];
        /// </summary>
        Array<object>? DirectionalShadowMap { get; set; }
        /// <summary>
        /// directionalShadowMatrix: any[];
        /// </summary>
        Array<object>? DirectionalShadowMatrix { get; set; }
        /// <summary>
        /// hash: {
                ///         directionalLength: number;
                ///         pointLength: number;
                ///         spotLength: number;
                ///         rectAreaLength: number;
                ///         hemiLength: number;
                /// 
                ///         numDirectionalShadows: number;
                ///         numPointShadows: number;
                ///         numSpotShadows: number;
                ///         numSpotMaps: number;
                /// 
                ///         numLightProbes: number;
                ///     };
        /// </summary>
        object? Hash { get; set; }
        /// <summary>
        /// hemi: any[];
        /// </summary>
        Array<object>? Hemi { get; set; }
        /// <summary>
        /// numLightProbes: number;
        /// </summary>
        float? NumLightProbes { get; set; }
        /// <summary>
        /// numSpotLightShadowsWithMaps: number;
        /// </summary>
        float? NumSpotLightShadowsWithMaps { get; set; }
        /// <summary>
        /// point: any[];
        /// </summary>
        Array<object>? Point { get; set; }
        /// <summary>
        /// pointShadow: any[];
        /// </summary>
        Array<object>? PointShadow { get; set; }
        /// <summary>
        /// pointShadowMap: any[];
        /// </summary>
        Array<object>? PointShadowMap { get; set; }
        /// <summary>
        /// pointShadowMatrix: any[];
        /// </summary>
        Array<object>? PointShadowMatrix { get; set; }
        /// <summary>
        /// probe: any[];
        /// </summary>
        Array<object>? Probe { get; set; }
        /// <summary>
        /// rectArea: any[];
        /// </summary>
        Array<object>? RectArea { get; set; }
        /// <summary>
        /// spot: any[];
        /// </summary>
        Array<object>? Spot { get; set; }
        /// <summary>
        /// spotShadow: any[];
        /// </summary>
        Array<object>? SpotShadow { get; set; }
        /// <summary>
        /// spotShadowMap: any[];
        /// </summary>
        Array<object>? SpotShadowMap { get; set; }
        /// <summary>
        /// spotShadowMatrix: any[];
        /// </summary>
        Array<object>? SpotShadowMatrix { get; set; }
        /// <summary>
        /// version: number;
        /// </summary>
        float? Version { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
