
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeSampler : Sampler
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeSampler(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, textureNode: TextureNode | undefined, groupNode: UniformGroupNode);
        /// </summary>
        public NodeSampler(string name, TextureNode textureNode, UniformGroupNode groupNode) : base(JS.New("THREE.NodeSampler", name, textureNode, groupNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// groupNode: UniformGroupNode;
        /// </summary>
        public UniformGroupNode GroupNode { get => JSRef!.Get<UniformGroupNode>("groupNode"); set => JSRef!.Set("groupNode", value); }
        /// <summary>
        /// textureNode: TextureNode | undefined;
        /// </summary>
        public TextureNode TextureNode { get => JSRef!.Get<TextureNode>("textureNode"); set => JSRef!.Set("textureNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(): void;
        /// </summary>
        public void Update()
        {
            JSRef!.CallVoid("update");
        }
        #endregion
    }
}
