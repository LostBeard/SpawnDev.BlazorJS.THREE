
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector4Uniform : Uniform<Vector4>
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector4Uniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, value?: Vector4);
        /// </summary>
        public Vector4Uniform(string name, Vector4 value) : base(JS.New("THREE.Vector4Uniform", name, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isVector4Uniform: true;
        /// </summary>
        public bool IsVector4Uniform { get => JSRef!.Get<bool>("isVector4Uniform"); }
        #endregion

        #region Methods

        #endregion
    }
}
