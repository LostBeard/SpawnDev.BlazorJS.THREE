
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeCode : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeCode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, type: string, code?: string);
        /// </summary>
        public NodeCode(string name, string type, string code) : base(JS.New("THREE.NodeCode", name, type, code)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// isNodeCode: true;
        /// </summary>
        public bool IsNodeCode { get => JSRef!.Get<bool>("isNodeCode"); set => JSRef!.Set("isNodeCode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
