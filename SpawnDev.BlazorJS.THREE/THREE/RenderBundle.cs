
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderBundle : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderBundle(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(bundleGroup: BundleGroup, camera: Camera);
        /// </summary>
        public RenderBundle(BundleGroup bundleGroup, Camera camera) : base(JS.New("THREE.RenderBundle", bundleGroup, camera)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bundleGroup: BundleGroup;
        /// </summary>
        public BundleGroup BundleGroup { get => JSRef!.Get<BundleGroup>("bundleGroup"); set => JSRef!.Set("bundleGroup", value); }
        /// <summary>
        /// camera: Camera;
        /// </summary>
        public Camera Camera { get => JSRef!.Get<Camera>("camera"); set => JSRef!.Set("camera", value); }
        #endregion

        #region Methods

        #endregion
    }
}
