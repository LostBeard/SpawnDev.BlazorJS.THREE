
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class UserDataNode<NodeUserData> : ReferenceNode<NodeUserData>
    {
        #region Constructors
        /// <inheritdoc/>
        public UserDataNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(property: string, inputType: string, userData?: NodeUserData | null);
        /// </summary>
        public UserDataNode(string property, string inputType, NodeUserData userData) : base(JS.New("THREE.UserDataNode", property, inputType, userData)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// userData: NodeUserData | null;
        /// </summary>
        public NodeUserData UserData { get => JSRef!.Get<NodeUserData>("userData"); set => JSRef!.Set("userData", value); }
        #endregion

        #region Methods

        #endregion
    }
}
