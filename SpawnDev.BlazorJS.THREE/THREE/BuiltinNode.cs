
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BuiltinNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public BuiltinNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string);
        /// </summary>
        public BuiltinNode(string name) : base(JS.New("THREE.BuiltinNode", name)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isBuiltinNode: true;
        /// </summary>
        public bool IsBuiltinNode { get => JSRef!.Get<bool>("isBuiltinNode"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        #endregion

        #region Methods

        #endregion
    }
}
