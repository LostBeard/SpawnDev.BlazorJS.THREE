
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PhysicalLightingModel : LightingModel
    {
        #region Constructors
        /// <inheritdoc/>
        public PhysicalLightingModel(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         clearcoat?: boolean,
        ///         sheen?: boolean,
        ///         iridescence?: boolean,
        ///         anisotropy?: boolean,
        ///         transmission?: boolean,
        ///         dispersion?: boolean,
        ///     );
        /// </summary>
        public PhysicalLightingModel(bool clearcoat, bool sheen, bool iridescence, bool anisotropy, bool transmission, bool dispersion) : base(JS.New("THREE.PhysicalLightingModel", clearcoat, sheen, iridescence, anisotropy, transmission, dispersion)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// anisotropy: boolean;
        /// </summary>
        public bool Anisotropy { get => JSRef!.Get<bool>("anisotropy"); set => JSRef!.Set("anisotropy", value); }
        /// <summary>
        /// clearcoat: boolean;
        /// </summary>
        public bool Clearcoat { get => JSRef!.Get<bool>("clearcoat"); set => JSRef!.Set("clearcoat", value); }
        /// <summary>
        /// clearcoatRadiance: Node | null;
        /// </summary>
        public Node ClearcoatRadiance { get => JSRef!.Get<Node>("clearcoatRadiance"); set => JSRef!.Set("clearcoatRadiance", value); }
        /// <summary>
        /// clearcoatSpecularDirect: Node | null;
        /// </summary>
        public Node ClearcoatSpecularDirect { get => JSRef!.Get<Node>("clearcoatSpecularDirect"); set => JSRef!.Set("clearcoatSpecularDirect", value); }
        /// <summary>
        /// clearcoatSpecularIndirect: Node | null;
        /// </summary>
        public Node ClearcoatSpecularIndirect { get => JSRef!.Get<Node>("clearcoatSpecularIndirect"); set => JSRef!.Set("clearcoatSpecularIndirect", value); }
        /// <summary>
        /// dispersion: boolean;
        /// </summary>
        public bool Dispersion { get => JSRef!.Get<bool>("dispersion"); set => JSRef!.Set("dispersion", value); }
        /// <summary>
        /// iridescence: boolean;
        /// </summary>
        public bool Iridescence { get => JSRef!.Get<bool>("iridescence"); set => JSRef!.Set("iridescence", value); }
        /// <summary>
        /// iridescenceF0: Node | null;
        /// </summary>
        public Node IridescenceF0 { get => JSRef!.Get<Node>("iridescenceF0"); set => JSRef!.Set("iridescenceF0", value); }
        /// <summary>
        /// iridescenceFresnel: Node | null;
        /// </summary>
        public Node IridescenceFresnel { get => JSRef!.Get<Node>("iridescenceFresnel"); set => JSRef!.Set("iridescenceFresnel", value); }
        /// <summary>
        /// sheen: boolean;
        /// </summary>
        public bool Sheen { get => JSRef!.Get<bool>("sheen"); set => JSRef!.Set("sheen", value); }
        /// <summary>
        /// sheenSpecularDirect: Node | null;
        /// </summary>
        public Node SheenSpecularDirect { get => JSRef!.Get<Node>("sheenSpecularDirect"); set => JSRef!.Set("sheenSpecularDirect", value); }
        /// <summary>
        /// sheenSpecularIndirect: Node | null;
        /// </summary>
        public Node SheenSpecularIndirect { get => JSRef!.Get<Node>("sheenSpecularIndirect"); set => JSRef!.Set("sheenSpecularIndirect", value); }
        /// <summary>
        /// transmission: boolean;
        /// </summary>
        public bool Transmission { get => JSRef!.Get<bool>("transmission"); set => JSRef!.Set("transmission", value); }
        #endregion

        #region Methods
        /// <summary>
        /// computeMultiscattering(singleScatter: Node, multiScatter: Node, specularF90: Node): void;
        /// </summary>
        public void ComputeMultiscattering(Node singleScatter, Node multiScatter, Node specularF90)
        {
            JSRef!.CallVoid("computeMultiscattering", singleScatter, multiScatter, specularF90);
        }
        #endregion
    }
}
