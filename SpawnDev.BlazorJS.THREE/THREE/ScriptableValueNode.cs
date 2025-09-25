
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ScriptableValueNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ScriptableValueNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(value: object);
        /// </summary>
        public ScriptableValueNode(object value) : base(JS.New("THREE.ScriptableValueNode", value)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
