
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SSSLightingModel : PhysicalLightingModel
    {
        #region Constructors
        /// <inheritdoc/>
        public SSSLightingModel(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         clearcoat?: boolean,
        ///         sheen?: boolean,
        ///         iridescence?: boolean,
        ///         anisotropy?: boolean,
        ///         transmission?: boolean,
        ///         dispersion?: boolean,
        ///         sss?: boolean,
        ///     );
        /// </summary>
        public SSSLightingModel(bool clearcoat, bool sheen, bool iridescence, bool anisotropy, bool transmission, bool dispersion, bool sss) : base(JS.New("THREE.SSSLightingModel", clearcoat, sheen, iridescence, anisotropy, transmission, dispersion, sss)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// useSSS: boolean;
        /// </summary>
        public bool UseSSS { get => JSRef!.Get<bool>("useSSS"); set => JSRef!.Set("useSSS", value); }
        #endregion

        #region Methods
        /// <summary>
        /// direct(input: LightingModelDirectInput, builder: NodeBuilder): void;
        /// </summary>
        public void Direct(LightingModelDirectInput input, NodeBuilder builder)
        {
            JSRef!.CallVoid("direct", input, builder);
        }
        #endregion
    }
}
