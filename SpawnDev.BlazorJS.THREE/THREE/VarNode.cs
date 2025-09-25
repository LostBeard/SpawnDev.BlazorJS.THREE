
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class VarNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public VarNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(node: Node, name?: string | null, readOnly?: boolean);
        /// </summary>
        public VarNode(Node node, string name, bool readOnly) : base(JS.New("THREE.VarNode", node, name, readOnly)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// intent: boolean;
        /// </summary>
        public bool Intent { get => JSRef!.Get<bool>("intent"); set => JSRef!.Set("intent", value); }
        /// <summary>
        /// readonly isVarNode: true;
        /// </summary>
        public bool IsVarNode { get => JSRef!.Get<bool>("isVarNode"); }
        /// <summary>
        /// name: string | null;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// node: Node;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// readOnly: boolean;
        /// </summary>
        public bool ReadOnly { get => JSRef!.Get<bool>("readOnly"); set => JSRef!.Set("readOnly", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setIntent(value: boolean): this;
        /// </summary>
        public VarNode SetIntent(bool value)
        {
            return JSRef!.Call<VarNode>("setIntent", value);
        }
        /// <summary>
        /// getIntent(): boolean;
        /// </summary>
        public bool GetIntent()
        {
            return JSRef!.Call<bool>("getIntent");
        }
        #endregion
    }
}
