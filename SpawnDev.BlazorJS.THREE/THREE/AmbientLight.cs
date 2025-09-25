
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AmbientLight : Light
    {
        #region Constructors
        /// <inheritdoc/>
        public AmbientLight(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color?: ColorRepresentation, intensity?: number);
        /// </summary>
        public AmbientLight(ColorRepresentation color, float intensity) : base(JS.New("THREE.AmbientLight", color, intensity)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isAmbientLight: true;
        /// </summary>
        public bool IsAmbientLight { get => JSRef!.Get<bool>("isAmbientLight"); }
        /// <summary>
        /// override readonly type: string | "AmbientLight";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
