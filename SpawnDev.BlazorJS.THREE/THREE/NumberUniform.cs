
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NumberUniform : Uniform<float>
    {
        #region Constructors
        /// <inheritdoc/>
        public NumberUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, value?: number);
        /// </summary>
        public NumberUniform(string name, float value) : base(JS.New("THREE.NumberUniform", name, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isNumberUniform: true;
        /// </summary>
        public bool IsNumberUniform { get => JSRef!.Get<bool>("isNumberUniform"); }
        #endregion

        #region Methods

        #endregion
    }
}
