
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PolarGridHelper : LineSegments
    {
        #region Constructors
        /// <inheritdoc/>
        public PolarGridHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         radius?: number,
        ///         radials?: number,
        ///         circles?: number,
        ///         divisions?: number,
        ///         color1?: ColorRepresentation,
        ///         color2?: ColorRepresentation,
        ///     );
        /// </summary>
        public PolarGridHelper(float radius, float radials, float circles, float divisions, ColorRepresentation color1, ColorRepresentation color2) : base(JS.New("THREE.PolarGridHelper", radius, radials, circles, divisions, color1, color2)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly type: string | "PolarGridHelper";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
