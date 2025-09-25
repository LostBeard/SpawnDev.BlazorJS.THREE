
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebGLProgramParametersWithUniforms : WebGLProgramParameters
    {
        #region Properties
        /// <summary>
        /// uniforms: { [uniform: string]: IUniform };
        /// </summary>
        object? Uniforms { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
