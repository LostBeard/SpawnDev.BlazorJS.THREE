
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class IndexNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public IndexNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope: IndexNodeScope);
        /// </summary>
        public IndexNode(IndexNodeScope scope) : base(JS.New("THREE.IndexNode", scope)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static DRAW: "draw";
        /// </summary>
        public static string DRAW { get => JS.Get<string>("THREE.IndexNode.DRAW"); set => JS.Set("THREE.IndexNode.DRAW", value); }
        /// <summary>
        /// static INSTANCE: "instance";
        /// </summary>
        public static string INSTANCE { get => JS.Get<string>("THREE.IndexNode.INSTANCE"); set => JS.Set("THREE.IndexNode.INSTANCE", value); }
        /// <summary>
        /// static INVOCATION_LOCAL: "invocationLocal";
        /// </summary>
        public static string INVOCATION_LOCAL { get => JS.Get<string>("THREE.IndexNode.INVOCATION_LOCAL"); set => JS.Set("THREE.IndexNode.INVOCATION_LOCAL", value); }
        /// <summary>
        /// readonly isInstanceNode: true;
        /// </summary>
        public bool IsInstanceNode { get => JSRef!.Get<bool>("isInstanceNode"); }
        /// <summary>
        /// scope: IndexNodeScope;
        /// </summary>
        public IndexNodeScope Scope { get => JSRef!.Get<IndexNodeScope>("scope"); set => JSRef!.Set("scope", value); }
        /// <summary>
        /// static VERTEX: "vertex";
        /// </summary>
        public static string VERTEX { get => JS.Get<string>("THREE.IndexNode.VERTEX"); set => JS.Set("THREE.IndexNode.VERTEX", value); }
        #endregion

        #region Methods

        #endregion
    }
}
