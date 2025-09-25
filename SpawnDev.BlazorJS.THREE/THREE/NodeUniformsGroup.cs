
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeUniformsGroup : UniformsGroup
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeUniformsGroup(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, groupNode: UniformGroupNode);
        /// </summary>
        public NodeUniformsGroup(string name, UniformGroupNode groupNode) : base(JS.New("THREE.NodeUniformsGroup", name, groupNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// groupNode: UniformGroupNode;
        /// </summary>
        public UniformGroupNode GroupNode { get => JSRef!.Get<UniformGroupNode>("groupNode"); set => JSRef!.Set("groupNode", value); }
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// readonly isNodeUniformsGroup: true;
        /// </summary>
        public bool IsNodeUniformsGroup { get => JSRef!.Get<bool>("isNodeUniformsGroup"); }
        #endregion

        #region Methods

        #endregion
    }
}
