
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PlaneHelper : LineSegments
    {
        #region Constructors
        /// <inheritdoc/>
        public PlaneHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(plane: Plane, size?: number, hex?: number);
        /// </summary>
        public PlaneHelper(Plane plane, float size, float hex) : base(JS.New("THREE.PlaneHelper", plane, size, hex)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// plane: Plane;
        /// </summary>
        public Plane Plane { get => JSRef!.Get<Plane>("plane"); set => JSRef!.Set("plane", value); }
        /// <summary>
        /// size: number;
        /// </summary>
        public float Size { get => JSRef!.Get<float>("size"); set => JSRef!.Set("size", value); }
        /// <summary>
        /// override readonly type: string | "PlaneHelper";
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
