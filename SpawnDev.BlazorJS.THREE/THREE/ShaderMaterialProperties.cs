
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ShaderMaterialProperties : MaterialProperties
    {
        #region Properties
        /// <summary>
        /// clipping: boolean;
        /// </summary>
        bool? Clipping { get; set; }
        /// <summary>
        /// defaultAttributeValues: {
                ///         color: [number, number, number];
                ///         uv: [number, number];
                ///         uv1: [number, number];
                ///     };
        /// </summary>
        object? DefaultAttributeValues { get; set; }
        /// <summary>
        /// defines: { [key: string]: any };
        /// </summary>
        object? Defines { get; set; }
        /// <summary>
        /// extensions: {
                ///         clipCullDistance: boolean;
                ///         multiDraw: boolean;
                ///     };
        /// </summary>
        object? Extensions { get; set; }
        /// <summary>
        /// fog: boolean;
        /// </summary>
        bool? Fog { get; set; }
        /// <summary>
        /// fragmentShader: string;
        /// </summary>
        string? FragmentShader { get; set; }
        /// <summary>
        /// glslVersion: GLSLVersion | null;
        /// </summary>
        GLSLVersion? GlslVersion { get; set; }
        /// <summary>
        /// index0AttributeName: string | undefined;
        /// </summary>
        string? Index0AttributeName { get; set; }
        /// <summary>
        /// lights: boolean;
        /// </summary>
        bool? Lights { get; set; }
        /// <summary>
        /// linewidth: number;
        /// </summary>
        float? Linewidth { get; set; }
        /// <summary>
        /// uniforms: { [uniform: string]: IUniform };
        /// </summary>
        object? Uniforms { get; set; }
        /// <summary>
        /// uniformsGroups: Array<UniformsGroup>;
        /// </summary>
        Array<UniformsGroup>? UniformsGroups { get; set; }
        /// <summary>
        /// uniformsNeedUpdate: boolean;
        /// </summary>
        bool? UniformsNeedUpdate { get; set; }
        /// <summary>
        /// vertexShader: string;
        /// </summary>
        string? VertexShader { get; set; }
        /// <summary>
        /// wireframe: boolean;
        /// </summary>
        bool? Wireframe { get; set; }
        /// <summary>
        /// wireframeLinewidth: number;
        /// </summary>
        float? WireframeLinewidth { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
