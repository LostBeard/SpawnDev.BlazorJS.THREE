
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class XRTargetRaySpace : Group
    {
        #region Constructors
        /// <inheritdoc/>
        public XRTargetRaySpace(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly angularVelocity: Vector3;
        /// </summary>
        public Vector3 AngularVelocity { get => JSRef!.Get<Vector3>("angularVelocity"); }
        /// <summary>
        /// hasAngularVelocity: boolean;
        /// </summary>
        public bool HasAngularVelocity { get => JSRef!.Get<bool>("hasAngularVelocity"); set => JSRef!.Set("hasAngularVelocity", value); }
        /// <summary>
        /// hasLinearVelocity: boolean;
        /// </summary>
        public bool HasLinearVelocity { get => JSRef!.Get<bool>("hasLinearVelocity"); set => JSRef!.Set("hasLinearVelocity", value); }
        /// <summary>
        /// readonly linearVelocity: Vector3;
        /// </summary>
        public Vector3 LinearVelocity { get => JSRef!.Get<Vector3>("linearVelocity"); }
        #endregion

        #region Methods

        #endregion
    }
}
