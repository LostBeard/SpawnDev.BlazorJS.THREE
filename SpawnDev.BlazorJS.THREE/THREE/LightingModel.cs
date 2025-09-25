
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LightingModel : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public LightingModel(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// start(builder: NodeBuilder): void;
        /// </summary>
        public void Start(NodeBuilder builder)
        {
            JSRef!.CallVoid("start", builder);
        }
        /// <summary>
        /// indirect(builder: NodeBuilder): void;
        /// </summary>
        public void Indirect(NodeBuilder builder)
        {
            JSRef!.CallVoid("indirect", builder);
        }
        /// <summary>
        /// finish(builder: NodeBuilder): void;
        /// </summary>
        public void Finish(NodeBuilder builder)
        {
            JSRef!.CallVoid("finish", builder);
        }
        /// <summary>
        /// directRectArea(lightData: LightingModelDirectRectAreaInput, builder: NodeBuilder): void;
        /// </summary>
        public void DirectRectArea(LightingModelDirectRectAreaInput lightData, NodeBuilder builder)
        {
            JSRef!.CallVoid("directRectArea", lightData, builder);
        }
        /// <summary>
        /// direct(lightData: LightingModelDirectInput, builder: NodeBuilder): void;
        /// </summary>
        public void Direct(LightingModelDirectInput lightData, NodeBuilder builder)
        {
            JSRef!.CallVoid("direct", lightData, builder);
        }
        /// <summary>
        /// ambientOcclusion(builder: NodeBuilder): void;
        /// </summary>
        public void AmbientOcclusion(NodeBuilder builder)
        {
            JSRef!.CallVoid("ambientOcclusion", builder);
        }
        #endregion
    }
}
