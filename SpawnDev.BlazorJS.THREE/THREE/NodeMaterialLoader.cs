
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeMaterialLoader : MaterialLoader
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeMaterialLoader(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// nodeMaterials: { [type: string]: NodeMaterial };
        /// </summary>
        public object NodeMaterials { get => JSRef!.Get<object>("nodeMaterials"); set => JSRef!.Set("nodeMaterials", value); }
        /// <summary>
        /// nodes: NodeLoaderResult;
        /// </summary>
        public NodeLoaderResult Nodes { get => JSRef!.Get<NodeLoaderResult>("nodes"); set => JSRef!.Set("nodes", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setNodes(value: NodeLoaderResult): this;
        /// </summary>
        public NodeMaterialLoader SetNodes(NodeLoaderResult value)
        {
            return JSRef!.Call<NodeMaterialLoader>("setNodes", value);
        }
        /// <summary>
        /// setNodeMaterials(value: { [type: string]: NodeMaterial }): this;
        /// </summary>
        public NodeMaterialLoader SetNodeMaterials(object value, string type)
        {
            return JSRef!.Call<NodeMaterialLoader>("setNodeMaterials", value, type);
        }
        #endregion
    }
}
