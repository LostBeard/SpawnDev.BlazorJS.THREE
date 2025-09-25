
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ExpressionNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ExpressionNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(snipped?: string, nodeType?: string);
        /// </summary>
        public ExpressionNode(string snipped, string nodeType) : base(JS.New("THREE.ExpressionNode", snipped, nodeType)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// snipped: string;
        /// </summary>
        public string Snipped { get => JSRef!.Get<string>("snipped"); set => JSRef!.Set("snipped", value); }
        #endregion

        #region Methods

        #endregion
    }
}
