
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderBundles : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderBundles(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public RenderBundles() : base(JS.New("THREE.RenderBundles")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bundles: ChainMap<readonly[BundleGroup, Camera
        /// </summary>
        public ChainMap<object, Camera> Bundles { get => JSRef!.Get<ChainMap<object, Camera>>("bundles"); set => JSRef!.Set("bundles", value); }
        /// <summary>
        /// RenderBundle>;
        /// </summary>
        public JSObject RenderBundle { get => JSRef!.Get<JSObject>("RenderBundle"); set => JSRef!.Set("RenderBundle", value); }
        #endregion

        #region Methods
        /// <summary>
        /// get(bundleGroup: BundleGroup, camera: Camera): RenderBundle;
        /// </summary>
        public RenderBundle Get(BundleGroup bundleGroup, Camera camera)
        {
            return JSRef!.Call<RenderBundle>("get", bundleGroup, camera);
        }
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
