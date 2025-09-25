
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LineSegments : Line
    {
        /// <inheritdoc/>
        public LineSegments(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class LineSegments<TGeometry, TMaterial> : Line<TGeometry, TMaterial>
    {
        #region Constructors
        /// <inheritdoc/>
        public LineSegments(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(geometry?: TGeometry, material?: TMaterial);
        /// </summary>
        public LineSegments(GeometryData geometry, Material material) : base(JS.New("THREE.LineSegments", geometry, material)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLineSegments: true;
        /// </summary>
        public bool IsLineSegments { get => JSRef!.Get<bool>("isLineSegments"); }
        /// <summary>
        /// override readonly type: string | "LineSegments";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
