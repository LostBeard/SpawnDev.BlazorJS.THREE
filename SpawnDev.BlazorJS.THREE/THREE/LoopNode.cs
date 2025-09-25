
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LoopNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public LoopNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(params?: object[]);
        /// </summary>
        public LoopNode(Array<object> parameters) : base(JS.New("THREE.LoopNode", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// params: object[];
        /// </summary>
        public Array<object> Params { get => JSRef!.Get<Array<object>>("params"); set => JSRef!.Set("params", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getProperties(builder: NodeBuilder): object;
        /// </summary>
        public object GetProperties(NodeBuilder builder)
        {
            return JSRef!.Call<object>("getProperties", builder);
        }
        #endregion
    }
}
