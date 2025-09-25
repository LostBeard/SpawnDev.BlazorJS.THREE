
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ColorUniform : Uniform<Color>
    {
        #region Constructors
        /// <inheritdoc/>
        public ColorUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, value?: Color);
        /// </summary>
        public ColorUniform(string name, Color value) : base(JS.New("THREE.ColorUniform", name, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isColorUniform: true;
        /// </summary>
        public bool IsColorUniform { get => JSRef!.Get<bool>("isColorUniform"); }
        #endregion

        #region Methods

        #endregion
    }
}
