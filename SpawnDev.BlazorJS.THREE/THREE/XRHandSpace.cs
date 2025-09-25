
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class XRHandSpace : Group
    {
        #region Constructors
        /// <inheritdoc/>
        public XRHandSpace(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly inputState: XRHandInputState;
        /// </summary>
        public XRHandInputState InputState { get => JSRef!.Get<XRHandInputState>("inputState"); }
        /// <summary>
        /// readonly joints: Partial<XRHandJoints>;
        /// </summary>
        public XRHandJoints Joints { get => JSRef!.Get<XRHandJoints>("joints"); }
        #endregion

        #region Methods

        #endregion
    }
}
