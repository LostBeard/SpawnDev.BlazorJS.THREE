
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LightProbe : Light
    {
        #region Constructors
        /// <inheritdoc/>
        public LightProbe(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(sh?: SphericalHarmonics3, intensity?: number);
        /// </summary>
        public LightProbe(SphericalHarmonics3 sh, float intensity) : base(JS.New("THREE.LightProbe", sh, intensity)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isLightProbe: true;
        /// </summary>
        public bool IsLightProbe { get => JSRef!.Get<bool>("isLightProbe"); }
        /// <summary>
        /// sh: SphericalHarmonics3;
        /// </summary>
        public SphericalHarmonics3 Sh { get => JSRef!.Get<SphericalHarmonics3>("sh"); set => JSRef!.Set("sh", value); }
        #endregion

        #region Methods
        /// <summary>
        /// fromJSON(json: {}): LightProbe;
        /// </summary>
        public LightProbe FromJSON(object json)
        {
            return JSRef!.Call<LightProbe>("fromJSON", json);
        }
        #endregion
    }
}
