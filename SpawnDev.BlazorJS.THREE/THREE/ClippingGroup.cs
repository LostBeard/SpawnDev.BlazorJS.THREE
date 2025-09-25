
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ClippingGroup : Group
    {
        #region Constructors
        /// <inheritdoc/>
        public ClippingGroup(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public ClippingGroup() : base(JS.New("THREE.ClippingGroup")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// clipIntersection: boolean;
        /// </summary>
        public bool ClipIntersection { get => JSRef!.Get<bool>("clipIntersection"); set => JSRef!.Set("clipIntersection", value); }
        /// <summary>
        /// clippingPlanes: Plane[];
        /// </summary>
        public Array<Plane> ClippingPlanes { get => JSRef!.Get<Array<Plane>>("clippingPlanes"); set => JSRef!.Set("clippingPlanes", value); }
        /// <summary>
        /// clipShadows: boolean;
        /// </summary>
        public bool ClipShadows { get => JSRef!.Get<bool>("clipShadows"); set => JSRef!.Set("clipShadows", value); }
        /// <summary>
        /// enabled: boolean;
        /// </summary>
        public bool Enabled { get => JSRef!.Get<bool>("enabled"); set => JSRef!.Set("enabled", value); }
        /// <summary>
        /// readonly isClippingGroup: true;
        /// </summary>
        public bool IsClippingGroup { get => JSRef!.Get<bool>("isClippingGroup"); }
        #endregion

        #region Methods

        #endregion
    }
}
