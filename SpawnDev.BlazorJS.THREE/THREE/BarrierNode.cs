
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BarrierNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public BarrierNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope: string);
        /// </summary>
        public BarrierNode(string scope) : base(JS.New("THREE.BarrierNode", scope)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// scope: string;
        /// </summary>
        public string Scope { get => JSRef!.Get<string>("scope"); set => JSRef!.Set("scope", value); }
        #endregion

        #region Methods

        #endregion
    }
}
