
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class UniformBuffer : Buffer
    {
        #region Constructors
        /// <inheritdoc/>
        public UniformBuffer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name?: string, buffer?: null);
        /// </summary>
        public UniformBuffer(string name, object buffer) : base(JS.New("THREE.UniformBuffer", name, buffer)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isUniformBuffer: true;
        /// </summary>
        public bool IsUniformBuffer { get => JSRef!.Get<bool>("isUniformBuffer"); }
        #endregion

        #region Methods

        #endregion
    }
}
