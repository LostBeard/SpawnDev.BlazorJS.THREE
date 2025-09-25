
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeObjectLoader : ObjectLoader
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeObjectLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public NodeObjectLoader(LoadingManager manager) : base(JS.New("THREE.NodeObjectLoader", manager)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodeMaterials: { [type: string]: NodeMaterial };
        /// </summary>
        public object NodeMaterials { get => JSRef!.Get<object>("nodeMaterials"); set => JSRef!.Set("nodeMaterials", value); }
        /// <summary>
        /// nodes: { [type: string]: Node };
        /// </summary>
        public object Nodes { get => JSRef!.Get<object>("nodes"); set => JSRef!.Set("nodes", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setNodes(value: { [type: string]: Node }): this;
        /// </summary>
        public NodeObjectLoader SetNodes(object value, string type)
        {
            return JSRef!.Call<NodeObjectLoader>("setNodes", value, type);
        }
        /// <summary>
        /// setNodeMaterials(value: { [type: string]: NodeMaterial }): this;
        /// </summary>
        public NodeObjectLoader SetNodeMaterials(object value, string type)
        {
            return JSRef!.Call<NodeObjectLoader>("setNodeMaterials", value, type);
        }
        /// <summary>
        /// parseNodes(json: object, textures: { [key: string]: Texture }): NodeLoaderResult;
        /// </summary>
        public NodeLoaderResult ParseNodes(object json, object textures, string key)
        {
            return JSRef!.Call<NodeLoaderResult>("parseNodes", json, textures, key);
        }
        ///// <summary>
        ///// parseMaterials(json: object, textures: { [key: string]: Texture }): { [key: string]: Material };
        ///// </summary>
        //public object ParseMaterials(object json, object textures, string key)
        //{
        //    return JSRef!.Call<object>("parseMaterials", json, textures, key);
        //}
        #endregion
    }
}
