
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeSampledTexture3D : NodeSampledTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeSampledTexture3D(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isSampledTexture3D: true;
        /// </summary>
        public bool IsSampledTexture3D { get => JSRef!.Get<bool>("isSampledTexture3D"); }
        #endregion

        #region Methods

        #endregion
    }
}
