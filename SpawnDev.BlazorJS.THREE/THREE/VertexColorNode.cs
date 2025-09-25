
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class VertexColorNode : AttributeNode
    {
        #region Constructors
        /// <inheritdoc/>
        public VertexColorNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(index: number);
        /// </summary>
        public VertexColorNode(float index) : base(JS.New("THREE.VertexColorNode", index)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// index: number;
        /// </summary>
        public float Index { get => JSRef!.Get<float>("index"); set => JSRef!.Set("index", value); }
        /// <summary>
        /// readonly isVertexColorNode: true;
        /// </summary>
        public bool IsVertexColorNode { get => JSRef!.Get<bool>("isVertexColorNode"); }
        #endregion

        #region Methods

        #endregion
    }
}
