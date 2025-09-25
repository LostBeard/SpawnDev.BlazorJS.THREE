
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SampledTexture : Sampler
    {
        #region Constructors
        /// <inheritdoc/>
        public SampledTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, texture: Texture | null);
        /// </summary>
        public SampledTexture(string name, Texture texture) : base(JS.New("THREE.SampledTexture", name, texture)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// readonly isSampledTexture: true;
        /// </summary>
        public bool IsSampledTexture { get => JSRef!.Get<bool>("isSampledTexture"); }
        /// <summary>
        /// store: boolean;
        /// </summary>
        public bool Store { get => JSRef!.Get<bool>("store"); set => JSRef!.Set("store", value); }
        #endregion

        #region Methods

        #endregion
    }
}
