
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeLoader : Loader<NodeLoaderResult>
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public NodeLoader(LoadingManager manager) : base(JS.New("THREE.NodeLoader", manager)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// nodes: { [type: string]: Node };
        /// </summary>
        public object Nodes { get => JSRef!.Get<object>("nodes"); set => JSRef!.Set("nodes", value); }
        /// <summary>
        /// textures: { [key: string]: Texture };
        /// </summary>
        public object Textures { get => JSRef!.Get<object>("textures"); set => JSRef!.Set("textures", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setTextures(textures: { [key: string]: Texture }): this;
        /// </summary>
        public NodeLoader SetTextures(object textures, string key)
        {
            return JSRef!.Call<NodeLoader>("setTextures", textures, key);
        }
        /// <summary>
        /// setNodes(value: { [type: string]: Node }): this;
        /// </summary>
        public NodeLoader SetNodes(object value, string type)
        {
            return JSRef!.Call<NodeLoader>("setNodes", value, type);
        }
        /// <summary>
        /// parseNodes(json: object): NodeLoaderResult;
        /// </summary>
        public NodeLoaderResult ParseNodes(object json)
        {
            return JSRef!.Call<NodeLoaderResult>("parseNodes", json);
        }
        /// <summary>
        /// parse(json: object): Node;
        /// </summary>
        public Node Parse(object json)
        {
            return JSRef!.Call<Node>("parse", json);
        }
        /// <summary>
        /// createNodeFromType(type: string): Node;
        /// </summary>
        public Node CreateNodeFromType(string type)
        {
            return JSRef!.Call<Node>("createNodeFromType", type);
        }
        #endregion
    }
}
