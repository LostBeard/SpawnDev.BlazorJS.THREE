
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector2Uniform : Uniform<Vector2>
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector2Uniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, value?: Vector2);
        /// </summary>
        public Vector2Uniform(string name, Vector2 value) : base(JS.New("THREE.Vector2Uniform", name, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isVector2Uniform: true;
        /// </summary>
        public bool IsVector2Uniform { get => JSRef!.Get<bool>("isVector2Uniform"); }
        #endregion

        #region Methods

        #endregion
    }
}
