
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PropertyNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public PropertyNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodeType?: string | null, name?: string | null, varying?: boolean);
        /// </summary>
        public PropertyNode(string nodeType, string name, bool varying) : base(JS.New("THREE.PropertyNode", nodeType, name, varying)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isPropertyNode: true;
        /// </summary>
        public bool IsPropertyNode { get => JSRef!.Get<bool>("isPropertyNode"); }
        /// <summary>
        /// name: string | null;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// varying: boolean;
        /// </summary>
        public bool Varying { get => JSRef!.Get<bool>("varying"); set => JSRef!.Set("varying", value); }
        #endregion

        #region Methods

        #endregion
    }
}
