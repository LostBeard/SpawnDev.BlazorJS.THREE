
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Nodes : DataMap
    {
        #region Constructors
        /// <inheritdoc/>
        public Nodes(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// backend: Backend;
        /// </summary>
        public Backend Backend { get => JSRef!.Get<Backend>("backend"); set => JSRef!.Set("backend", value); }
        /// <summary>
        /// CacheKeyData>;
        /// </summary>
        public JSObject CacheKeyData { get => JSRef!.Get<JSObject>("CacheKeyData"); set => JSRef!.Set("CacheKeyData", value); }
        ///// <summary>
        ///// callHashCache: ChainMap<readonly[Scene, LightsNode
        ///// </summary>
        //public ChainMap<object, LightsNode> CallHashCache { get => JSRef!.Get<ChainMap<object, LightsNode>>("callHashCache"); set => JSRef!.Set("callHashCache", value); }
        ///// <summary>
        ///// groupsData: ChainMap<readonly[UniformGroupNode, NodeUniformsGroup
        ///// </summary>
        //public ChainMap<object, NodeUniformsGroup> GroupsData { get => JSRef!.Get<ChainMap<object, NodeUniformsGroup>>("groupsData"); set => JSRef!.Set("groupsData", value); }
        /// <summary>
        /// nodeBuilderCache: Map<string, NodeBuilderState>;
        /// </summary>
        public Map<string, NodeBuilderState> NodeBuilderCache { get => JSRef!.Get<Map<string, NodeBuilderState>>("nodeBuilderCache"); set => JSRef!.Set("nodeBuilderCache", value); }
        /// <summary>
        /// nodeFrame: NodeFrame;
        /// </summary>
        public NodeFrame NodeFrame { get => JSRef!.Get<NodeFrame>("nodeFrame"); set => JSRef!.Set("nodeFrame", value); }
        /// <summary>
        /// renderer: Renderer;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        #endregion

        #region Methods

        #endregion
    }
}
