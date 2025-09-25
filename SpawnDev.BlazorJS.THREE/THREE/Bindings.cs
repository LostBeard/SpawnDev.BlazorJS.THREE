
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Bindings : DataMap
    {
        #region Constructors
        /// <inheritdoc/>
        public Bindings(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         backend: Backend,
        ///         nodes: Nodes,
        ///         textures: Textures,
        ///         attributes: Attributes,
        ///         pipelines: Pipelines,
        ///         info: Info,
        ///     );
        /// </summary>
        public Bindings(Backend backend, Nodes nodes, Textures textures, Attributes attributes, Pipelines pipelines, Info info) : base(JS.New("THREE.Bindings", backend, nodes, textures, attributes, pipelines, info)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// attributes: Attributes;
        /// </summary>
        public Attributes Attributes { get => JSRef!.Get<Attributes>("attributes"); set => JSRef!.Set("attributes", value); }
        /// <summary>
        /// backend: Backend;
        /// </summary>
        public Backend Backend { get => JSRef!.Get<Backend>("backend"); set => JSRef!.Set("backend", value); }
        /// <summary>
        /// info: Info;
        /// </summary>
        public Info Info { get => JSRef!.Get<Info>("info"); set => JSRef!.Set("info", value); }
        /// <summary>
        /// nodes: Nodes;
        /// </summary>
        public Nodes Nodes { get => JSRef!.Get<Nodes>("nodes"); set => JSRef!.Set("nodes", value); }
        /// <summary>
        /// pipelines: Pipelines;
        /// </summary>
        public Pipelines Pipelines { get => JSRef!.Get<Pipelines>("pipelines"); set => JSRef!.Set("pipelines", value); }
        /// <summary>
        /// textures: Textures;
        /// </summary>
        public Textures Textures { get => JSRef!.Get<Textures>("textures"); set => JSRef!.Set("textures", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateForRender(renderObject: RenderObject): void;
        /// </summary>
        public void UpdateForRender(RenderObject renderObject)
        {
            JSRef!.CallVoid("updateForRender", renderObject);
        }
        /// <summary>
        /// updateForCompute(computeNode: ComputeNode): void;
        /// </summary>
        public void UpdateForCompute(ComputeNode computeNode)
        {
            JSRef!.CallVoid("updateForCompute", computeNode);
        }
        /// <summary>
        /// getForRender(renderObject: RenderObject): BindGroup[];
        /// </summary>
        public Array<BindGroup> GetForRender(RenderObject renderObject)
        {
            return JSRef!.Call<Array<BindGroup>>("getForRender", renderObject);
        }
        /// <summary>
        /// getForCompute(computeNode: ComputeNode): BindGroup[];
        /// </summary>
        public Array<BindGroup> GetForCompute(ComputeNode computeNode)
        {
            return JSRef!.Call<Array<BindGroup>>("getForCompute", computeNode);
        }
        #endregion
    }
}
