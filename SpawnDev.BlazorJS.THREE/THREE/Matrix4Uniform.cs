
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix4Uniform : Uniform<Matrix4>
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix4Uniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, value?: Matrix4);
        /// </summary>
        public Matrix4Uniform(string name, Matrix4 value) : base(JS.New("THREE.Matrix4Uniform", name, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMatrix4Uniform: true;
        /// </summary>
        public bool IsMatrix4Uniform { get => JSRef!.Get<bool>("isMatrix4Uniform"); }
        #endregion

        #region Methods

        #endregion
    }
}
