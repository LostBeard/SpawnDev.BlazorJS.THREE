
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderTarget3D : RenderTarget
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderTarget3D(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number, depth?: number, options?: RenderTargetOptions);
        /// </summary>
        public RenderTarget3D(float width, float height, float depth, RenderTargetOptions options) : base(JS.New("THREE.RenderTarget3D", width, height, depth, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isRenderTarget3D: true;
        /// </summary>
        public bool IsRenderTarget3D { get => JSRef!.Get<bool>("isRenderTarget3D"); }
        #endregion

        #region Methods

        #endregion
    }
}
