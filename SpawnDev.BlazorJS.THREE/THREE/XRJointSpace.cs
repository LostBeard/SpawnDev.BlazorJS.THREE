
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class XRJointSpace : Group
    {
        #region Constructors
        /// <inheritdoc/>
        public XRJointSpace(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly jointRadius: number | undefined;
        /// </summary>
        public float JointRadius { get => JSRef!.Get<float>("jointRadius"); }
        #endregion

        #region Methods

        #endregion
    }
}
