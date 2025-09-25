
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LineLoop<TGeometry, TMaterial> : Line<TGeometry, TMaterial>
    {
        #region Constructors
        /// <inheritdoc/>
        public LineLoop(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(geometry?: TGeometry, material?: TMaterial);
        /// </summary>
        public LineLoop(TGeometry geometry, TMaterial material) : base(JS.New("THREE.LineLoop", geometry, material)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLineLoop: true;
        /// </summary>
        public bool IsLineLoop { get => JSRef!.Get<bool>("isLineLoop"); }
        /// <summary>
        /// override readonly type: string | "LineLoop";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
