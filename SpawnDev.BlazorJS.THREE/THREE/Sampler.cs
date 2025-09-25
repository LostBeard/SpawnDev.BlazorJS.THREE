
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Sampler : Binding
    {
        #region Constructors
        /// <inheritdoc/>
        public Sampler(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, texture: Texture | null);
        /// </summary>
        public Sampler(string name, Texture texture) : base(JS.New("THREE.Sampler", name, texture)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// generation: number | null;
        /// </summary>
        public float Generation { get => JSRef!.Get<float>("generation"); set => JSRef!.Set("generation", value); }
        /// <summary>
        /// readonly isSampler: true;
        /// </summary>
        public bool IsSampler { get => JSRef!.Get<bool>("isSampler"); }
        /// <summary>
        /// set texture(value: Texture | null);
        /// </summary>
        public Texture Texture { get => JSRef!.Get<Texture>("texture"); set => JSRef!.Set("texture", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        #endregion

        #region Methods

        #endregion
    }
}
