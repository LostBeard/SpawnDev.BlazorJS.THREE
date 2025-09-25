
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ShaderLibShader
    {
        #region Properties
        /// <summary>
        /// fragmentShader: string;
        /// </summary>
        string? FragmentShader { get; set; }
        /// <summary>
        /// uniforms: { [uniform: string]: IUniform };
        /// </summary>
        object? Uniforms { get; set; }
        /// <summary>
        /// vertexShader: string;
        /// </summary>
        string? VertexShader { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
