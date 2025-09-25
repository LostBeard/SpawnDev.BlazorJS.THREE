
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix3Uniform : Uniform<Matrix3>
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix3Uniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, value?: Matrix3);
        /// </summary>
        public Matrix3Uniform(string name, Matrix3 value) : base(JS.New("THREE.Matrix3Uniform", name, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMatrix3Uniform: true;
        /// </summary>
        public bool IsMatrix3Uniform { get => JSRef!.Get<bool>("isMatrix3Uniform"); }
        #endregion

        #region Methods

        #endregion
    }
}
