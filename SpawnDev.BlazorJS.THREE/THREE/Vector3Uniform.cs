
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Vector3Uniform : Uniform<Vector3>
    {
        #region Constructors
        /// <inheritdoc/>
        public Vector3Uniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, value?: Vector3);
        /// </summary>
        public Vector3Uniform(string name, Vector3 value) : base(JS.New("THREE.Vector3Uniform", name, value)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isVector3Uniform: true;
        /// </summary>
        public bool IsVector3Uniform { get => JSRef!.Get<bool>("isVector3Uniform"); }
        #endregion

        #region Methods

        #endregion
    }
}
