
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Box3Helper : LineSegments
    {
        #region Constructors
        /// <inheritdoc/>
        public Box3Helper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(box: Box3, color?: ColorRepresentation);
        /// </summary>
        public Box3Helper(Box3 box, ColorRepresentation color) : base(JS.New("THREE.Box3Helper", box, color)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// box: Box3;
        /// </summary>
        public Box3 Box { get => JSRef!.Get<Box3>("box"); set => JSRef!.Set("box", value); }
        /// <summary>
        /// override readonly type: string | "Box3Helper";
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
