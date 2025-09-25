
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class XRRenderTarget : RenderTarget
    {
        #region Constructors
        /// <inheritdoc/>
        public XRRenderTarget(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number, options?: RenderTargetOptions);
        /// </summary>
        public XRRenderTarget(float width, float height, RenderTargetOptions options) : base(JS.New("THREE.XRRenderTarget", width, height, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isXRRenderTarget: true;
        /// </summary>
        public bool IsXRRenderTarget { get => JSRef!.Get<bool>("isXRRenderTarget"); }
        #endregion

        #region Methods
        /// <summary>
        /// copy(source: XRRenderTarget): this;
        /// </summary>
        public XRRenderTarget Copy(XRRenderTarget source)
        {
            return JSRef!.Call<XRRenderTarget>("copy", source);
        }
        #endregion
    }
}
