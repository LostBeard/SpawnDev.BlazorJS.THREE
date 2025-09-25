
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ShaderMaterialJSON : MaterialJSON
    {
        #region Properties
        /// <summary>
        /// clipping: boolean;
        /// </summary>
        bool? Clipping { get; set; }
        /// <summary>
        /// defines?: Record<string, object>;
        /// </summary>
        Record<string, object>? Defines { get; set; }
        /// <summary>
        /// extensions?: Record<string, boolean>;
        /// </summary>
        Record<string, bool>? Extensions { get; set; }
        /// <summary>
        /// fragmentShader: string;
        /// </summary>
        string? FragmentShader { get; set; }
        /// <summary>
        /// glslVersion: number | null;
        /// </summary>
        float? GlslVersion { get; set; }
        /// <summary>
        /// lights: boolean;
        /// </summary>
        bool? Lights { get; set; }
        /// <summary>
        /// uniforms: Record<string, ShaderMaterialUniformJSON>;
        /// </summary>
        Record<string, ShaderMaterialUniformJSON>? Uniforms { get; set; }
        /// <summary>
        /// vertexShader: string;
        /// </summary>
        string? VertexShader { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
