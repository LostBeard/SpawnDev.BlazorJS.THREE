
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class TempNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public TempNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(type: string | null);
        /// </summary>
        public TempNode(string type) : base(JS.New("THREE.TempNode", type)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// isTempNode: true;
        /// </summary>
        public bool IsTempNode { get => JSRef!.Get<bool>("isTempNode"); set => JSRef!.Set("isTempNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// hasDependencies(builder: NodeBuilder): boolean;
        /// </summary>
        public bool HasDependencies(NodeBuilder builder)
        {
            return JSRef!.Call<bool>("hasDependencies", builder);
        }
        #endregion
    }
}
