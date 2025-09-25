
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class UniformGroupNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public UniformGroupNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, shared?: boolean);
        /// </summary>
        public UniformGroupNode(string name, bool shared) : base(JS.New("THREE.UniformGroupNode", name, shared)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isUniformGroup: true;
        /// </summary>
        public bool IsUniformGroup { get => JSRef!.Get<bool>("isUniformGroup"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// shared: boolean;
        /// </summary>
        public bool Shared { get => JSRef!.Get<bool>("shared"); set => JSRef!.Set("shared", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        #endregion

        #region Methods

        #endregion
    }
}
