
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Matrix2Uniform : Uniform<Matrix2>
    {
        #region Constructors
        /// <inheritdoc/>
        public Matrix2Uniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, value?: Matrix2);
        /// </summary>
        public Matrix2Uniform(string name, Matrix2 value) : base(JS.New("THREE.Matrix2Uniform", name, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMatrix2Uniform: true;
        /// </summary>
        public bool IsMatrix2Uniform { get => JSRef!.Get<bool>("isMatrix2Uniform"); }
        #endregion

        #region Methods

        #endregion
    }
}
