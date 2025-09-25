
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class IESSpotLight : SpotLight
    {
        #region Constructors
        /// <inheritdoc/>
        public IESSpotLight(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// iesMap: Texture | null;
        /// </summary>
        public Texture IesMap { get => JSRef!.Get<Texture>("iesMap"); set => JSRef!.Set("iesMap", value); }
        #endregion

        #region Methods

        #endregion
    }
}
