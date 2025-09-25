
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface WebGLDebug
    {
        #region Properties
        /// <summary>
        /// checkShaderErrors: boolean;
        /// </summary>
        bool? CheckShaderErrors { get; set; }
        /// <summary>
        /// onShaderError:
                ///         | ((
                ///             gl: WebGLRenderingContext,
                ///             program: WebGLProgram,
                ///             glVertexShader: WebGLShader,
                ///             glFragmentShader: WebGLShader,
                ///         ) => void)
                ///         | null;
        /// </summary>
        Callback? OnShaderError { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
