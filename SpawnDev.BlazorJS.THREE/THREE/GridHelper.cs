
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class GridHelper : LineSegments<BufferGeometry, LineBasicMaterial>
    {
        #region Constructors
        /// <inheritdoc/>
        public GridHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(size?: number, divisions?: number, color1?: ColorRepresentation, color2?: ColorRepresentation);
        /// </summary>
        public GridHelper(float size, float divisions, ColorRepresentation color1, ColorRepresentation color2) : base(JS.New("THREE.GridHelper", size, divisions, color1, color2)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly type: string | "GridHelper";
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
