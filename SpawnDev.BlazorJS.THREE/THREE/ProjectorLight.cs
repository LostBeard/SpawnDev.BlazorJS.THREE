
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ProjectorLight : SpotLight
    {
        #region Constructors
        /// <inheritdoc/>
        public ProjectorLight(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         color?: ColorRepresentation,
        ///         intensity?: number,
        ///         distance?: number,
        ///         angle?: number,
        ///         penumbra?: number,
        ///         decay?: number,
        ///     );
        /// </summary>
        public ProjectorLight(ColorRepresentation color, float intensity, float distance, float angle, float penumbra, float decay) : base(JS.New("THREE.ProjectorLight", color, intensity, distance, angle, penumbra, decay)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// aspect: number | null;
        /// </summary>
        public float Aspect { get => JSRef!.Get<float>("aspect"); set => JSRef!.Set("aspect", value); }
        #endregion

        #region Methods

        #endregion
    }
}
