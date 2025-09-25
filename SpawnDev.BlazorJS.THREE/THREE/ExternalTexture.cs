
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ExternalTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public ExternalTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(sourceTexture?: WebGLTexture | GPUTexture | null);
        /// </summary>
        public ExternalTexture(Union<WebGLTexture, GPUTexture> sourceTexture) : base(JS.New("THREE.ExternalTexture", sourceTexture)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isExternalTexture: true;
        /// </summary>
        public bool IsExternalTexture { get => JSRef!.Get<bool>("isExternalTexture"); }
        /// <summary>
        /// sourceTexture: WebGLTexture | GPUTexture | null;
        /// </summary>
        public Union<WebGLTexture, GPUTexture> SourceTexture { get => JSRef!.Get<Union<WebGLTexture, GPUTexture>>("sourceTexture"); set => JSRef!.Set("sourceTexture", value); }
        #endregion

        #region Methods

        #endregion
    }
}
