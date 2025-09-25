
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RawShaderMaterial : ShaderMaterial
    {
        #region Constructors
        /// <inheritdoc/>
        public RawShaderMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isRawShaderMaterial: boolean;
        /// </summary>
        public bool IsRawShaderMaterial { get => JSRef!.Get<bool>("isRawShaderMaterial"); }
        #endregion

        #region Methods

        #endregion
    }
}
