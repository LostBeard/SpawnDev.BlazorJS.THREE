
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderContexts : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderContexts(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// chainMaps: {
                ///         [attachmentState: string]: ChainMap<readonly[Scene, Camera], RenderContext> | undefined;
        /// </summary>
        public JSObject ChainMaps { get => JSRef!.Get<JSObject>("chainMaps"); set => JSRef!.Set("chainMaps", value); }
        #endregion

        #region Methods

        #endregion
    }
}
