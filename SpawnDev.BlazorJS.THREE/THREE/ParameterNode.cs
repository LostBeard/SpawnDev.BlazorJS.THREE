
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ParameterNode : PropertyNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ParameterNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeType: string, name?: string | null);
        /// </summary>
        public ParameterNode(string nodeType, string name) : base(JS.New("THREE.ParameterNode", nodeType, name)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isParameterNode: true;
        /// </summary>
        public bool IsParameterNode { get => JSRef!.Get<bool>("isParameterNode"); }
        #endregion

        #region Methods

        #endregion
    }
}
