
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BundleGroup : Group
    {
        #region Constructors
        /// <inheritdoc/>
        public BundleGroup(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public BundleGroup() : base(JS.New("THREE.BundleGroup")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isBundleGroup: true;
        /// </summary>
        public bool IsBundleGroup { get => JSRef!.Get<bool>("isBundleGroup"); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// static: boolean;
        /// </summary>
        public bool Static { get => JSRef!.Get<bool>("static"); set => JSRef!.Set("static", value); }
        /// <summary>
        /// readonly type: string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        #endregion

        #region Methods

        #endregion
    }
}
