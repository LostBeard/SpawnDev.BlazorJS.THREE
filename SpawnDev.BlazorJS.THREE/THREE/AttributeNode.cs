
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AttributeNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public AttributeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(attributeName: string, nodeType?: string | null);
        /// </summary>
        public AttributeNode(string attributeName, string nodeType) : base(JS.New("THREE.AttributeNode", attributeName, nodeType)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// setAttributeName(attributeName: string): this;
        /// </summary>
        public AttributeNode SetAttributeName(string attributeName)
        {
            return JSRef!.Call<AttributeNode>("setAttributeName", attributeName);
        }
        /// <summary>
        /// getAttributeName(builder: NodeBuilder): string;
        /// </summary>
        public string GetAttributeName(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getAttributeName", builder);
        }
        #endregion
    }
}
