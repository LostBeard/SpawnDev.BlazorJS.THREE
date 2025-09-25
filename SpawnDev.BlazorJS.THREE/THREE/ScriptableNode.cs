
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ScriptableNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ScriptableNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(codeNode?: Node | null, parameters?: Record<string, object>);
        /// </summary>
        public ScriptableNode(Node codeNode, Record<string, object> parameters) : base(JS.New("THREE.ScriptableNode", codeNode, parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// codeNode: Node | null;
        /// </summary>
        public Node CodeNode { get => JSRef!.Get<Node>("codeNode"); set => JSRef!.Set("codeNode", value); }
        /// <summary>
        /// parameters: Record<string, object>;
        /// </summary>
        public Record<string, object> Parameters { get => JSRef!.Get<Record<string, object>>("parameters"); set => JSRef!.Set("parameters", value); }
        #endregion

        #region Methods

        #endregion
    }
}
